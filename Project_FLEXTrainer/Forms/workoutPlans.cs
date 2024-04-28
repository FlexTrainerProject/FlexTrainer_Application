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
    public partial class workoutPlans : Form
    {
        public workoutPlans()
        {
            InitializeComponent();
        }

        private void panelTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateWP_Click(object sender, EventArgs e)
        {
            Forms.SubForms.createWorkoutPlan SubForm = new Forms.SubForms.createWorkoutPlan();
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.StartPosition = FormStartPosition.CenterScreen;

            SubForm.Show(); // Show the form as a separate window
        }
    }
}
