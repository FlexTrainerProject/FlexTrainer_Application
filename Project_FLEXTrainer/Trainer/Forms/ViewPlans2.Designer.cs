﻿namespace Project_FLEXTrainer.Trainer.Forms
{
    partial class ViewPlans2
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPlans2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            btnDP = new Button();
            btnWP = new Button();
            panelContainer = new Panel();
            panelTemplate = new Panel();
            hiddenID = new Label();
            panel1 = new Panel();
            button2 = new Button();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            imageList1 = new ImageList(components);
            navPanel.SuspendLayout();
            panelContainer.SuspendLayout();
            panelTemplate.SuspendLayout();
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
            navPanel.Size = new Size(1156, 52);
            navPanel.TabIndex = 5;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBar.BorderColor = Color.White;
            searchBar.BorderRadius = 12;
            searchBar.BorderThickness = 2;
            searchBar.CustomizableEdges = customizableEdges3;
            searchBar.DefaultText = "";
            searchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.Font = new Font("Segoe UI", 9F);
            searchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.IconRight = (Image)resources.GetObject("searchBar.IconRight");
            searchBar.Location = new Point(1955, 12);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(0, 20, 0, 0);
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search Member";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1156, 514);
            panelContainer.TabIndex = 8;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(hiddenID);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(button2);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(188, 32);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 4;
            // 
            // hiddenID
            // 
            hiddenID.AutoSize = true;
            hiddenID.Location = new Point(384, 45);
            hiddenID.Name = "hiddenID";
            hiddenID.Size = new Size(55, 15);
            hiddenID.TabIndex = 7;
            hiddenID.Text = "hiddenID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 81);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(757, 20);
            button2.Name = "button2";
            button2.Size = new Size(64, 40);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(164, 11);
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
            experienceLabel.Location = new Point(482, 11);
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
            genderLabel.Location = new Point(164, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "close.png");
            // 
            // ViewPlans2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 566);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "ViewPlans2";
            Text = "ViewPlans2";
            navPanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Button btnDP;
        private Button btnWP;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Label hiddenID;
        private Panel panel1;
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private ImageList imageList1;
    }
}