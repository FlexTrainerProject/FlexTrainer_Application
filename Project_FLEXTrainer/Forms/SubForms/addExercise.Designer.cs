namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class addExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addExercise));
            mainPanel = new Panel();
            exit = new Button();
            txt = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCreate = new Button();
            panel2 = new Panel();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(42, 101, 97);
            mainPanel.Controls.Add(exit);
            mainPanel.Controls.Add(txt);
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(498, 61);
            mainPanel.TabIndex = 0;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(460, 0);
            exit.Name = "exit";
            exit.Size = new Size(38, 39);
            exit.TabIndex = 1;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Dock = DockStyle.Left;
            txt.Font = new Font("Couture", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.White;
            txt.Location = new Point(0, 0);
            txt.Name = "txt";
            txt.Padding = new Padding(5, 20, 0, 0);
            txt.Size = new Size(151, 47);
            txt.TabIndex = 0;
            txt.Text = "EXERCISE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(245, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 334);
            panel1.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 123);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 2;
            label1.Text = "Target Muscle";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 167);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 3;
            label2.Text = "Routine (Days)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 209);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 4;
            label3.Text = "Machine";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(189, 247);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 5;
            label4.Text = "Sets";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(184, 287);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 6;
            label5.Text = "Reps";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(170, 52, 60);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(172, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 42);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "ADD";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCreate);
            panel2.Location = new Point(0, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 59);
            panel2.TabIndex = 7;
            // 
            // addExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(498, 395);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "addExercise";
            Load += addExercise_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Label txt;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnCreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Button exit;
    }
}