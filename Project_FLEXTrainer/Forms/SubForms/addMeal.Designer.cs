namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class addMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMeal));
            panel1 = new Panel();
            exit = new Button();
            txt = new Label();
            panel2 = new Panel();
            btnCreate = new Button();
            panel3 = new Panel();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(txt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 61);
            panel1.TabIndex = 0;
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
            exit.TabIndex = 2;
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
            txt.Size = new Size(96, 47);
            txt.TabIndex = 1;
            txt.Text = "MEAL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnCreate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 59);
            panel2.TabIndex = 8;
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(245, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 275);
            panel3.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 227);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 9;
            label3.Text = "Nutritional Value";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 185);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 8;
            label2.Text = "Allergens";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 143);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // addMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 395);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addMeal";
            Text = "addMeal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCreate;
        private Panel panel3;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label txt;
        private Button exit;
    }
}