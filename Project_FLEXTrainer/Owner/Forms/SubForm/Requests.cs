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

namespace Project_FLEXTrainer.Owner.Forms.SubForm
{
    public partial class Requests : Form
    {
        User currUser;
        string connectionString;
        public delegate void DisplayEntryDelegate(string name, string exp, string qual, string specs);
        public Requests(User user)
        {
            InitializeComponent();
            currUser = user;
            connectionString = Essentials.ConnectionString.GetConnectionString();
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
                    if (newControl.Name == "btnAccept")
                    {
                        Button newButton = (Button)newControl;
                        newButton.Image = imageList1.Images[0];
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                    }else if(newControl.Name == "btnReject")
                    {
                        Button newButton = (Button)newControl;
                        newButton.Image = imageList1.Images[1];
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                    }
                }

                /*if (newControl is Label)
                {
                    if (newControl.Name == "ID_hidden")
                    {
                        newControl.Visible = false;
                    }
                    Label newLabel = (Label)newControl;
                    newLabel.AutoSize = true; // Set AutoSize property to true for labels
                }*/
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

            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();



            //string connectionString = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            //string connectionString = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            string queryMain = "EXEC GetTrainerRequests;";
            int count = 0;
            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(queryMain, connection);
                command1.Parameters.AddWithValue("@gymName", gymMembership);

                try
                {
                    connection.Open();
                    SqlDataReader reader1 = command1.ExecuteReader();

                    DisplayEntryDelegate displayDelegate = DisplayEntry;

                    while (reader1.Read())
                    {
                        count++;
                        string name = reader1["name"].ToString();
                        string gender = reader1["gender"].ToString();
                        string experience = reader1["experience"].ToString();
                        string rating = reader1["rating"].ToString();
                        string id = reader1["id"].ToString();
                        //string username = "nigga";

                        //label2.Text = username;

                        displayDelegate.Invoke(name, gender, experience, rating, id);
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("No trainers working at the Gym you've applied for");
                    }
                    reader1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }*/
        }

    }
}
