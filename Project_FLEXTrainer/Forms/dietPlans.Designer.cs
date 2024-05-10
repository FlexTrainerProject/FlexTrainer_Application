namespace Project_FLEXTrainer.Forms
{
    partial class dietPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dietPlans));
            btnCreateDP = new Button();
            topPanel = new Panel();
            panelTemplate = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            imageList1 = new ImageList(components);
            panelContainer = new Panel();
            topPanel.SuspendLayout();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateDP
            // 
            btnCreateDP.BackColor = Color.FromArgb(42, 101, 97);
            btnCreateDP.Dock = DockStyle.Right;
            btnCreateDP.FlatAppearance.BorderSize = 0;
            btnCreateDP.FlatStyle = FlatStyle.Flat;
            btnCreateDP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateDP.ForeColor = Color.White;
            btnCreateDP.Location = new Point(969, 0);
            btnCreateDP.Name = "btnCreateDP";
            btnCreateDP.Size = new Size(168, 54);
            btnCreateDP.TabIndex = 1;
            btnCreateDP.Text = "CREATE";
            btnCreateDP.UseVisualStyleBackColor = false;
            btnCreateDP.Click += btnCreateDP_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(panelTemplate);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(comboBox3);
            topPanel.Controls.Add(comboBox2);
            topPanel.Controls.Add(comboBox1);
            topPanel.Controls.Add(btnCreateDP);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1137, 54);
            topPanel.TabIndex = 2;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(button2);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(161, 12);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 101, 97);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 81);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(759, 20);
            button2.Name = "button2";
            button2.Size = new Size(42, 40);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(124, 11);
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
            experienceLabel.Location = new Point(442, 11);
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
            genderLabel.Location = new Point(124, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(939, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 54);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(834, 17);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(99, 23);
            comboBox3.TabIndex = 7;
            comboBox3.Text = "Nutrition";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(725, 17);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(103, 23);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Purpose";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(618, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Type";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add4.png");
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 54);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1137, 534);
            panelContainer.TabIndex = 5;
            // 
            // dietPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1137, 588);
            Controls.Add(panelContainer);
            Controls.Add(topPanel);
            Name = "dietPlans";
            Text = "Diet Plans";
            topPanel.ResumeLayout(false);
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateDP;
        private Panel topPanel;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private ImageList imageList1;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Panel panelContainer;
        private Panel panelTemplate;
        private Panel panel1;
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
    }
}