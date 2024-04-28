using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace Project_FLEXTrainer
{
    public partial class register : Form
    {
        string user;
        public register()
        {
            InitializeComponent();
           
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_click(object sender, EventArgs e)
        {
            login loginMember = new login();
            loginMember.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Text = "";
            }
            Pass.PasswordChar = '\u25CF'; // Set consistent password masking character
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pass.Text))
            {
                Pass.PasswordChar = '\0'; // Reset PasswordChar to default (no masking)
                Pass.Text = "Password";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Re-Enter Password")
            {
                textBox2.Text = "";
            }
            textBox2.PasswordChar = '\u25CF'; // Set consistent password masking character
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.PasswordChar = '\0'; // Reset PasswordChar to default (no masking)
                textBox2.Text = "Re-Enter Password";
            }
        }

        private void button2_click(object sender, EventArgs e)
        {
            if(Pass.Text != textBox2.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string connect = "Data Source=MNK\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            //query to check if username already exists
            string usercheck = "SELECT 1 FROM dbo.account WHERE Username = '"+textBox1.Text+"'";
            SqlCommand usercheckcmd = new SqlCommand(usercheck, connection);

            int flag = Convert.ToInt32(usercheckcmd.ExecuteScalar());
            if (flag != 1)
            {
                //query to save record in the table
                string query = "INSERT INTO dbo.account (dbo.account.Username, dbo.account.Password) VALUES ('"+textBox1.Text+"', '"+Pass.Text+"');";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registered Successfully!");
            }
            else
            {
                MessageBox.Show("This username is taken!");
            }
        }
    }
}
