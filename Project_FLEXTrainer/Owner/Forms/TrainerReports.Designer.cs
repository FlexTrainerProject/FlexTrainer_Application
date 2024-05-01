namespace Project_FLEXTrainer.Owner.Forms
{
    partial class TrainerReports
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerReports));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            rating = new Guna.UI2.WinForms.Guna2ComboBox();
            experience = new Guna.UI2.WinForms.Guna2ComboBox();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            lblExperience = new Label();
            lblClientsManaged = new Label();
            lblrating = new Label();
            panel2 = new Panel();
            Gender = new Label();
            name = new Label();
            navPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(126, 46, 53);
            navPanel.Controls.Add(rating);
            navPanel.Controls.Add(experience);
            navPanel.Controls.Add(searchBar);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1093, 57);
            navPanel.TabIndex = 2;
            // 
            // rating
            // 
            rating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rating.BackColor = Color.Transparent;
            rating.CustomizableEdges = customizableEdges1;
            rating.DrawMode = DrawMode.OwnerDrawFixed;
            rating.DropDownStyle = ComboBoxStyle.DropDownList;
            rating.FocusedColor = Color.FromArgb(94, 148, 255);
            rating.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            rating.Font = new Font("Segoe UI", 10F);
            rating.ForeColor = Color.FromArgb(68, 88, 112);
            rating.ItemHeight = 30;
            rating.Location = new Point(738, 12);
            rating.Name = "rating";
            rating.ShadowDecoration.CustomizableEdges = customizableEdges2;
            rating.Size = new Size(164, 36);
            rating.TabIndex = 12;
            // 
            // experience
            // 
            experience.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            experience.BackColor = Color.Transparent;
            experience.CustomizableEdges = customizableEdges3;
            experience.DrawMode = DrawMode.OwnerDrawFixed;
            experience.DropDownStyle = ComboBoxStyle.DropDownList;
            experience.FocusedColor = Color.FromArgb(94, 148, 255);
            experience.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            experience.Font = new Font("Segoe UI", 10F);
            experience.ForeColor = Color.FromArgb(68, 88, 112);
            experience.ItemHeight = 30;
            experience.Location = new Point(917, 12);
            experience.Name = "experience";
            experience.ShadowDecoration.CustomizableEdges = customizableEdges4;
            experience.Size = new Size(164, 36);
            experience.TabIndex = 11;
            // 
            // searchBar
            // 
            searchBar.BorderColor = Color.White;
            searchBar.BorderRadius = 12;
            searchBar.BorderThickness = 2;
            searchBar.CustomizableEdges = customizableEdges5;
            searchBar.DefaultText = "";
            searchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.Font = new Font("Segoe UI", 9F);
            searchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.IconRight = (Image)resources.GetObject("searchBar.IconRight");
            searchBar.Location = new Point(14, 14);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(0, 20, 0, 0);
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            searchBar.Size = new Size(177, 28);
            searchBar.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Controls.Add(lblExperience);
            panel1.Controls.Add(lblClientsManaged);
            panel1.Controls.Add(lblrating);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 134);
            panel1.TabIndex = 3;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblExperience.ForeColor = Color.White;
            lblExperience.Location = new Point(283, 73);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(105, 25);
            lblExperience.TabIndex = 4;
            lblExperience.Text = "Experience";
            // 
            // lblClientsManaged
            // 
            lblClientsManaged.AutoSize = true;
            lblClientsManaged.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblClientsManaged.ForeColor = Color.White;
            lblClientsManaged.Location = new Point(522, 36);
            lblClientsManaged.Name = "lblClientsManaged";
            lblClientsManaged.Size = new Size(218, 25);
            lblClientsManaged.TabIndex = 3;
            lblClientsManaged.Text = "No. Of Clients Managed";
            // 
            // lblrating
            // 
            lblrating.AutoSize = true;
            lblrating.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblrating.ForeColor = Color.White;
            lblrating.Location = new Point(283, 36);
            lblrating.Name = "lblrating";
            lblrating.Size = new Size(68, 25);
            lblrating.TabIndex = 2;
            lblrating.Text = "Rating";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 101, 97);
            panel2.Controls.Add(Gender);
            panel2.Controls.Add(name);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 134);
            panel2.TabIndex = 1;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Gender.ForeColor = Color.White;
            Gender.Location = new Point(19, 73);
            Gender.Name = "Gender";
            Gender.Size = new Size(74, 25);
            Gender.TabIndex = 1;
            Gender.Text = "Gender";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(19, 36);
            name.Name = "name";
            name.Size = new Size(64, 25);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // TrainerReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 623);
            Controls.Add(panel1);
            Controls.Add(navPanel);
            Name = "TrainerReports";
            Text = "Trainer Reports";
            navPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Guna.UI2.WinForms.Guna2Button btnGenerateReport;
        private Guna.UI2.WinForms.Guna2ComboBox experience;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Guna.UI2.WinForms.Guna2ComboBox rating;
        private Panel panel1;
        private Label name;
        private Label lblExperience;
        private Label lblClientsManaged;
        private Label lblrating;
        private Panel panel2;
        private Label Gender;
    }
}