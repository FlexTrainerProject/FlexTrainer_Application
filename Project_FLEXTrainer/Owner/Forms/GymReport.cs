using Microsoft.VisualBasic.ApplicationServices;
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

namespace Project_FLEXTrainer.Owner.Forms
{
    public partial class GymReport : Form
    {
        public GymReport(User current)
        {

            InitializeComponent();
            SqlConnection connection = new SqlConnection(Essentials.ConnectionString.GetConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select gym.name from gym INNER JOIN owner on gym.owner_id =owner.id INNER JOIN userr on userr.id = owner_id where userr.username = '" + current.Username + "'", connection);
            string name = Convert.ToString(cmd.ExecuteScalar());
            cmd = new SqlCommand("Select gym.location from gym INNER JOIN owner on gym.owner_id =owner.id INNER JOIN userr on userr.id = owner_id where userr.username = '" + current.Username + "'", connection);
            string location = Convert.ToString(cmd.ExecuteScalar());

            label2.Text = name;
            label4.Text = location;

            cmd = new SqlCommand("Select COUNT(MemberMembership.memberId) as count from MemberMembership where MemberMembership.gymId = (Select gym.id from gym where owner_id = (Select id from userr where userr.username = @currentuser))", connection);
            cmd.Parameters.AddWithValue("@currentuser", current.Username);
            string member = Convert.ToString(cmd.ExecuteScalar());
            label8.Text = member;


            cmd = new SqlCommand("Select COUNT(gym_assign_to_trainer.trainerid) as count from gym_assign_to_trainer where gym_assign_to_trainer.gym_id = (Select gym.id from gym where owner_id = (Select id from userr where userr.username = @currentuser))", connection);
            cmd.Parameters.AddWithValue("@currentuser", current.Username);
            string trainer = Convert.ToString(cmd.ExecuteScalar());
            label9.Text = trainer;

            cmd = new SqlCommand("SELECT AVG(CAST(tr.rating AS DECIMAL(10,2))) AS AverageTrainerRating FROM account a JOIN userr u ON a.username = u.username JOIN owner o ON u.id = o.id JOIN  gym g ON o.id = g.owner_id JOIN  gym_assign_to_trainer gat ON g.id = gat.gym_id JOIN trainer tr ON gat.trainerid = tr.id WHERE  a.username = @currentuser GROUP BY  a.username, g.id", connection);
            cmd.Parameters.AddWithValue("@currentuser", current.Username);
            string rating = Convert.ToString(cmd.ExecuteScalar());
            label3.Text = rating;

            connection.Close();

        }
         
        private void txtGymLoc_Click(object sender, EventArgs e)
        {

        }
    }
}
