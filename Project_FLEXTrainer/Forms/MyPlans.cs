using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer.Forms
{
    public partial class MyPlans : Form
    {
        private Button activeButton;
        public MyPlans()
        {
            InitializeComponent();
        }

        private void btncreatedbyme_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
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

        private void createdbyme_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void createdbyothers_Click_1(object sender, EventArgs e)
        {
            activateBtn(sender);
            //
        }

        private void allplans_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }
    }
}
