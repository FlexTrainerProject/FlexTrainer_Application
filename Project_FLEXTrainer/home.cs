﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FLEXTrainer
{
    public partial class home : Form
    {
        private bool pfpShow = false;
        private Button activeButton;
        private Form activeForm;
        User currentuser;
        public home(User user)
        {
            InitializeComponent();
            Form childForm = new Forms.mainHomecs(user);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            currentuser = user;
            lblUsername.Text = user.Username;
            usr_type.Text = user.Type;
        }



        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.workoutPlans(), sender);

        }

        private void btnDietPlans_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.dietPlans(), sender);
        }

        private void btnBookSession_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.bookSession(), sender);
        }

        private void btnMyPlans_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.MyPlans(), sender);
        }
        private void settings_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                activateBtn(sender);
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            if ((Button)sender != (Button)activeButton)
                OpenChildForm(new Forms.Membership(), sender);
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
            //tabPic.Image. = ;
        }
        private void SubForm_Deactivate(object sender, EventArgs e)
        {
            if (!SubForm.ClientRectangle.Contains(SubForm.PointToClient(Control.MousePosition)))
            {
                // If the mouse is not within the bounds of the sub form, close it
                SubForm.Close();
                pfpShow = false;
            }
        }
        Forms.SubForms.Profile SubForm;
        private void btnpfp_Click(object sender, EventArgs e)
        {
            if (!pfpShow)
            {
                if (SubForm == null || SubForm.IsDisposed)
                {
                    SubForm = new Forms.SubForms.Profile(currentuser);
                    SubForm.FormBorderStyle = FormBorderStyle.None;
                    SubForm.StartPosition = FormStartPosition.Manual;

                    // Calculate the position of the sub form relative to the button
                    Point p = btnpfp.PointToScreen(Point.Empty);
                    SubForm.Location = new Point(p.X, p.Y + btnpfp.Height);
                    //SubForm.Deactivate += SubForm_Deactivate;
                    /// SubForm.MouseDown.
                    SubForm.Show();
                }
                else
                {
                    SubForm.BringToFront();
                }
                pfpShow = true;
            }
            else
            {
                SubForm.Close();
                pfpShow = false;
            }

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Form childForm = new Forms.mainHomecs(currentuser);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
    }
}
