namespace Project_FLEXTrainer
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            panel2 = new Panel();
            pgTitle = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            btnSettings = new Button();
            btnMyPlans = new Button();
            btnBookSessions = new Button();
            btnDietPlans = new Button();
            btnWorkoutPlans = new Button();
            desktopPanel = new Panel();
            panel2.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(170, 52, 60);
            panel2.Controls.Add(pgTitle);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 78);
            panel2.TabIndex = 0;
            // 
            // pgTitle
            // 
            pgTitle.AutoSize = true;
            pgTitle.Dock = DockStyle.Left;
            pgTitle.Font = new Font("Retroica", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, 0);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(20, 23, 0, 0);
            pgTitle.Size = new Size(148, 61);
            pgTitle.TabIndex = 8;
            pgTitle.Text = "HOME";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 72, 76);
            label1.Font = new Font("Herborn", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1048, -6);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 30, 10, 0);
            label1.Size = new Size(111, 84);
            label1.TabIndex = 7;
            label1.Text = "FLEX \r\nTRAINER\r\n\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(50, 72, 76);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnMyPlans);
            panelMenu.Controls.Add(btnBookSessions);
            panelMenu.Controls.Add(btnDietPlans);
            panelMenu.Controls.Add(btnWorkoutPlans);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 78);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(253, 548);
            panelMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 498);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.Size = new Size(253, 50);
            btnSettings.TabIndex = 12;
            btnSettings.Text = "  Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += settings_Click;
            // 
            // btnMyPlans
            // 
            btnMyPlans.BackColor = Color.FromArgb(50, 72, 76);
            btnMyPlans.Dock = DockStyle.Top;
            btnMyPlans.FlatAppearance.BorderSize = 0;
            btnMyPlans.FlatStyle = FlatStyle.Flat;
            btnMyPlans.Font = new Font("Ebrima", 12.25F);
            btnMyPlans.ForeColor = Color.Gainsboro;
            btnMyPlans.Image = (Image)resources.GetObject("btnMyPlans.Image");
            btnMyPlans.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyPlans.Location = new Point(0, 150);
            btnMyPlans.Name = "btnMyPlans";
            btnMyPlans.Padding = new Padding(15, 0, 0, 0);
            btnMyPlans.Size = new Size(253, 50);
            btnMyPlans.TabIndex = 11;
            btnMyPlans.Text = "  My Plans";
            btnMyPlans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyPlans.UseVisualStyleBackColor = false;
            btnMyPlans.Click += btnMyPlans_Click;
            // 
            // btnBookSessions
            // 
            btnBookSessions.BackColor = Color.FromArgb(50, 72, 76);
            btnBookSessions.Dock = DockStyle.Top;
            btnBookSessions.FlatAppearance.BorderSize = 0;
            btnBookSessions.FlatStyle = FlatStyle.Flat;
            btnBookSessions.Font = new Font("Ebrima", 12.25F);
            btnBookSessions.ForeColor = Color.Gainsboro;
            btnBookSessions.Image = (Image)resources.GetObject("btnBookSessions.Image");
            btnBookSessions.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookSessions.Location = new Point(0, 100);
            btnBookSessions.Name = "btnBookSessions";
            btnBookSessions.Padding = new Padding(12, 0, 0, 0);
            btnBookSessions.Size = new Size(253, 50);
            btnBookSessions.TabIndex = 10;
            btnBookSessions.Text = "  Book Session";
            btnBookSessions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBookSessions.UseVisualStyleBackColor = false;
            btnBookSessions.Click += btnBookSession_Click;
            // 
            // btnDietPlans
            // 
            btnDietPlans.BackColor = Color.FromArgb(50, 72, 76);
            btnDietPlans.Dock = DockStyle.Top;
            btnDietPlans.FlatAppearance.BorderSize = 0;
            btnDietPlans.FlatStyle = FlatStyle.Flat;
            btnDietPlans.Font = new Font("Ebrima", 12.25F);
            btnDietPlans.ForeColor = Color.Gainsboro;
            btnDietPlans.Image = (Image)resources.GetObject("btnDietPlans.Image");
            btnDietPlans.ImageAlign = ContentAlignment.MiddleLeft;
            btnDietPlans.Location = new Point(0, 50);
            btnDietPlans.Name = "btnDietPlans";
            btnDietPlans.Padding = new Padding(15, 0, 0, 0);
            btnDietPlans.Size = new Size(253, 50);
            btnDietPlans.TabIndex = 9;
            btnDietPlans.Text = "   Diet Plans";
            btnDietPlans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDietPlans.UseVisualStyleBackColor = false;
            btnDietPlans.Click += btnDietPlans_Click;
            // 
            // btnWorkoutPlans
            // 
            btnWorkoutPlans.BackColor = Color.FromArgb(50, 72, 76);
            btnWorkoutPlans.Dock = DockStyle.Top;
            btnWorkoutPlans.FlatAppearance.BorderSize = 0;
            btnWorkoutPlans.FlatStyle = FlatStyle.Flat;
            btnWorkoutPlans.Font = new Font("Ebrima", 12.25F);
            btnWorkoutPlans.ForeColor = Color.Gainsboro;
            btnWorkoutPlans.Image = (Image)resources.GetObject("btnWorkoutPlans.Image");
            btnWorkoutPlans.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkoutPlans.Location = new Point(0, 0);
            btnWorkoutPlans.Name = "btnWorkoutPlans";
            btnWorkoutPlans.Padding = new Padding(15, 0, 0, 0);
            btnWorkoutPlans.Size = new Size(253, 50);
            btnWorkoutPlans.TabIndex = 8;
            btnWorkoutPlans.Text = "  Workout Plans";
            btnWorkoutPlans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWorkoutPlans.UseVisualStyleBackColor = false;
            btnWorkoutPlans.Click += btnWorkoutPlans_Click;
            // 
            // desktopPanel
            // 
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(253, 78);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Size = new Size(906, 548);
            desktopPanel.TabIndex = 2;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 626);
            Controls.Add(desktopPanel);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            Name = "home";
            Text = "mainHome";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panelMenu;
        private Button btnMyPlans;
        private Button btnBookSessions;
        private Button btnDietPlans;
        private Button btnWorkoutPlans;
        private Button btnSettings;
        private Label label1;
        private Label pgTitle;
        private Panel desktopPanel;
    }
}