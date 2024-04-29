using Guna.UI2.WinForms;
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
    public partial class dietPlans : Form
    {
        public dietPlans()
        {
            InitializeComponent();
            DisplayDietPlans();
            for (int i = 0; i < 5; i++)
            {
                DietPlansView.Rows.Add(new object[]{
                    imageList1.Images[0]
                });
            }

        }



        private void panelTxt_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayDietPlans()
        {
            

            

            string connect = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            String query = "SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type' FROM diet_plan";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            DietPlansView.DataSource = dt;



            connection.Close();

        }
    }
}
