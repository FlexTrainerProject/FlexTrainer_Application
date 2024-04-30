namespace Project_FLEXTrainer.Forms
{
    partial class bookSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookSession));
            topPanel = new Panel();
            filterPanel = new Panel();
            comboBox1 = new ComboBox();
            filterPic = new PictureBox();
            panelTxt = new Label();
            panelTemplate = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            ratingLabel = new Label();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
            panelContainer = new Panel();
            imageList1 = new ImageList(components);
            topPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterPic).BeginInit();
            panelTemplate.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(filterPanel);
            topPanel.Controls.Add(panelTxt);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1093, 54);
            topPanel.TabIndex = 2;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(42, 101, 97);
            filterPanel.Controls.Add(comboBox1);
            filterPanel.Controls.Add(filterPic);
            filterPanel.Dock = DockStyle.Right;
            filterPanel.Location = new Point(658, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(435, 54);
            filterPanel.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // filterPic
            // 
            filterPic.Dock = DockStyle.Right;
            filterPic.Image = (Image)resources.GetObject("filterPic.Image");
            filterPic.InitialImage = (Image)resources.GetObject("filterPic.InitialImage");
            filterPic.Location = new Point(386, 0);
            filterPic.Name = "filterPic";
            filterPic.Padding = new Padding(5, 5, 10, 10);
            filterPic.Size = new Size(49, 54);
            filterPic.TabIndex = 0;
            filterPic.TabStop = false;
            // 
            // panelTxt
            // 
            panelTxt.AutoSize = true;
            panelTxt.Dock = DockStyle.Left;
            panelTxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            panelTxt.ForeColor = SystemColors.Control;
            panelTxt.Location = new Point(0, 0);
            panelTxt.Name = "panelTxt";
            panelTxt.Padding = new Padding(5, 10, 0, 0);
            panelTxt.Size = new Size(208, 35);
            panelTxt.TabIndex = 0;
            panelTxt.Text = "Book An Appointment";
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(panel1);
            panelTemplate.Controls.Add(button1);
            panelTemplate.Controls.Add(ratingLabel);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(161, 60);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(736, 78);
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
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(682, 20);
            button1.Name = "button1";
            button1.Size = new Size(42, 40);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ratingLabel.ForeColor = Color.White;
            ratingLabel.Location = new Point(422, 39);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(57, 21);
            ratingLabel.TabIndex = 4;
            ratingLabel.Text = "Rating";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(104, 11);
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
            experienceLabel.Location = new Point(422, 11);
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
            genderLabel.Location = new Point(104, 39);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(panelTemplate);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1093, 623);
            panelContainer.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "openview.png");
            // 
            // bookSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 623);
            Controls.Add(topPanel);
            Controls.Add(panelContainer);
            Name = "bookSession";
            Text = "Book Session";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filterPic).EndInit();
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel topPanel;
        private Label panelTxt;
        private Panel filterPanel;
        private ComboBox comboBox1;
        private PictureBox filterPic;
        private Panel panelTemplate;
        private Guna.UI2.WinForms.Guna2CircleButton btnView;
        private Panel panelContainer;
        private Button button1;
        private Label ratingLabel;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private Panel panel1;
        private ImageList imageList1;
    }
}