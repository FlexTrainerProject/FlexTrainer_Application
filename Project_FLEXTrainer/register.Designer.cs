namespace Project_FLEXTrainer
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            label1 = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            LoginAs = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            Pass = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Retroica", 27.7499962F);
            label1.ForeColor = Color.FromArgb(170, 52, 60);
            label1.Location = new Point(155, 311);
            label1.Name = "label1";
            label1.Size = new Size(273, 38);
            label1.TabIndex = 17;
            label1.Text = "FLEX TRAINER";
            label1.Click += label1_Click;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.Control;
            logo.BackgroundImageLayout = ImageLayout.Center;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(174, 151);
            logo.Margin = new Padding(0);
            logo.Name = "logo";
            logo.Size = new Size(227, 198);
            logo.TabIndex = 18;
            logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 72, 76);
            panel1.Controls.Add(LoginAs);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(Pass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(515, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 534);
            panel1.TabIndex = 19;
            // 
            // LoginAs
            // 
            LoginAs.AccessibleName = "LoginAs";
            LoginAs.DisplayMember = "Member";
            LoginAs.DropDownStyle = ComboBoxStyle.DropDownList;
            LoginAs.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginAs.FormattingEnabled = true;
            LoginAs.Items.AddRange(new object[] { "Member", "Trainer" });
            LoginAs.Location = new Point(61, 344);
            LoginAs.Name = "LoginAs";
            LoginAs.Size = new Size(143, 26);
            LoginAs.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(61, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 29);
            textBox3.TabIndex = 19;
            textBox3.Text = "Email";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(61, 294);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 29);
            textBox2.TabIndex = 18;
            textBox2.Text = "Re-Enter Password";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(61, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 29);
            textBox1.TabIndex = 17;
            textBox1.Text = "Username";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(81, 445);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(204, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? Login here.";
            linkLabel1.Click += linkLabel_click;
            // 
            // Pass
            // 
            Pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pass.Location = new Point(61, 248);
            Pass.Name = "Pass";
            Pass.Size = new Size(239, 29);
            Pass.TabIndex = 15;
            Pass.Text = "Password";
            Pass.Enter += pass_Enter;
            Pass.Leave += pass_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(71, 113);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 1;
            label3.Text = "Member";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(170, 52, 60);
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(61, 386);
            button2.Name = "button2";
            button2.Size = new Size(239, 46);
            button2.TabIndex = 14;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Retroica", 36F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 73);
            label2.Name = "label2";
            label2.Size = new Size(253, 49);
            label2.TabIndex = 0;
            label2.Text = "REGISTER";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 72, 76);
            panel2.Location = new Point(-4, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 534);
            panel2.TabIndex = 20;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(170, 52, 60);
            back.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.ButtonFace;
            back.Location = new Point(222, 403);
            back.Name = "back";
            back.Size = new Size(131, 39);
            back.TabIndex = 19;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 532);
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(logo);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            Load += register_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox logo;
        private Panel panel1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private TextBox Pass;
        private Label label3;
        private Button button2;
        private Label label2;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox textBox2;
        private Button back;
        private TextBox textBox3;
        private ComboBox LoginAs;
    }
}