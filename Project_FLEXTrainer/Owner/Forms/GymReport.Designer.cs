namespace Project_FLEXTrainer.Owner.Forms
{
    partial class GymReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            GymInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            txtGymLoc = new Label();
            txtGymName = new Label();
            totalMembers = new Panel();
            label = new Label();
            totalTrainers = new Panel();
            label1 = new Label();
            GymInfoPanel.SuspendLayout();
            totalMembers.SuspendLayout();
            totalTrainers.SuspendLayout();
            SuspendLayout();
            // 
            // GymInfoPanel
            // 
            GymInfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GymInfoPanel.AutoRoundedCorners = true;
            GymInfoPanel.BackColor = Color.FromArgb(26, 46, 53);
            GymInfoPanel.BorderRadius = 148;
            GymInfoPanel.BorderThickness = 5;
            GymInfoPanel.Controls.Add(txtGymLoc);
            GymInfoPanel.Controls.Add(txtGymName);
            GymInfoPanel.CustomizableEdges = customizableEdges1;
            GymInfoPanel.Location = new Point(12, 12);
            GymInfoPanel.Name = "GymInfoPanel";
            GymInfoPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GymInfoPanel.Size = new Size(727, 299);
            GymInfoPanel.TabIndex = 0;
            // 
            // txtGymLoc
            // 
            txtGymLoc.AutoSize = true;
            txtGymLoc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGymLoc.ForeColor = Color.White;
            txtGymLoc.Location = new Point(51, 124);
            txtGymLoc.Name = "txtGymLoc";
            txtGymLoc.Size = new Size(151, 30);
            txtGymLoc.TabIndex = 1;
            txtGymLoc.Text = "Gym Location:";
            // 
            // txtGymName
            // 
            txtGymName.AutoSize = true;
            txtGymName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGymName.ForeColor = Color.White;
            txtGymName.Location = new Point(51, 57);
            txtGymName.Name = "txtGymName";
            txtGymName.Size = new Size(126, 30);
            txtGymName.TabIndex = 0;
            txtGymName.Text = "Gym Name:";
            // 
            // totalMembers
            // 
            totalMembers.BackColor = Color.FromArgb(26, 46, 53);
            totalMembers.Controls.Add(label);
            totalMembers.Location = new Point(12, 338);
            totalMembers.Name = "totalMembers";
            totalMembers.Size = new Size(334, 273);
            totalMembers.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(25, 29);
            label.Name = "label";
            label.Size = new Size(115, 60);
            label.TabIndex = 1;
            label.Text = "TOTAL \r\nMEMBERS:";
            // 
            // totalTrainers
            // 
            totalTrainers.BackColor = Color.FromArgb(26, 46, 53);
            totalTrainers.Controls.Add(label1);
            totalTrainers.Location = new Point(378, 338);
            totalTrainers.Name = "totalTrainers";
            totalTrainers.Size = new Size(361, 273);
            totalTrainers.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(114, 60);
            label1.TabIndex = 2;
            label1.Text = "TOTAL \r\nTRAINERS:";
            // 
            // GymReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1093, 623);
            Controls.Add(totalTrainers);
            Controls.Add(totalMembers);
            Controls.Add(GymInfoPanel);
            Name = "GymReport";
            Text = "GymReport";
            GymInfoPanel.ResumeLayout(false);
            GymInfoPanel.PerformLayout();
            totalMembers.ResumeLayout(false);
            totalMembers.PerformLayout();
            totalTrainers.ResumeLayout(false);
            totalTrainers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel GymInfoPanel;
        private Label txtGymLoc;
        private Label txtGymName;
        private Panel totalMembers;
        private Panel totalTrainers;
        private Label label;
        private Label label1;
    }
}