using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms.SubForms
{

    public partial class Profile : Form
    {
        User currentuser;
        public Profile(User user)
        {
            InitializeComponent();
            pfpuser.Text = user.Username;
            pfptype.Text = user.Type;
            currentuser = user;
        }

        private void panelTxt_Click(object sender, EventArgs e)
        {

        }

        private void pfptype_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
           
        }
        Forms.SubForms.Profile_more SubForm;
        private void guna2GradientTileButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            if (SubForm == null || SubForm.IsDisposed)
            {
                SubForm = new Forms.SubForms.Profile_more(currentuser);
                SubForm.Show();
            }
            else
            {
                SubForm.BringToFront();
            }
        }
    }
}
