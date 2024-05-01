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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gymPerformances));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            pgTitle = new Label();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(pgTitle);
            navPanel.Controls.Add(searchBar);
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
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBar.BorderColor = Color.White;
            searchBar.BorderRadius = 12;
            searchBar.BorderThickness = 2;
            searchBar.CustomizableEdges = customizableEdges1;
            searchBar.DefaultText = "";
            searchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.Font = new Font("Segoe UI", 9F);
            searchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.IconRight = (Image)resources.GetObject("searchBar.IconRight");
            searchBar.Location = new Point(1072, 12);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(0, 20, 0, 0);
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search Gym";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchBar.Size = new Size(228, 28);
            searchBar.TabIndex = 12;
            // 
            // gymPerformances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1312, 661);
            Controls.Add(navPanel);
            Name = "gymPerformances";
            Text = "Gym Perfomances";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Label pgTitle;
    }
}