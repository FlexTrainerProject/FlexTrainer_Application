using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_FLEXTrainer.Forms.bookSession;
using Project_FLEXTrainer.Essentials.MessageBoxes;

namespace Project_FLEXTrainer.Forms
{

    public delegate void DisplayEntryDelegate(string goal, string experience_lvl, string schedule);
    public partial class workoutPlans : Form
    {
        User user;
        public workoutPlans(User User)
        {
            InitializeComponent();

            DisplayWorkoutPlan();

            panelTemplate.Visible = false;
            user = User;
        }


        private void btnCreateWP_Click(object sender, EventArgs e)
        {
            if (user.isProfileComplete == false)
            {
                Form messageBox = new customMessage_CompleteProfile();
                messageBox.FormBorderStyle = FormBorderStyle.None;
                messageBox.StartPosition= FormStartPosition.CenterScreen;
                messageBox.Show();
                
                return;
            }
            Forms.SubForms.createWorkoutPlan SubForm = new Forms.SubForms.createWorkoutPlan(user);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show();
        }

        private Panel CreatePanelFromTemplate(Panel templatePanel)
        {
            Panel newPanel = new Panel();
            newPanel.BorderStyle = templatePanel.BorderStyle;
            newPanel.BackColor = templatePanel.BackColor;
            newPanel.Width = templatePanel.Width;
            newPanel.Height = templatePanel.Height;
            newPanel.Padding = templatePanel.Padding;
            newPanel.Dock = DockStyle.None;

            foreach (Control control in templatePanel.Controls)
            {
                Control newControl = CreateControlFromTemplate(control);
                newPanel.Controls.Add(newControl);

                if (newControl is Button)
                {
                    Button newButton = (Button)newControl;
                    newButton.Image = imageList1.Images[0];
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    newButton.ImageAlign = ContentAlignment.MiddleLeft;
                }

                if (newControl is Label)
                {

                    Label newLabel = (Label)newControl;
                    newLabel.AutoSize = true; // Set AutoSize property to true for labels
                }
            }

            return newPanel;
        }


        private Control CreateControlFromTemplate(Control templateControl)
        {
            Control newControl = (Control)Activator.CreateInstance(templateControl.GetType());
            newControl.Name = templateControl.Name; // Set control name
            newControl.Location = templateControl.Location;
            newControl.Size = templateControl.Size;
            newControl.BackColor = templateControl.BackColor;
            newControl.ForeColor = templateControl.ForeColor;
            newControl.Font = templateControl.Font;
            newControl.Text = templateControl.Text;
            newControl.Dock = templateControl.Dock;
            newControl.Padding = templateControl.Padding;
            newControl.Location = templateControl.Location;

            return newControl;
        }
        public void DisplayEntry(string goal, string experience_lvl, string schedule)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "nameLabel")
                        label.Text = "Goal: " + goal;
                    else if (label.Name == "genderLabel")
                        label.Text = "Schedule: " + schedule;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Experience: " + experience_lvl;

                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {

                    };
                }

            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

        private void DisplayWorkoutPlan()
        {
            string connect = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            //string connect = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";

            String query = "Select* from workout_plan";

            using (SqlConnection connection = new SqlConnection(connect))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string goal = reader["goal"].ToString();
                        string experience_lvl = reader["experience_lvl"].ToString();
                        string schedule = reader["schedule"].ToString();

                        displayDelegate.Invoke(goal, experience_lvl, schedule);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           //work for YOU HAMDAN
            
        }
    }
}
