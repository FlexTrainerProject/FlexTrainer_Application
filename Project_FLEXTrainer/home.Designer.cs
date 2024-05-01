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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            UserNamePanel = new Panel();
            btnpfp = new Guna.UI2.WinForms.Guna2Button();
            usr_type = new Label();
            lblUsername = new Label();
            pgTitle = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            btnSettings = new Button();
            btnMyPlans = new Button();
            btnBookSessions = new Button();
            btnDietPlans = new Button();
            btnWorkoutPlans = new Button();
            desktopPanel = new Panel();
            btnhome = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            UserNamePanel.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(170, 52, 60);
            panel2.Controls.Add(btnhome);
            panel2.Controls.Add(UserNamePanel);
            panel2.Controls.Add(pgTitle);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 78);
            panel2.TabIndex = 0;
            // 
            // UserNamePanel
            // 
            UserNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UserNamePanel.BackColor = Color.FromArgb(50, 72, 76);
            UserNamePanel.Controls.Add(btnpfp);
            UserNamePanel.Controls.Add(usr_type);
            UserNamePanel.Controls.Add(lblUsername);
            UserNamePanel.Location = new Point(760, 0);
            UserNamePanel.Name = "UserNamePanel";
            UserNamePanel.Size = new Size(279, 89);
            UserNamePanel.TabIndex = 9;
            // 
            // btnpfp
            // 
            btnpfp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnpfp.CustomizableEdges = customizableEdges5;
            btnpfp.DisabledState.BorderColor = Color.DarkGray;
            btnpfp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnpfp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnpfp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnpfp.FillColor = Color.FromArgb(50, 72, 76);
            btnpfp.Font = new Font("Segoe UI", 9F);
            btnpfp.ForeColor = Color.White;
            btnpfp.Image = (Image)resources.GetObject("btnpfp.Image");
            btnpfp.ImageSize = new Size(50, 50);
            btnpfp.Location = new Point(3, 0);
            btnpfp.Name = "btnpfp";
            btnpfp.Padding = new Padding(5, 0, 5, 5);
            btnpfp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnpfp.Size = new Size(73, 80);
            btnpfp.TabIndex = 3;
            btnpfp.Click += btnpfp_Click;
            // 
            // usr_type
            // 
            usr_type.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usr_type.AutoSize = true;
            usr_type.ForeColor = Color.White;
            usr_type.Location = new Point(82, 45);
            usr_type.Name = "usr_type";
            usr_type.Size = new Size(167, 15);
            usr_type.TabIndex = 2;
            usr_type.Text = "usr_type (member/admin/etc)";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(76, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(0, 15, 0, 0);
            lblUsername.Size = new Size(123, 45);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "USERNAME";
            // 
            // pgTitle
            // 
            pgTitle.AutoSize = true;
            pgTitle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -2);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(140, 62);
            pgTitle.TabIndex = 8;
            pgTitle.Text = "HOME";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 72, 76);
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1036, -16);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 30, 10, 0);
            label1.Size = new Size(123, 105);
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
            btnSettings.Location = new Point(0, 478);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.Size = new Size(253, 70);
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
            btnMyPlans.Location = new Point(0, 210);
            btnMyPlans.Name = "btnMyPlans";
            btnMyPlans.Padding = new Padding(15, 0, 0, 0);
            btnMyPlans.Size = new Size(253, 70);
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
            btnBookSessions.Location = new Point(0, 140);
            btnBookSessions.Name = "btnBookSessions";
            btnBookSessions.Padding = new Padding(12, 0, 0, 0);
            btnBookSessions.Size = new Size(253, 70);
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
            btnDietPlans.Location = new Point(0, 70);
            btnDietPlans.Name = "btnDietPlans";
            btnDietPlans.Padding = new Padding(15, 0, 0, 0);
            btnDietPlans.Size = new Size(253, 70);
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
            btnWorkoutPlans.Size = new Size(253, 70);
            btnWorkoutPlans.TabIndex = 8;
            btnWorkoutPlans.Text = "  Workout Plans";
            btnWorkoutPlans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWorkoutPlans.UseVisualStyleBackColor = false;
            btnWorkoutPlans.Click += btnWorkoutPlans_Click;
            // 
            // desktopPanel
            // 
            desktopPanel.BackColor = Color.Gainsboro;
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(253, 78);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Size = new Size(906, 548);
            desktopPanel.TabIndex = 2;
            // 
            // btnhome
            // 
            btnhome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnhome.CustomizableEdges = customizableEdges7;
            btnhome.DisabledState.BorderColor = Color.DarkGray;
            btnhome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnhome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnhome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnhome.FillColor = Color.Empty;
            btnhome.Font = new Font("Segoe UI", 9F);
            btnhome.ForeColor = Color.White;
            btnhome.Image = (Image)resources.GetObject("btnhome.Image");
            btnhome.ImageSize = new Size(50, 50);
            btnhome.Location = new Point(692, 0);
            btnhome.Name = "btnhome";
            btnhome.Padding = new Padding(5, 0, 5, 5);
            btnhome.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnhome.Size = new Size(75, 80);
            btnhome.TabIndex = 4;
            btnhome.Click += btnhome_Click;
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
            UserNamePanel.ResumeLayout(false);
            UserNamePanel.PerformLayout();
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
        private Panel UserNamePanel;
        private Label lblUsername;
        private Label usr_type;
        private Guna.UI2.WinForms.Guna2Button btnpfp;
        private Guna.UI2.WinForms.Guna2Button btnhome;
    }
}