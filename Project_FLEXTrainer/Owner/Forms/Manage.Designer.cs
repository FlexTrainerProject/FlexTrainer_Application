namespace Project_FLEXTrainer.Owner.Forms
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            btnTrainer = new Button();
            btnMember = new Button();
            panel1 = new Panel();
            btnRemove = new Button();
            label1 = new Label();
            name = new Label();
            panel2 = new Panel();
            btnRemoveTrainer = new Button();
            label2 = new Label();
            label3 = new Label();
            btnRequests = new Button();
            navPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(searchBar);
            navPanel.Controls.Add(btnTrainer);
            navPanel.Controls.Add(btnMember);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1270, 52);
            navPanel.TabIndex = 2;
            // 
            // searchBar
            // 
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
            searchBar.Location = new Point(1036, 12);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(0, 20, 0, 0);
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchBar.Size = new Size(222, 28);
            searchBar.TabIndex = 11;
            // 
            // btnTrainer
            // 
            btnTrainer.Dock = DockStyle.Left;
            btnTrainer.FlatAppearance.BorderSize = 0;
            btnTrainer.FlatStyle = FlatStyle.Flat;
            btnTrainer.Font = new Font("Segoe UI", 14.25F);
            btnTrainer.ForeColor = Color.White;
            btnTrainer.Location = new Point(284, 0);
            btnTrainer.Name = "btnTrainer";
            btnTrainer.Size = new Size(316, 52);
            btnTrainer.TabIndex = 1;
            btnTrainer.Text = "TRAINERS";
            btnTrainer.UseVisualStyleBackColor = true;
            btnTrainer.Click += btnTrainer_Click;
            // 
            // btnMember
            // 
            btnMember.BackColor = Color.FromArgb(76, 126, 122);
            btnMember.Dock = DockStyle.Left;
            btnMember.FlatAppearance.BorderSize = 0;
            btnMember.FlatStyle = FlatStyle.Flat;
            btnMember.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMember.ForeColor = Color.White;
            btnMember.Location = new Point(0, 0);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(284, 52);
            btnMember.TabIndex = 0;
            btnMember.Text = "MEMBERS";
            btnMember.UseVisualStyleBackColor = false;
            btnMember.Click += btnMember_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 46, 53);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(name);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 136);
            panel1.TabIndex = 3;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(76, 126, 122);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.WhiteSmoke;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(568, 45);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(141, 43);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 23);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 2;
            label1.Text = "Membership Status";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(35, 23);
            name.Name = "name";
            name.Size = new Size(64, 25);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(126, 46, 53);
            panel2.Controls.Add(btnRemoveTrainer);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 136);
            panel2.TabIndex = 4;
            // 
            // btnRemoveTrainer
            // 
            btnRemoveTrainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveTrainer.BackColor = Color.FromArgb(76, 126, 122);
            btnRemoveTrainer.FlatAppearance.BorderSize = 0;
            btnRemoveTrainer.FlatStyle = FlatStyle.Flat;
            btnRemoveTrainer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTrainer.ForeColor = Color.WhiteSmoke;
            btnRemoveTrainer.Image = (Image)resources.GetObject("btnRemoveTrainer.Image");
            btnRemoveTrainer.Location = new Point(568, 43);
            btnRemoveTrainer.Name = "btnRemoveTrainer";
            btnRemoveTrainer.Size = new Size(141, 43);
            btnRemoveTrainer.TabIndex = 4;
            btnRemoveTrainer.Text = "REMOVE";
            btnRemoveTrainer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveTrainer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(304, 23);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 2;
            label2.Text = "Trainer Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 23);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // btnRequests
            // 
            btnRequests.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRequests.BackColor = Color.FromArgb(126, 46, 53);
            btnRequests.FlatAppearance.BorderSize = 0;
            btnRequests.FlatStyle = FlatStyle.Flat;
            btnRequests.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequests.ForeColor = Color.White;
            btnRequests.Image = (Image)resources.GetObject("btnRequests.Image");
            btnRequests.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequests.Location = new Point(958, 78);
            btnRequests.Name = "btnRequests";
            btnRequests.Padding = new Padding(10, 0, 0, 0);
            btnRequests.Size = new Size(288, 70);
            btnRequests.TabIndex = 5;
            btnRequests.Text = "   REQUESTS";
            btnRequests.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequests.UseVisualStyleBackColor = false;
            btnRequests.Click += btnRequests_Click;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1270, 675);
            Controls.Add(btnRequests);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(navPanel);
            Name = "Manage";
            Text = "Gym Management";
            navPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button btnTrainer;
        private Button btnMember;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Panel panel1;
        private Label label1;
        private Label name;
        private Button btnRemove;
        private Panel panel2;
        private Button btnRemoveTrainer;
        private Label label2;
        private Label label3;
        private Button btnRequests;
    }
}