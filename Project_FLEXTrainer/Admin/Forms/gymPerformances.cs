using Project_FLEXTrainer.Essentials;
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

namespace Project_FLEXTrainer.Admin.Forms
{
    public partial class gymPerformances : Form
    {
        public gymPerformances()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString()))
            {
                string sqlQuery = "SELECT name FROM gym";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        gunaCombo.Items.Clear();

                        while (reader.Read())
                        {
                            string gymName = reader["name"].ToString();
                            gunaCombo.Items.Add(gymName);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            gunaCombo.SelectedIndexChanged += new EventHandler(gunaCombo_SelectedIndexChanged);
            
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {

        }

        private void pgTitle_Click(object sender, EventArgs e)
        {

        }

        private void gunaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(Essentials.ConnectionString.GetConnectionString()))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(MemberMembership.MembershipId) FROM MemberMembership WHERE gymId = (SELECT gym.id FROM gym WHERE gym.name = @currentgym)", connect))
                {
                    cmd.Parameters.AddWithValue("@currentgym", gunaCombo.SelectedItem.ToString());
                    string count = Convert.ToString(cmd.ExecuteScalar());
                    label2.Text = count;
                }
            }
        }

        // Add this line in your form constructor or wherever you're setting up your form
        

    }
}
