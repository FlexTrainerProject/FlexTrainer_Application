using Project_FLEXTrainer.Essentials;
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
    public partial class createDietPlancs : Form
    {
        List<Essentials.Meal> MealsAdded = new List<Essentials.Meal>();
        public createDietPlancs()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Forms.SubForms.addMeal SubForm = new Forms.SubForms.addMeal(this);
            SubForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            SubForm.Dock = DockStyle.Fill;
            SubForm.TopLevel = false;
            this.mealPanel.Controls.Add(SubForm);
            this.mealPanel.Tag = SubForm;
            SubForm.BringToFront();
            SubForm.Show();
        }
        public void AddMeal(Meal meal)
        {
            MealsAdded.Add(meal);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
