namespace Project_FLEXTrainer.Owner.Forms
{
    partial class MemberReports
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
            btnExpired = new Button();
            btnCancelled = new Button();
            btnSuspended = new Button();
            btnActive = new Button();
            btnAll = new Button();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(25, 42, 40);
            navPanel.Controls.Add(btnExpired);
            navPanel.Controls.Add(btnCancelled);
            navPanel.Controls.Add(btnSuspended);
            navPanel.Controls.Add(btnActive);
            navPanel.Controls.Add(btnAll);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1093, 52);
            navPanel.TabIndex = 1;
            // 
            // btnExpired
            // 
            btnExpired.Dock = DockStyle.Left;
            btnExpired.FlatAppearance.BorderSize = 0;
            btnExpired.FlatStyle = FlatStyle.Flat;
            btnExpired.Font = new Font("Segoe UI", 14.25F);
            btnExpired.ForeColor = Color.White;
            btnExpired.Location = new Point(552, 0);
            btnExpired.Name = "btnExpired";
            btnExpired.Size = new Size(140, 52);
            btnExpired.TabIndex = 4;
            btnExpired.Text = "EXPIRED";
            btnExpired.UseVisualStyleBackColor = true;
            btnExpired.Click += btnExpired_Click;
            // 
            // btnCancelled
            // 
            btnCancelled.Dock = DockStyle.Left;
            btnCancelled.FlatAppearance.BorderSize = 0;
            btnCancelled.FlatStyle = FlatStyle.Flat;
            btnCancelled.Font = new Font("Segoe UI", 14.25F);
            btnCancelled.ForeColor = Color.White;
            btnCancelled.Location = new Point(412, 0);
            btnCancelled.Name = "btnCancelled";
            btnCancelled.Size = new Size(140, 52);
            btnCancelled.TabIndex = 3;
            btnCancelled.Text = "CANCELLED";
            btnCancelled.UseVisualStyleBackColor = true;
            btnCancelled.Click += btnCancelled_Click;
            // 
            // btnSuspended
            // 
            btnSuspended.Dock = DockStyle.Left;
            btnSuspended.FlatAppearance.BorderSize = 0;
            btnSuspended.FlatStyle = FlatStyle.Flat;
            btnSuspended.Font = new Font("Segoe UI", 14.25F);
            btnSuspended.ForeColor = Color.White;
            btnSuspended.Location = new Point(254, 0);
            btnSuspended.Name = "btnSuspended";
            btnSuspended.Size = new Size(158, 52);
            btnSuspended.TabIndex = 2;
            btnSuspended.Text = "SUSPENDED";
            btnSuspended.UseVisualStyleBackColor = true;
            btnSuspended.Click += btnSuspended_Click;
            // 
            // btnActive
            // 
            btnActive.Dock = DockStyle.Left;
            btnActive.FlatAppearance.BorderSize = 0;
            btnActive.FlatStyle = FlatStyle.Flat;
            btnActive.Font = new Font("Segoe UI", 14.25F);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(124, 0);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(130, 52);
            btnActive.TabIndex = 1;
            btnActive.Text = "ACTIVE";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(76, 126, 122);
            btnAll.Dock = DockStyle.Left;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(0, 0);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(124, 52);
            btnAll.TabIndex = 0;
            btnAll.Text = "ALL";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // MemberReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 623);
            Controls.Add(navPanel);
            Name = "MemberReports";
            Text = "MemberReports";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button btnCancelled;
        private Button btnExpired;
        private Button btnSuspended;
        private Button btnActive;
        private Button btnAll;
    }
}