﻿namespace Project_FLEXTrainer.Owner.Forms
{
    partial class MemberReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberReports));
            navPanel = new Panel();
            btnActive = new Button();
            panelTemplate = new Panel();
            panel1 = new Panel();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            panelContainer = new Panel();
            imageList1 = new ImageList(components);
            navPanel.SuspendLayout();
            panelTemplate.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(btnActive);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1144, 52);
            navPanel.TabIndex = 1;
            // 
            // btnActive
            // 
            btnActive.Dock = DockStyle.Left;
            btnActive.FlatAppearance.BorderSize = 0;
            btnActive.FlatStyle = FlatStyle.Flat;
            btnActive.Font = new Font("Segoe UI", 14.25F);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(0, 0);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(130, 52);
            btnActive.TabIndex = 1;
            btnActive.Text = "ACTIVE";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(151, 6);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 81);
            panel1.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(184, 11);
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
            experienceLabel.Location = new Point(502, 11);
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
            genderLabel.Location = new Point(184, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 52);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1144, 451);
            panelContainer.TabIndex = 8;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "close.png");
            // 
            // MemberReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 503);
            Controls.Add(panelContainer);
            Controls.Add(navPanel);
            Name = "MemberReports";
            Text = "Member Reports";
            navPanel.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button btnCancelled;
        private Button btnExpired;
        private Button btnSuspended;
        private Button btnActive;
        private Button btnAll;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Panel panel1;
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private ImageList imageList1;
    }
}