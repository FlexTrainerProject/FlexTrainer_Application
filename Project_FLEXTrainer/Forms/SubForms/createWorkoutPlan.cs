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
    public partial class createWorkoutPlan : Form
    {
        public createWorkoutPlan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            Forms.SubForms.addExercise SubForm = new Forms.SubForms.addExercise();
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
