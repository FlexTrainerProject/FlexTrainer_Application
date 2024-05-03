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
    public partial class TrainerInfo : Form
    {
        public TrainerInfo(string name, string exp,string rat)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = "Experience : " + exp;
            label3.Text = "Rating : " + rat;
        }

        private void TimingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeError_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
