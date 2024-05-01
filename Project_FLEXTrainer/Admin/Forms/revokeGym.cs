using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Admin.Forms
{
    public partial class revokeGym : Form
    {
        private Button activeButton;
        public revokeGym()
        {
            InitializeComponent();
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

        private void btnRevoked_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnAllgyms_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }
    }
}
