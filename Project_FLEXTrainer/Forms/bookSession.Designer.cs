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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookSession));
            topPanel = new Panel();
            filterPanel = new Panel();
            comboBox1 = new ComboBox();
            filterPic = new PictureBox();
            panelTxt = new Label();
            topPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterPic).BeginInit();
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
            topPanel.Size = new Size(800, 54);
            topPanel.TabIndex = 2;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(42, 101, 97);
            filterPanel.Controls.Add(comboBox1);
            filterPanel.Controls.Add(filterPic);
            filterPanel.Dock = DockStyle.Right;
            filterPanel.Location = new Point(365, 0);
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
            // bookSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(topPanel);
            Name = "bookSession";
            Text = "Book Session";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filterPic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel topPanel;
        private Label panelTxt;
        private Panel filterPanel;
        private ComboBox comboBox1;
        private PictureBox filterPic;
    }
}