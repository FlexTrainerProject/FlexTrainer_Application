namespace Project_FLEXTrainer.Forms
{
    partial class workoutPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workoutPlans));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnCreateWP = new Button();
            topPanel = new Panel();
            searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            WorkOut = new Guna.UI2.WinForms.Guna2DataGridView();
            topPanel.SuspendLayout();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WorkOut).BeginInit();
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
            btnCreateWP.Location = new Point(1050, 0);
            btnCreateWP.Name = "btnCreateWP";
            btnCreateWP.Size = new Size(168, 54);
            btnCreateWP.TabIndex = 1;
            btnCreateWP.Text = "CREATE";
            btnCreateWP.UseVisualStyleBackColor = false;
            btnCreateWP.Click += btnCreateWP_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(searchBar);
            topPanel.Controls.Add(comboBox3);
            topPanel.Controls.Add(comboBox2);
            topPanel.Controls.Add(comboBox1);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(btnCreateWP);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1218, 54);
            topPanel.TabIndex = 0;
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
            searchBar.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(631, 16);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "Goal";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(758, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Schedule";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(884, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Experience Level";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1020, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 54);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            // 
            // Panel
            // 
            Panel.Controls.Add(WorkOut);
            Panel.CustomizableEdges = customizableEdges3;
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 54);
            Panel.Name = "Panel";
            Panel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Panel.Size = new Size(1218, 602);
            Panel.TabIndex = 1;
            // 
            // WorkOut
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            WorkOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            WorkOut.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            WorkOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            WorkOut.ColumnHeadersHeight = 25;
            WorkOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            WorkOut.DefaultCellStyle = dataGridViewCellStyle3;
            WorkOut.Dock = DockStyle.Fill;
            WorkOut.GridColor = Color.FromArgb(76, 126, 122);
            WorkOut.Location = new Point(0, 0);
            WorkOut.Name = "WorkOut";
            WorkOut.RowHeadersVisible = false;
            WorkOut.RowTemplate.Height = 60;
            WorkOut.Size = new Size(1218, 602);
            WorkOut.TabIndex = 0;
            WorkOut.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            WorkOut.ThemeStyle.AlternatingRowsStyle.Font = null;
            WorkOut.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            WorkOut.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            WorkOut.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            WorkOut.ThemeStyle.BackColor = Color.WhiteSmoke;
            WorkOut.ThemeStyle.GridColor = Color.FromArgb(76, 126, 122);
            WorkOut.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            WorkOut.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            WorkOut.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            WorkOut.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            WorkOut.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            WorkOut.ThemeStyle.HeaderStyle.Height = 25;
            WorkOut.ThemeStyle.ReadOnly = false;
            WorkOut.ThemeStyle.RowsStyle.BackColor = Color.White;
            WorkOut.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            WorkOut.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            WorkOut.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            WorkOut.ThemeStyle.RowsStyle.Height = 60;
            WorkOut.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            WorkOut.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // workoutPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(1218, 656);
            Controls.Add(Panel);
            Controls.Add(topPanel);
            Name = "workoutPlans";
            Text = "Workout Plans";
            topPanel.ResumeLayout(false);
            Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WorkOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateWP;
        private Panel topPanel;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel;
        private Guna.UI2.WinForms.Guna2DataGridView WorkOut;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
    }
}