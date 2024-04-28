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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workoutPlans));
            searchBar = new TextBox();
            btnCreateWP = new Button();
            topPanel = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            WorkOut = new DataGridView();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WorkOut).BeginInit();
            SuspendLayout();
            // 
            // searchBar
            // 
            searchBar.Location = new Point(12, 17);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(168, 23);
            searchBar.TabIndex = 1;
            searchBar.Text = "Search...";
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
            btnCreateWP.Click += btnCreateWP_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(comboBox3);
            topPanel.Controls.Add(comboBox2);
            topPanel.Controls.Add(comboBox1);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(searchBar);
            topPanel.Controls.Add(btnCreateWP);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 54);
            topPanel.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(213, 16);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "Goal";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Schedule";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(466, 17);
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
            button1.Location = new Point(602, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 54);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            // 
            // WorkOut
            // 
            WorkOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkOut.Location = new Point(12, 79);
            WorkOut.Name = "WorkOut";
            WorkOut.Size = new Size(776, 359);
            WorkOut.TabIndex = 1;
            WorkOut.CellContentClick += WorkOut_CellContentClick;
            // 
            // workoutPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(WorkOut);
            Controls.Add(topPanel);
            Name = "workoutPlans";
            Text = "Workout Plans";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WorkOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchBar;
        private Button btnCreateWP;
        private Panel topPanel;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private DataGridView WorkOut;
    }
}