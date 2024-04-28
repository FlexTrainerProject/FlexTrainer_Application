namespace Project_FLEXTrainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Couture", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(170, 52, 60);
            label1.Location = new Point(114, 243);
            label1.Name = "label1";
            label1.Size = new Size(375, 48);
            label1.TabIndex = 4;
            label1.Text = "FLEX TRAINER";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(61, 228);
            button1.Name = "button1";
            button1.Size = new Size(239, 46);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(61, 280);
            button2.Name = "button2";
            button2.Size = new Size(239, 46);
            button2.TabIndex = 8;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 72, 76);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(513, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 532);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Retroica", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 122);
            label2.Name = "label2";
            label2.Size = new Size(267, 49);
            label2.TabIndex = 7;
            label2.Text = "WELCOME";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 72, 76);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 532);
            panel2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(906, 532);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label2;
    }
}
