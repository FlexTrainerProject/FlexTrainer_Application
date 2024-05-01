namespace Project_FLEXTrainer.Trainer.Forms
{
    partial class ViewPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPlans));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            btnDP = new Button();
            btnWP = new Button();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(searchBar);
            navPanel.Controls.Add(btnDP);
            navPanel.Controls.Add(btnWP);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1210, 52);
            navPanel.TabIndex = 4;
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
            searchBar.Location = new Point(999, 12);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(0, 20, 0, 0);
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search Member";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchBar.Size = new Size(259, 28);
            searchBar.TabIndex = 11;
            // 
            // btnDP
            // 
            btnDP.Dock = DockStyle.Left;
            btnDP.FlatAppearance.BorderSize = 0;
            btnDP.FlatStyle = FlatStyle.Flat;
            btnDP.Font = new Font("Segoe UI", 14.25F);
            btnDP.ForeColor = Color.White;
            btnDP.Location = new Point(284, 0);
            btnDP.Name = "btnDP";
            btnDP.Size = new Size(316, 52);
            btnDP.TabIndex = 1;
            btnDP.Text = "Diet Plans";
            btnDP.UseVisualStyleBackColor = true;
            btnDP.Click += btnDP_Click;
            // 
            // btnWP
            // 
            btnWP.BackColor = Color.FromArgb(76, 126, 122);
            btnWP.Dock = DockStyle.Left;
            btnWP.FlatAppearance.BorderSize = 0;
            btnWP.FlatStyle = FlatStyle.Flat;
            btnWP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWP.ForeColor = Color.White;
            btnWP.Location = new Point(0, 0);
            btnWP.Name = "btnWP";
            btnWP.Size = new Size(284, 52);
            btnWP.TabIndex = 0;
            btnWP.Text = "Workout Plans";
            btnWP.UseVisualStyleBackColor = false;
            btnWP.Click += btnWP_Click;
            // 
            // ViewPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 626);
            Controls.Add(navPanel);
            Name = "ViewPlans";
            Text = "ViewPlans";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Button btnDP;
        private Button btnWP;
    }
}