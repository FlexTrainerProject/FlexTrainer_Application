using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer
{
    public partial class home : Form
    {
        private Button activeButton;
        private Form activeForm;
        public home()
        {
            InitializeComponent();
            Form childForm = new Forms.mainHomecs();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

  

        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.workoutPlans(), sender);

        }

        private void btnDietPlans_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.dietPlans(), sender);
        }

        private void btnBookSession_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.bookSession(), sender);
        }

        private void btnMyPlans_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }
        private void settings_Click(object sender, EventArgs e)
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
                    Color color = ColorTranslator.FromHtml("#FF4F5A");
                    activeButton = (Button)sender;
                    activeButton.BackColor = color;
                    activeButton.ForeColor = Color.White;
                    activeButton.Font = new Font("Ebrima", 13.25F, FontStyle.Bold);


                }
            }
        }

        private void disableBtn()
        {
            foreach (Control prevbtn in panelMenu.Controls)
            {
                if (prevbtn.GetType() == typeof(Button))
                {
                    prevbtn.BackColor = Color.FromArgb(50, 72, 76);
                    prevbtn.ForeColor = Color.Gainsboro;
                    prevbtn.Font = new Font("Ebrima", 12.25F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activateBtn(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pgTitle.Text = childForm.Text;
        }


    }
}
