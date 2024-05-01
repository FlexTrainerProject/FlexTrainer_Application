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
    public partial class workoutPlans : Form
    {
        public workoutPlans()
        {
            InitializeComponent();

            DisplayWorkoutPlan();
        }

        private void panelTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateWP_Click(object sender, EventArgs e)
        {
            Forms.SubForms.createWorkoutPlan SubForm = new Forms.SubForms.createWorkoutPlan();
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
        }

        private void DisplayWorkoutPlan()
        {
            string connect = "Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False";
            //string connect = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            String query = "Select* from workout_plan";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            WorkOut.DataSource = dt;



            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
