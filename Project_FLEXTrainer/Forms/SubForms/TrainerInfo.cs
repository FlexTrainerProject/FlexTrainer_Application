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
        public TrainerInfo()
        {
            InitializeComponent();
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
