namespace Project_FLEXTrainer.Admin.Forms
{
    partial class Requests
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
            navPanel = new Panel();
            btnArchived = new Button();
            btnPending = new Button();
            pgTitle = new Label();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(btnArchived);
            navPanel.Controls.Add(btnPending);
            navPanel.Controls.Add(pgTitle);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1159, 52);
            navPanel.TabIndex = 3;
            // 
            // btnArchived
            // 
            btnArchived.Dock = DockStyle.Right;
            btnArchived.FlatAppearance.BorderSize = 0;
            btnArchived.FlatStyle = FlatStyle.Flat;
            btnArchived.Font = new Font("Segoe UI", 14.25F);
            btnArchived.ForeColor = Color.White;
            btnArchived.Location = new Point(559, 0);
            btnArchived.Name = "btnArchived";
            btnArchived.Size = new Size(316, 52);
            btnArchived.TabIndex = 14;
            btnArchived.Text = "ARCHIVED";
            btnArchived.UseVisualStyleBackColor = true;
            btnArchived.Click += btnArchived_Click;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.FromArgb(76, 126, 122);
            btnPending.Dock = DockStyle.Right;
            btnPending.FlatAppearance.BorderSize = 0;
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPending.ForeColor = Color.White;
            btnPending.Location = new Point(875, 0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(284, 52);
            btnPending.TabIndex = 13;
            btnPending.Text = "PENDING";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click;
            // 
            // pgTitle
            // 
            pgTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -11);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(318, 63);
            pgTitle.TabIndex = 12;
            pgTitle.Text = "Registration Requests";
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1159, 626);
            Controls.Add(navPanel);
            Name = "Requests";
            Text = "Requests";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Label pgTitle;
        private Button btnArchived;
        private Button btnPending;
    }
}