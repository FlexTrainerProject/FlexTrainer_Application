﻿using System;
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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Forms.SubForms.giveFeedback SubForm = new Forms.SubForms.giveFeedback();
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
        }
    }
}
