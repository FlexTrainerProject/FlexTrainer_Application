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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_FLEXTrainer.Forms.SubForms
{
    public partial class addMeal : Form
    {
        private createDietPlancs mainForm;
        public addMeal(createDietPlancs mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="" || txtAllergens.Text=="" || txtNutritionalvAl.Text=="")
            {
                MessageBox.Show("Missing Info");
                return;
            }
            Meal meal = new Meal();
            meal.Name=txtName.Text;
            meal.Allergens = txtAllergens.Text;
            meal.Nutrition = txtNutritionalvAl.Text;

            mainForm.AddMeal(meal);

            MessageBox.Show("Meal Added to Plan");
            txtName.Text = "";
            txtAllergens.Text = "";
            txtNutritionalvAl.Text = "";

        }
    }
}
