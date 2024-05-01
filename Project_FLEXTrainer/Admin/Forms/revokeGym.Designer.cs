namespace Project_FLEXTrainer.Admin.Forms
{
    partial class revokeGym
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
            btnRevoked = new Button();
            btnAllgyms = new Button();
            pgTitle = new Label();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(btnRevoked);
            navPanel.Controls.Add(btnAllgyms);
            navPanel.Controls.Add(pgTitle);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1159, 52);
            navPanel.TabIndex = 4;
            // 
            // btnRevoked
            // 
            btnRevoked.Dock = DockStyle.Right;
            btnRevoked.FlatAppearance.BorderSize = 0;
            btnRevoked.FlatStyle = FlatStyle.Flat;
            btnRevoked.Font = new Font("Segoe UI", 14.25F);
            btnRevoked.ForeColor = Color.White;
            btnRevoked.Location = new Point(559, 0);
            btnRevoked.Name = "btnRevoked";
            btnRevoked.Size = new Size(316, 52);
            btnRevoked.TabIndex = 14;
            btnRevoked.Text = "REVOKED GYMS";
            btnRevoked.UseVisualStyleBackColor = true;
            btnRevoked.Click += btnRevoked_Click;
            // 
            // btnAllgyms
            // 
            btnAllgyms.BackColor = Color.FromArgb(76, 126, 122);
            btnAllgyms.Dock = DockStyle.Right;
            btnAllgyms.FlatAppearance.BorderSize = 0;
            btnAllgyms.FlatStyle = FlatStyle.Flat;
            btnAllgyms.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAllgyms.ForeColor = Color.White;
            btnAllgyms.Location = new Point(875, 0);
            btnAllgyms.Name = "btnAllgyms";
            btnAllgyms.Size = new Size(284, 52);
            btnAllgyms.TabIndex = 13;
            btnAllgyms.Text = "EXISTING GYMS";
            btnAllgyms.UseVisualStyleBackColor = false;
            btnAllgyms.Click += btnAllgyms_Click;
            // 
            // pgTitle
            // 
            pgTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pgTitle.ForeColor = Color.White;
            pgTitle.Location = new Point(0, -11);
            pgTitle.Name = "pgTitle";
            pgTitle.Padding = new Padding(10, 20, 0, 0);
            pgTitle.Size = new Size(431, 63);
            pgTitle.TabIndex = 12;
            pgTitle.Text = "Revoke Membership of Gyms";
            // 
            // revokeGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1159, 626);
            Controls.Add(navPanel);
            Name = "revokeGym";
            Text = "Revoke Gym";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button btnRevoked;
        private Button btnAllgyms;
        private Label pgTitle;
    }
}