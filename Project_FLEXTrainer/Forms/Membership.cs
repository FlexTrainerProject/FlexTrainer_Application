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

namespace Project_FLEXTrainer.Forms
{
    public partial class Membership : Form
    {
        string connectionString;
        User currUser;
        public Membership(User user)
        {
            InitializeComponent();
            currUser = user;
            gunaCombo.SelectedIndexChanged += gunaCombo_SelectedIndexChanged;
            connectionString = Essentials.ConnectionString.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
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



        }

        private void closeError_Click(object sender, EventArgs e)
        {
            noMemberPanel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO MemberMembership VALUES ((SELECT COUNT(memberId)+1 FROM MemberMembership), (SELECT id\r\nFROM userr\r\nWHERE username = @username), (SELECT id\r\nFrom gym\r\nWHERE gym.name=@gymName), 'Basic','2024-06-14');";
            string selectedGymName = gunaCombo.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@username", currUser.Username);
                        command.Parameters.AddWithValue("@gymName", selectedGymName);
                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void gunaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaCombo.SelectedIndex != -1)
            {
                string selectedGymName = gunaCombo.SelectedItem.ToString();

                string sqlQuery = "SELECT basic_price, premium_price\r\nFROM gymMembership\r\nINNER JOIN gym on gym.id=gymMembership.gymId\r\nWHERE gym.name=@gymName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@gymName", selectedGymName);
                            connection.Open();

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                lblBasic.Text = "$" + reader["basic_price"].ToString();
                                lblPremium.Text = "$" + reader["premium_price"].ToString();
                            }

                            // Close the SqlDataReader
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
