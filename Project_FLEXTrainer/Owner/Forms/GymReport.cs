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
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OLHUDAG;Initial Catalog=Flex_trainer;Integrated Security=True;Encrypt=False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select gym.name from gym INNER JOIN owner on gym.owner_id =owner.id INNER JOIN userr on userr.id = owner_id where userr.username = '" + current.Username + "'",connection);
            string name = Convert.ToString(cmd.ExecuteScalar());
            cmd = new SqlCommand("Select gym.location from gym INNER JOIN owner on gym.owner_id =owner.id INNER JOIN userr on userr.id = owner_id where userr.username = '" + current.Username + "'",connection);
            string location = Convert.ToString(cmd.ExecuteScalar());

            label2.Text = name;
            label3.Text = location;

            connection.Close();

        }
    }
}
