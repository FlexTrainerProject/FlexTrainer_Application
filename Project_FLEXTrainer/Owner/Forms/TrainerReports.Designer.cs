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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerReports));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            rating = new Guna.UI2.WinForms.Guna2ComboBox();
            experience = new Guna.UI2.WinForms.Guna2ComboBox();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            panelContainer = new Panel();
            panelTemplate = new Panel();
            panel3 = new Panel();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            navPanel.SuspendLayout();
            panelContainer.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
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
            rating.CustomizableEdges = customizableEdges13;
            rating.DrawMode = DrawMode.OwnerDrawFixed;
            rating.DropDownStyle = ComboBoxStyle.DropDownList;
            rating.FocusedColor = Color.FromArgb(94, 148, 255);
            rating.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            rating.Font = new Font("Segoe UI", 10F);
            rating.ForeColor = Color.FromArgb(68, 88, 112);
            rating.ItemHeight = 30;
            rating.Location = new Point(738, 12);
            rating.Name = "rating";
            rating.ShadowDecoration.CustomizableEdges = customizableEdges14;
            rating.Size = new Size(164, 36);
            rating.TabIndex = 12;
            // 
            // experience
            // 
            experience.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            experience.BackColor = Color.Transparent;
            experience.CustomizableEdges = customizableEdges15;
            experience.DrawMode = DrawMode.OwnerDrawFixed;
            experience.DropDownStyle = ComboBoxStyle.DropDownList;
            experience.FocusedColor = Color.FromArgb(94, 148, 255);
            experience.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            experience.Font = new Font("Segoe UI", 10F);
            experience.ForeColor = Color.FromArgb(68, 88, 112);
            experience.ItemHeight = 30;
            experience.Location = new Point(917, 12);
            experience.Name = "experience";
            experience.ShadowDecoration.CustomizableEdges = customizableEdges16;
            experience.Size = new Size(164, 36);
            experience.TabIndex = 11;
            // 
            // searchBar
            // 
            searchBar.BorderColor = Color.White;
            searchBar.BorderRadius = 12;
            searchBar.BorderThickness = 2;
            searchBar.CustomizableEdges = customizableEdges17;
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
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            searchBar.Size = new Size(177, 28);
            searchBar.TabIndex = 10;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 57);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1093, 566);
            panelContainer.TabIndex = 11;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(42, 101, 97);
            panelTemplate.Controls.Add(panel3);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(126, 41);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 42, 40);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(96, 78);
            panel3.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(244, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            experienceLabel.ForeColor = Color.White;
            experienceLabel.Location = new Point(562, 11);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new Size(90, 21);
            experienceLabel.TabIndex = 3;
            experienceLabel.Text = "Experience";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(244, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // TrainerReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 623);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "TrainerReports";
            Text = "Trainer Reports";
            Load += TrainerReports_Load;
            navPanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
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
        private Panel panelContainer;
        private Panel panelTemplate;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private Panel panel3;
        private Button button2;
        private ImageList imageList1;
        private Panel panel4;
        private Panel panel5;
    }
}