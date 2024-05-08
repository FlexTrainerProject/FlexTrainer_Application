using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_FLEXTrainer.Forms
{
    public partial class bookSession : Form
    {
        public delegate void DisplayEntryDelegate(string name, string gender, string experience, string rating, string id);
        public bookSession()
        {
            InitializeComponent();

            LoadData();
            //redPanel.Visible = false;
            panelTemplate.Visible = false;
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
                }

                if (newControl is Label)
                {
                    if (newControl.Name == "ID_hidden")
                    {
                        newControl.Visible = false;
                    }
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

        private void LoadData()
        {
            //string connectionString = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            string connectionString = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            string query = "select concat(firstname,' ',lastname) as name, gender, experience, rating, trainer.id from userr\r\njoin account on account.username=userr.username\r\njoin trainer on trainer.id=userr.id\r\nwhere account.account_type='trainer'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string gender = reader["gender"].ToString();
                        string experience = reader["experience"].ToString();
                        string rating = reader["rating"].ToString();
                        string id = reader["id"].ToString();
                        //string username = "nigga";

                        //label2.Text = username;

                        displayDelegate.Invoke(name, gender, experience, rating, id);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DisplayEntry(string name, string gender, string experience, string rating, string id)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    //label2.Text = username;
                    if (label.Name == "nameLabel")
                        label.Text = "Name: " + name;
                    else if (label.Name == "genderLabel")
                        label.Text = "Gender: " + gender;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Experience: " + experience;
                    else if (label.Name == "ratingLabel")
                        label.Text = "Rating: " + rating;
                    else if (label.Name == "ID_hidden")
                        label.Text = id;
                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += (sender, e) =>
                    {
                        Forms.SubForms.TrainerInfo SubForm = new Forms.SubForms.TrainerInfo(id, name, gender, experience, rating);
                        SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
                        SubForm.StartPosition = FormStartPosition.CenterScreen;

                        SubForm.Show(); // Show the form as a separate window
                    };
                }

            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

    }
}
