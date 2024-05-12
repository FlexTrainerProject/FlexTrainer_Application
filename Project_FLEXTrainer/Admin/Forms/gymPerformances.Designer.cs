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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navPanel = new Panel();
            pgTitle = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            gunaCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            navPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(pgTitle);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 40);
            panel1.Controls.Add(gunaCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(837, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 141);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 77);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 20, 0, 0);
            label2.Size = new Size(53, 43);
            label2.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 59);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 20, 0, 0);
            label1.Size = new Size(143, 61);
            label1.TabIndex = 14;
            label1.Text = "Total Count: ";
            // 
            // gunaCombo
            // 
            gunaCombo.BackColor = Color.Transparent;
            gunaCombo.CustomizableEdges = customizableEdges1;
            gunaCombo.DrawMode = DrawMode.OwnerDrawFixed;
            gunaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gunaCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            gunaCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gunaCombo.Font = new Font("Segoe UI", 10F);
            gunaCombo.ForeColor = Color.FromArgb(68, 88, 112);
            gunaCombo.ItemHeight = 30;
            gunaCombo.Location = new Point(13, 20);
            gunaCombo.Name = "gunaCombo";
            gunaCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gunaCombo.Size = new Size(285, 36);
            gunaCombo.TabIndex = 16;
            // 
            // gymPerformances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1312, 661);
            Controls.Add(panel1);
            Controls.Add(navPanel);
            Name = "gymPerformances";
            Text = "Gym Perfomances";
            navPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Label pgTitle;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox gunaCombo;
    }
}