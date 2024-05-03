namespace Project_FLEXTrainer.Forms
{
    partial class Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            topPanel = new Panel();
            panelTxt = new Label();
            btnFeedback = new Button();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(26, 46, 53);
            topPanel.Controls.Add(btnFeedback);
            topPanel.Controls.Add(panelTxt);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1217, 54);
            topPanel.TabIndex = 3;
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
            panelTxt.Size = new Size(232, 35);
            panelTxt.TabIndex = 0;
            panelTxt.Text = "Scheduled Appointments";
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(42, 101, 97);
            btnFeedback.Dock = DockStyle.Right;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFeedback.ForeColor = Color.White;
            btnFeedback.Image = (Image)resources.GetObject("btnFeedback.Image");
            btnFeedback.ImageAlign = ContentAlignment.MiddleLeft;
            btnFeedback.Location = new Point(831, 0);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Padding = new Padding(20, 0, 0, 0);
            btnFeedback.Size = new Size(386, 54);
            btnFeedback.TabIndex = 1;
            btnFeedback.Text = "    GIVE FEEDBACK";
            btnFeedback.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 665);
            Controls.Add(topPanel);
            Name = "Appointments";
            Text = "Appointments";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Button btnFeedback;
        private Label panelTxt;
    }
}