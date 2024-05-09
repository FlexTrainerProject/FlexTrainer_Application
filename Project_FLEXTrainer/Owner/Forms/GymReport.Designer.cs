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
            label3 = new Label();
            label2 = new Label();
            txtGymLoc = new Label();
            txtGymName = new Label();
            totalMembers = new Panel();
            label = new Label();
            totalTrainers = new Panel();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            GymInfoPanel.Controls.Add(label6);
            GymInfoPanel.Controls.Add(label7);
            GymInfoPanel.Controls.Add(label4);
            GymInfoPanel.Controls.Add(label5);
            GymInfoPanel.Controls.Add(label3);
            GymInfoPanel.Controls.Add(label2);
            GymInfoPanel.Controls.Add(txtGymLoc);
            GymInfoPanel.Controls.Add(txtGymName);
            GymInfoPanel.CustomizableEdges = customizableEdges1;
            GymInfoPanel.Location = new Point(12, 12);
            GymInfoPanel.Name = "GymInfoPanel";
            GymInfoPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GymInfoPanel.Size = new Size(727, 299);
            GymInfoPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(230, 124);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 3;
            label3.Text = "nunu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(230, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 2;
            label2.Text = "yayay";
            // 
            // txtGymLoc
            // 
            txtGymLoc.AutoSize = true;
            txtGymLoc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGymLoc.ForeColor = Color.White;
            txtGymLoc.Location = new Point(51, 124);
            txtGymLoc.Name = "txtGymLoc";
            txtGymLoc.Size = new Size(126, 30);
            txtGymLoc.TabIndex = 1;
            txtGymLoc.Text = "Gym Rating";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(230, 181);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 5;
            label4.Text = "nunu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 181);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 4;
            label5.Text = "Gym Location:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(580, 124);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 7;
            label6.Text = "nunu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(401, 124);
            label7.Name = "label7";
            label7.Size = new Size(151, 30);
            label7.TabIndex = 6;
            label7.Text = "Gym Location:";
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
            Text = "Gym Report";
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
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
    }
}