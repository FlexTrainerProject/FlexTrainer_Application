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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dietPlans));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnCreateWP = new Button();
            topPanel = new Panel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            DietPlansView = new Guna.UI2.WinForms.Guna2DataGridView();
            imageList1 = new ImageList(components);
            Icon = new DataGridViewImageColumn();
            AddButoon = new DataGridViewButtonColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DietPlansView).BeginInit();
            SuspendLayout();
            // 
            // btnCreateWP
            // 
            btnCreateWP.BackColor = Color.FromArgb(42, 101, 97);
            btnCreateWP.Dock = DockStyle.Right;
            btnCreateWP.FlatAppearance.BorderSize = 0;
            btnCreateWP.FlatStyle = FlatStyle.Flat;
            btnCreateWP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateWP.ForeColor = Color.White;
            btnCreateWP.Location = new Point(632, 0);
            btnCreateWP.Name = "btnCreateWP";
            btnCreateWP.Size = new Size(168, 54);
            btnCreateWP.TabIndex = 1;
            btnCreateWP.Text = "CREATE";
            btnCreateWP.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(guna2TextBox1);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(comboBox3);
            topPanel.Controls.Add(comboBox2);
            topPanel.Controls.Add(comboBox1);
            topPanel.Controls.Add(btnCreateWP);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 54);
            topPanel.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2TextBox1.BorderColor = Color.White;
            guna2TextBox1.BorderRadius = 12;
            guna2TextBox1.BorderThickness = 2;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconRight = (Image)resources.GetObject("guna2TextBox1.IconRight");
            guna2TextBox1.Location = new Point(12, 12);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Search";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(177, 28);
            guna2TextBox1.TabIndex = 9;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(602, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 54);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(497, 17);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(99, 23);
            comboBox3.TabIndex = 7;
            comboBox3.Text = "Nutrition";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(388, 17);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(103, 23);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Purpose";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(281, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Type";
            // 
            // DietPlansView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DietPlansView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DietPlansView.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DietPlansView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DietPlansView.ColumnHeadersHeight = 25;
            DietPlansView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DietPlansView.Columns.AddRange(new DataGridViewColumn[] { Icon, AddButoon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DietPlansView.DefaultCellStyle = dataGridViewCellStyle3;
            DietPlansView.Dock = DockStyle.Fill;
            DietPlansView.GridColor = Color.WhiteSmoke;
            DietPlansView.Location = new Point(0, 54);
            DietPlansView.Name = "DietPlansView";
            DietPlansView.RowHeadersVisible = false;
            DietPlansView.Size = new Size(800, 396);
            DietPlansView.TabIndex = 3;
            DietPlansView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DietPlansView.ThemeStyle.AlternatingRowsStyle.Font = null;
            DietPlansView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DietPlansView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DietPlansView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DietPlansView.ThemeStyle.BackColor = Color.WhiteSmoke;
            DietPlansView.ThemeStyle.GridColor = Color.WhiteSmoke;
            DietPlansView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DietPlansView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DietPlansView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DietPlansView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DietPlansView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DietPlansView.ThemeStyle.HeaderStyle.Height = 25;
            DietPlansView.ThemeStyle.ReadOnly = false;
            DietPlansView.ThemeStyle.RowsStyle.BackColor = Color.White;
            DietPlansView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DietPlansView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DietPlansView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DietPlansView.ThemeStyle.RowsStyle.Height = 25;
            DietPlansView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DietPlansView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add2.png");
            // 
            // Icon
            // 
            Icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Icon.FillWeight = 50.54314F;
            Icon.HeaderText = "";
            Icon.Name = "Icon";
            Icon.ReadOnly = true;
            Icon.Width = 50;
            // 
            // AddButoon
            // 
            AddButoon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AddButoon.FillWeight = 50.45685F;
            AddButoon.HeaderText = "";
            AddButoon.Name = "AddButoon";
            AddButoon.Width = 50;
            // 
            // dietPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(DietPlansView);
            Controls.Add(topPanel);
            Name = "dietPlans";
            Text = "Diet Plans";
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DietPlansView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateWP;
        private Panel topPanel;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DietPlansView;
        private ImageList imageList1;
        private DataGridViewImageColumn Icon;
        private DataGridViewButtonColumn AddButoon;
    }
}