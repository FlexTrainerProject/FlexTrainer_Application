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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dietPlans));
            btnCreateDP = new Button();
            topPanel = new Panel();
            btnrefresh = new Button();
            comboBox4 = new ComboBox();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panelTemplate = new Panel();
            button3 = new Button();
            button2 = new Button();
            nameLabel = new Label();
            experienceLabel = new Label();
            genderLabel = new Label();
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
            topPanel.Controls.Add(btnrefresh);
            topPanel.Controls.Add(comboBox4);
            topPanel.Controls.Add(searchBar);
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
            // btnrefresh
            // 
            btnrefresh.FlatAppearance.BorderSize = 0;
            btnrefresh.FlatStyle = FlatStyle.Flat;
            btnrefresh.Image = (Image)resources.GetObject("btnrefresh.Image");
            btnrefresh.Location = new Point(195, 3);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(53, 46);
            btnrefresh.TabIndex = 19;
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Right;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(491, 17);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 18;
            comboBox4.Text = "No allergens";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchBar.BorderColor = Color.White;
            searchBar.BorderRadius = 12;
            searchBar.BorderThickness = 2;
            searchBar.CustomizableEdges = customizableEdges1;
            searchBar.DefaultText = "";
            searchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.Font = new Font("Segoe UI", 9F);
            searchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBar.IconRight = (Image)resources.GetObject("searchBar.IconRight");
            searchBar.Location = new Point(12, 12);
            searchBar.Name = "searchBar";
            searchBar.PasswordChar = '\0';
            searchBar.PlaceholderText = "Search";
            searchBar.SelectedText = "";
            searchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchBar.Size = new Size(177, 28);
            searchBar.TabIndex = 9;
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
            // panelTemplate
            // 
            panelTemplate.BackColor = Color.FromArgb(170, 52, 60);
            panelTemplate.Controls.Add(button3);
            panelTemplate.Controls.Add(button2);
            panelTemplate.Controls.Add(nameLabel);
            panelTemplate.Controls.Add(experienceLabel);
            panelTemplate.Controls.Add(genderLabel);
            panelTemplate.Location = new Point(112, 17);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Padding = new Padding(20, 0, 0, 0);
            panelTemplate.Size = new Size(821, 78);
            panelTemplate.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 101, 97);
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(20, 0);
            button3.Name = "button3";
            button3.Size = new Size(42, 78);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add4.png");
            imageList1.Images.SetKeyName(1, "openview.png");
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
        private Button button2;
        private Label nameLabel;
        private Label experienceLabel;
        private Label genderLabel;
        private Button button3;
        private ComboBox comboBox4;
        private Button btnrefresh;
    }
}