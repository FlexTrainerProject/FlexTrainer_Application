﻿namespace Project_FLEXTrainer.Forms
{
    partial class mainHomecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainHomecs));
            mainTxt = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainTxt
            // 
            mainTxt.AutoSize = true;
            mainTxt.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainTxt.ForeColor = Color.FromArgb(26, 46, 53);
            mainTxt.Location = new Point(0, 73);
            mainTxt.Name = "mainTxt";
            mainTxt.Size = new Size(458, 93);
            mainTxt.TabIndex = 0;
            mainTxt.Text = "\r\n\r\nYour Ultimate Fitness Companion ";
            mainTxt.Click += mainTxt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 46, 53);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 1;
            label1.Text = "Welcome ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(170, 52, 60);
            label2.Location = new Point(222, 60);
            label2.Name = "label2";
            label2.Size = new Size(222, 31);
            label2.TabIndex = 2;
            label2.Text = "FLEX TRAINER";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(608, -53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 169);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // mainHomecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mainTxt);
            Controls.Add(pictureBox1);
            Name = "mainHomecs";
            Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainTxt;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}