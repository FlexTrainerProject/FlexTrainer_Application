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

namespace Project_FLEXTrainer.Trainer.Forms
{
    public partial class viewMembers : Form
    {
        public delegate void DisplayEntryDelegate(string name, string gender);
        string connectionString;
        User currUser;
        public viewMembers(User user)
        {
            InitializeComponent();
            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
            panelTemplate.Visible = false;

            LoadData();

        }

        private void LoadData()
        {


            string query = "EXEC ViewMembersForTrainer @userID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userID", currUser.userId);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        string str1 = reader["name"].ToString();
                        string str2 = reader["gender"].ToString();

                        displayDelegate.Invoke(str1 ,str2);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
        public void DisplayEntry(string name, string gender)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name == "name")
                        label.Text = "Name: " + name;
                    else if (label.Name == "gender")
                        label.Text = "Gender: " + gender;

                }
            }

            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }
    }
}
