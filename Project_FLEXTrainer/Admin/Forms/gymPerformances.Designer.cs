namespace Project_FLEXTrainer.Admin.Forms
{
    partial class gymPerformances
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
            pgTitle = new Label();
            panelContainer = new Panel();
            panelTemplate = new Panel();
            txtLoc = new Label();
            panel1 = new Panel();
            name = new Label();
            totalMember = new Label();
            navPanel.SuspendLayout();
            panelContainer.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(pgTitle);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1312, 52);
            navPanel.TabIndex = 2;
            // 
            // pgTitle
            // 
            pgTitle.Font = new Font("Microsoft Sans Serif", 20.75F);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -9);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(389, 61);
            pgTitle.TabIndex = 13;
            pgTitle.Text = "Gyms Performance Metrics";
            pgTitle.Click += pgTitle_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1312, 609);
            panelContainer.TabIndex = 3;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(25, 42, 40);
            panelTemplate.Controls.Add(txtLoc);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(name);
            panelTemplate.Controls.Add(totalMember);
            panelTemplate.Location = new Point(72, 24);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(1106, 126);
            panelTemplate.TabIndex = 9;
            // 
            // txtLoc
            // 
            txtLoc.AutoSize = true;
            txtLoc.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            txtLoc.ForeColor = Color.White;
            txtLoc.Location = new Point(120, 67);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(107, 32);
            txtLoc.TabIndex = 7;
            txtLoc.Text = "Location";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 126);
            panel1.TabIndex = 6;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(120, 26);
            name.Name = "name";
            name.Size = new Size(79, 32);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // totalMember
            // 
            totalMember.AutoSize = true;
            totalMember.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            totalMember.ForeColor = Color.White;
            totalMember.Location = new Point(615, 43);
            totalMember.Name = "totalMember";
            totalMember.Size = new Size(176, 32);
            totalMember.TabIndex = 2;
            totalMember.Text = "Total Members";
            // 
            // gymPerformances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1312, 661);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "gymPerformances";
            Text = "Gym Perfomances";
            navPanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Label pgTitle;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Label label1;
        private Label totalTrainers;
        private Label txtLoc;
        private Panel panel1;
        private Label name;
        private Label totalMember;
    }
}