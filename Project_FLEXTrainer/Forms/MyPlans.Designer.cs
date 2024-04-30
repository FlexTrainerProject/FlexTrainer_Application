namespace Project_FLEXTrainer.Forms
{
    partial class MyPlans
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
            navPanel = new Panel();
            createdbyothers = new Button();
            createdbyme = new Button();
            allplans = new Button();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(createdbyothers);
            navPanel.Controls.Add(createdbyme);
            navPanel.Controls.Add(allplans);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1093, 52);
            navPanel.TabIndex = 0;
            // 
            // createdbyothers
            // 
            createdbyothers.Dock = DockStyle.Left;
            createdbyothers.FlatAppearance.BorderSize = 0;
            createdbyothers.FlatStyle = FlatStyle.Flat;
            createdbyothers.Font = new Font("Segoe UI", 14.25F);
            createdbyothers.ForeColor = Color.White;
            createdbyothers.Location = new Point(434, 0);
            createdbyothers.Name = "createdbyothers";
            createdbyothers.Size = new Size(217, 52);
            createdbyothers.TabIndex = 2;
            createdbyothers.Text = "CREATED BY OTHERS";
            createdbyothers.UseVisualStyleBackColor = true;
            createdbyothers.Click += createdbyothers_Click_1;
            // 
            // createdbyme
            // 
            createdbyme.Dock = DockStyle.Left;
            createdbyme.FlatAppearance.BorderSize = 0;
            createdbyme.FlatStyle = FlatStyle.Flat;
            createdbyme.Font = new Font("Segoe UI", 14.25F);
            createdbyme.ForeColor = Color.White;
            createdbyme.Location = new Point(217, 0);
            createdbyme.Name = "createdbyme";
            createdbyme.Size = new Size(217, 52);
            createdbyme.TabIndex = 1;
            createdbyme.Text = "CREATED BY ME";
            createdbyme.UseVisualStyleBackColor = true;
            createdbyme.Click += createdbyme_Click;
            // 
            // allplans
            // 
            allplans.BackColor = Color.FromArgb(76, 126, 122);
            allplans.Dock = DockStyle.Left;
            allplans.FlatAppearance.BorderSize = 0;
            allplans.FlatStyle = FlatStyle.Flat;
            allplans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allplans.ForeColor = Color.White;
            allplans.Location = new Point(0, 0);
            allplans.Name = "allplans";
            allplans.Size = new Size(217, 52);
            allplans.TabIndex = 0;
            allplans.Text = "ALL PLANS";
            allplans.UseVisualStyleBackColor = false;
            allplans.Click += allplans_Click;
            // 
            // MyPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1093, 623);
            Controls.Add(navPanel);
            Name = "MyPlans";
            Text = "MyPlans";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button allplans;
        private Button createdbyme;
        private Button createdbyothers;
    }
}