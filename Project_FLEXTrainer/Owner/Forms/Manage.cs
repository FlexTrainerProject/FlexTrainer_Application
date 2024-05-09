using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Owner.Forms
{
    public partial class Manage : Form
    {
        private Button activeButton;
        User currUser;
        public Manage(User user)
        {
            InitializeComponent();
            currUser = user;
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

        private void btnMember_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            SubForm.Requests SubForm = new SubForm.Requests(currUser);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
        }
    }
}
