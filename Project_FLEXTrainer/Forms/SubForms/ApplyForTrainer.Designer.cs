namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class ApplyForTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyForTrainer));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainPanel = new Panel();
            button1 = new Button();
            exit = new Button();
            txt = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            gymCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            addGym = new Guna.UI2.WinForms.Guna2Button();
            applyBtn = new Guna.UI2.WinForms.Guna2Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(126, 46, 53);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(exit);
            mainPanel.Controls.Add(txt);
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(581, 61);
            mainPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(808, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 43);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1105, 0);
            exit.Name = "exit";
            exit.Size = new Size(38, 39);
            exit.TabIndex = 1;
            exit.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Dock = DockStyle.Left;
            txt.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.White;
            txt.Location = new Point(0, 0);
            txt.Name = "txt";
            txt.Padding = new Padding(5, 20, 0, 0);
            txt.Size = new Size(245, 51);
            txt.TabIndex = 0;
            txt.Text = "Apply For Trainer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(11, 137);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 5;
            label2.Text = "Gym";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(295, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 291);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label1.Location = new Point(295, 57);
            label1.Name = "label1";
            label1.Size = new Size(217, 41);
            label1.TabIndex = 7;
            label1.Text = "Selected Gyms";
            // 
            // gymCombo
            // 
            gymCombo.BackColor = Color.Transparent;
            gymCombo.CustomizableEdges = customizableEdges1;
            gymCombo.DrawMode = DrawMode.OwnerDrawFixed;
            gymCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gymCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            gymCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gymCombo.Font = new Font("Segoe UI", 10F);
            gymCombo.ForeColor = Color.FromArgb(68, 88, 112);
            gymCombo.ItemHeight = 30;
            gymCombo.Location = new Point(98, 142);
            gymCombo.Name = "gymCombo";
            gymCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gymCombo.Size = new Size(179, 36);
            gymCombo.TabIndex = 8;
            // 
            // addGym
            // 
            addGym.BorderRadius = 10;
            addGym.CustomizableEdges = customizableEdges3;
            addGym.DisabledState.BorderColor = Color.DarkGray;
            addGym.DisabledState.CustomBorderColor = Color.DarkGray;
            addGym.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addGym.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addGym.FillColor = Color.FromArgb(126, 46, 53);
            addGym.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addGym.ForeColor = Color.White;
            addGym.Image = (Image)resources.GetObject("addGym.Image");
            addGym.Location = new Point(234, 184);
            addGym.Name = "addGym";
            addGym.ShadowDecoration.CustomizableEdges = customizableEdges4;
            addGym.Size = new Size(43, 35);
            addGym.TabIndex = 9;
            // 
            // applyBtn
            // 
            applyBtn.CustomizableEdges = customizableEdges5;
            applyBtn.DisabledState.BorderColor = Color.DarkGray;
            applyBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            applyBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            applyBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            applyBtn.FillColor = Color.FromArgb(126, 46, 53);
            applyBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(46, 323);
            applyBtn.Name = "applyBtn";
            applyBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            applyBtn.Size = new Size(173, 48);
            applyBtn.TabIndex = 10;
            applyBtn.Text = "Apply";
            // 
            // ApplyForTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 404);
            Controls.Add(applyBtn);
            Controls.Add(addGym);
            Controls.Add(gymCombo);
            Controls.Add(label2);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ApplyForTrainer";
            Text = "ApplyForTrainer";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button button1;
        private Button exit;
        private Label txt;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox gymCombo;
        private Guna.UI2.WinForms.Guna2Button addGym;
        private Guna.UI2.WinForms.Guna2Button applyBtn;
    }
}