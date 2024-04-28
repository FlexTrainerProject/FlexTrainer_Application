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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_FLEXTrainer
{
    public partial class login : Form
    {
        string user;
        public login()
        {
            InitializeComponent();
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Text = "";
            }
            Pass.PasswordChar = '\u25CF'; // Set consistent password masking character
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pass.Text))
            {
                Pass.PasswordChar = '\0'; // Reset PasswordChar to default (no masking)
                Pass.Text = "Password";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tesxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_click(object sender, EventArgs e) //dive back in time ~~~
        {
            register regMember = new register();
            regMember.Show();
            this.Close();
        }

        private void button2_click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OLHUDAG;Initial Catalog=DB-project;Integrated Security=True;Encrypt=False");
            connection.Open();
            SqlCommand checkifuser = new SqlCommand("SELECT 1 FROM dbo.account WHERE Username = '" + textBox1.Text + "'", connection);
            int flag = Convert.ToInt32(checkifuser.ExecuteScalar());
            if (flag != 1)
            {
                MessageBox.Show("Username does not exist!");
            }
            else
            {
                SqlCommand returnpass = new SqlCommand("SELECT Password FROM dbo.account WHERE Username = '" + textBox1.Text+"'", connection);
                string passw = Convert.ToString( returnpass.ExecuteScalar());
                if (passw == Pass.Text)
                {
                    MessageBox.Show("Login Successful");

                    User currentUser = new User(textBox1.Text, passw);


                    home home = new home(currentUser);
                    home.Show();

                    this.Close();
                }
                else
                    MessageBox.Show("Incorrect Password");
            }
            connection.Close();
        }
    }
}
