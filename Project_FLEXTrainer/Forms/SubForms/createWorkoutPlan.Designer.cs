namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class createWorkoutPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createWorkoutPlan));
            panel1 = new Panel();
            panelMain = new Panel();
            btnCreate = new Button();
            label4 = new Label();
            devidePanel = new Panel();
            panel6 = new Panel();
            btnAddExercise = new Button();
            label5 = new Label();
            panelExercise = new FlowLayoutPanel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            txtPanel = new Panel();
            btnClose = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panelMain.SuspendLayout();
            devidePanel.SuspendLayout();
            panel6.SuspendLayout();
            txtPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panelMain);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 518);
            panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(42, 101, 97);
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(devidePanel);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(130, 106);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(567, 347);
            panelMain.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreate.BackColor = Color.FromArgb(170, 52, 60);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(107, 266);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 42);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 174);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 8;
            label4.Text = "Experience Level";
            // 
            // devidePanel
            // 
            devidePanel.BackColor = Color.MintCream;
            devidePanel.BorderStyle = BorderStyle.FixedSingle;
            devidePanel.Controls.Add(panel6);
            devidePanel.Controls.Add(panelExercise);
            devidePanel.Controls.Add(comboBox3);
            devidePanel.Controls.Add(comboBox2);
            devidePanel.Controls.Add(comboBox1);
            devidePanel.Dock = DockStyle.Right;
            devidePanel.Location = new Point(181, 0);
            devidePanel.Name = "devidePanel";
            devidePanel.Size = new Size(386, 347);
            devidePanel.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = Color.MintCream;
            panel6.Controls.Add(btnAddExercise);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(213, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(171, 31);
            panel6.TabIndex = 0;
            panel6.Paint += panel6_Paint;
            // 
            // btnAddExercise
            // 
            btnAddExercise.FlatAppearance.BorderSize = 0;
            btnAddExercise.FlatStyle = FlatStyle.Flat;
            btnAddExercise.Image = (Image)resources.GetObject("btnAddExercise.Image");
            btnAddExercise.Location = new Point(138, 3);
            btnAddExercise.Name = "btnAddExercise";
            btnAddExercise.Size = new Size(27, 28);
            btnAddExercise.TabIndex = 1;
            btnAddExercise.UseVisualStyleBackColor = true;
            btnAddExercise.Click += btnAddExercise_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 0;
            label5.Text = "Exercises";
            // 
            // panelExercise
            // 
            panelExercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelExercise.BackColor = Color.White;
            panelExercise.BorderStyle = BorderStyle.FixedSingle;
            panelExercise.Location = new Point(213, 37);
            panelExercise.Name = "panelExercise";
            panelExercise.Padding = new Padding(0, 5, 0, 0);
            panelExercise.Size = new Size(171, 308);
            panelExercise.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(23, 174);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(160, 23);
            comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 126);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 126);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 7;
            label3.Text = "Schedule";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 6;
            label2.Text = "Goal";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(130, 453);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 61);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(130, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 46);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(697, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 454);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 454);
            panel2.TabIndex = 1;
            // 
            // txtPanel
            // 
            txtPanel.BackColor = Color.FromArgb(42, 101, 97);
            txtPanel.Controls.Add(btnClose);
            txtPanel.Controls.Add(label1);
            txtPanel.Dock = DockStyle.Top;
            txtPanel.Location = new Point(0, 0);
            txtPanel.Name = "txtPanel";
            txtPanel.Size = new Size(850, 60);
            txtPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(820, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 23);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Couture", 20.2499981F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(360, 27);
            label1.TabIndex = 0;
            label1.Text = "CREATE WORKOUT PLAN";
            // 
            // createWorkoutPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(854, 518);
            Controls.Add(panel1);
            Name = "createWorkoutPlan";
            Text = "createWorkoutPlan";
            panel1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            devidePanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            txtPanel.ResumeLayout(false);
            txtPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel txtPanel;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Button btnClose;
        private Panel panelMain;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Panel devidePanel;
        private Label label3;
        private Label label2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnCreate;
        private FlowLayoutPanel panelExercise;
        private Panel panel6;
        private Label label5;
        private Button btnAddExercise;
    }
}