using Guna.UI2.WinForms.Suite;
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
using System.Xml.Linq;
using static Project_FLEXTrainer.Forms.bookSession;

namespace Project_FLEXTrainer.Admin.Forms
{

    public delegate void DisplayEntryDelegate_r(int id, string name, string gname, string location);
    public partial class Requests : Form
    {
        private Button activeButton;
        private Panel dpanel;
        public Requests(Panel panel)
        {
            InitializeComponent();
            LoadData();
            panelTemplate.Visible = false;
            dpanel = panel;
        }

        private void activateBtn(object sender)
        {
            if (sender != null)
            {
                if (activeButton != (Button)sender)
                {
                    disableBtn();
                    Color color = Color.FromArgb(76, 126, 122);
                    activeButton = (Button)sender;
                    activeButton.BackColor = color;
                    activeButton.ForeColor = Color.White;
                    activeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);


                }
            }
        }

        private void disableBtn()
        {
            foreach (Control prevbtn in navPanel.Controls)
            {
                if (prevbtn.GetType() == typeof(Button))
                {
                    prevbtn.BackColor = Color.FromArgb(25, 42, 40);
                    prevbtn.ForeColor = Color.Gainsboro;
                    prevbtn.Font = new Font("Segoe UI", 14.25F);
                }
            }
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
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

                if (newControl is Guna.UI2.WinForms.Guna2GradientButton)
                {
                    Guna.UI2.WinForms.Guna2GradientButton newButton = (Guna.UI2.WinForms.Guna2GradientButton)newControl;
                    if (newButton.Name == "btnAccept")
                    {
                        newButton.Dock = DockStyle.Right;
                        newButton.AutoSize = false;
                        newButton.FillColor = Color.FromArgb(42, 101, 97);
                        newButton.FillColor2 = Color.Teal;
                        newButton.Height = 29;
                        newButton.Width = 83;
                    }
                    if (newButton.Name == "btnReject")
                    {
                        newButton.Dock = DockStyle.Right;
                        newButton.Height = 29;
                        newButton.Width =  83;
                        newButton.FillColor = Color.FromArgb(113, 34, 40);
                        newButton.FillColor2 = Color.FromArgb(113, 34, 40);
                    }
                }

                if (newControl is Label)
                {

                    Label newLabel = (Label)newControl;
                    newLabel.AutoSize = true; // Set AutoSize property to true for labels
                }
            }

            return newPanel;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            dpanel.Controls.Add(childForm);
            dpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pgTitle.Text = childForm.Text;
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
            string connectionString = Essentials.ConnectionString.GetConnectionString();
            //string connectionString = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            //string connectionString = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            string query = "Select REQUEST.ID, CONCAT(firstname,' ', lastname) as name,GYMname,location from REQUEST JOIN userr on REQUEST.memberID = userr.id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DisplayEntryDelegate_r displayDelegate = DisplayEntry;

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID");
                        string name = reader["name"].ToString();
                        string gname = reader["GYMname"].ToString();
                        string location = reader["location"].ToString();

                        displayDelegate.Invoke(id, name, gname, location);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DisplayEntry(int id, string name, string gname, string location)
        {
            Panel templatePanel = panelTemplate; // Assuming panelTemplate is your template panel

            Panel entryPanel = CreatePanelFromTemplate(templatePanel);


            foreach (Control control in entryPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    if (label.Name == "nameLabel")
                        label.Text = "Name: " + name;
                    else if (label.Name == "genderLabel")
                        label.Text = "Gender: " + gname;
                    else if (label.Name == "experienceLabel")
                        label.Text = "Experience: " + location;
                    else if (label.Name == "ratingLabel")
                        label.Text = "Rating: ";
                }
                else if (control is Guna.UI2.WinForms.Guna2GradientButton)
                {
                    Guna.UI2.WinForms.Guna2GradientButton button = (Guna.UI2.WinForms.Guna2GradientButton)control;

                    if (button.Name == "btnAccept")
                    {
                        button.Click += (sender, e) =>
                        {
                            

                        };
                    }
                    if (button.Name == "btnReject")
                    {
                        button.Click += (sender, e) =>
                        {
                            string connect = Essentials.ConnectionString.GetConnectionString();
                            //string connect = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
                            SqlConnection connection = new SqlConnection(connect);
                            connection.Open();
                            SqlCommand comm = new SqlCommand("Delete from REQUEST where id = '" + id + "';", connection);
                            comm.ExecuteNonQuery();
                            this.Close();
                            connection.Close();

                            this.Close();
                            OpenChildForm(new Forms.Requests(dpanel), sender);
                        };
                    }

                }
            }


            // Calculate vertical position based on existing panels
            int yOffset = panelContainer.Controls.Cast<Control>().Sum(control => control.Height + control.Margin.Vertical);

            entryPanel.Location = new Point(0, yOffset);

            panelContainer.Controls.Add(entryPanel);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
