namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class TrainerInfo
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerInfo));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnBook = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            label4 = new Label();
            gymCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            TimingCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            closeError = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 46, 53);
            panel1.Controls.Add(closeError);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 0;
            label1.Text = "trainerName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 1;
            label2.Text = "trainerExperience";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 2;
            label3.Text = "trainerRating";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(76, 126, 122);
            panel2.Controls.Add(btnBook);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(gymCombo);
            panel2.Controls.Add(TimingCombo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 216);
            panel2.TabIndex = 3;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(76, 126, 122);
            btnBook.BorderRadius = 10;
            btnBook.CustomizableEdges = customizableEdges1;
            btnBook.DisabledState.BorderColor = Color.DarkGray;
            btnBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBook.FillColor = Color.FromArgb(126, 46, 53);
            btnBook.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(110, 159);
            btnBook.Name = "btnBook";
            btnBook.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBook.Size = new Size(180, 45);
            btnBook.TabIndex = 4;
            btnBook.Text = "BOOK APPOINTMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 98);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 3;
            label5.Text = "Timing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 41);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 2;
            label4.Text = "Gym";
            // 
            // gymCombo
            // 
            gymCombo.BackColor = Color.Transparent;
            gymCombo.CustomizableEdges = customizableEdges3;
            gymCombo.DrawMode = DrawMode.OwnerDrawFixed;
            gymCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gymCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            gymCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gymCombo.Font = new Font("Segoe UI", 10F);
            gymCombo.ForeColor = Color.FromArgb(68, 88, 112);
            gymCombo.ItemHeight = 30;
            gymCombo.Location = new Point(144, 41);
            gymCombo.Name = "gymCombo";
            gymCombo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gymCombo.Size = new Size(186, 36);
            gymCombo.TabIndex = 1;
            // 
            // TimingCombo
            // 
            TimingCombo.BackColor = Color.Transparent;
            TimingCombo.CustomizableEdges = customizableEdges5;
            TimingCombo.DrawMode = DrawMode.OwnerDrawFixed;
            TimingCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TimingCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            TimingCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TimingCombo.Font = new Font("Segoe UI", 10F);
            TimingCombo.ForeColor = Color.FromArgb(68, 88, 112);
            TimingCombo.ItemHeight = 30;
            TimingCombo.Location = new Point(144, 94);
            TimingCombo.Name = "TimingCombo";
            TimingCombo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TimingCombo.Size = new Size(186, 36);
            TimingCombo.TabIndex = 0;
            TimingCombo.SelectedIndexChanged += TimingCombo_SelectedIndexChanged;
            // 
            // closeError
            // 
            closeError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeError.FlatAppearance.BorderSize = 0;
            closeError.FlatStyle = FlatStyle.Flat;
            closeError.Image = (Image)resources.GetObject("closeError.Image");
            closeError.Location = new Point(365, 0);
            closeError.Name = "closeError";
            closeError.Size = new Size(37, 43);
            closeError.TabIndex = 2;
            closeError.UseVisualStyleBackColor = true;
            closeError.Click += closeError_Click;
            // 
            // TrainerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 147, 148);
            ClientSize = new Size(402, 441);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "TrainerInfo";
            Text = "TrainerInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox gymCombo;
        private Guna.UI2.WinForms.Guna2ComboBox TimingCombo;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Label label5;
        private Label label4;
        private Button closeError;
    }
}