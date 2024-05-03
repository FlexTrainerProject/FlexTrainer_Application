namespace Project_FLEXTrainer.Forms.SubForms
{
    partial class Profile
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pfpuser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pfptype = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            pfpMain = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)pfpMain).BeginInit();
            SuspendLayout();
            // 
            // pfpuser
            // 
            pfpuser.BackColor = Color.Transparent;
            pfpuser.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pfpuser.Location = new Point(120, 257);
            pfpuser.Name = "pfpuser";
            pfpuser.Size = new Size(100, 27);
            pfpuser.TabIndex = 1;
            pfpuser.Text = "Username";
            pfpuser.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pfptype
            // 
            pfptype.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pfptype.BackColor = Color.Transparent;
            pfptype.Location = new Point(120, 290);
            pfptype.Name = "pfptype";
            pfptype.Size = new Size(26, 17);
            pfptype.TabIndex = 2;
            pfptype.Text = "type";
            pfptype.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2GradientTileButton1
            // 
            guna2GradientTileButton1.CustomizableEdges = customizableEdges1;
            guna2GradientTileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientTileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientTileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientTileButton1.FillColor = Color.FromArgb(192, 0, 0);
            guna2GradientTileButton1.FillColor2 = Color.Teal;
            guna2GradientTileButton1.Font = new Font("Microsoft Sans Serif", 20.7499981F, FontStyle.Bold);
            guna2GradientTileButton1.ForeColor = Color.White;
            guna2GradientTileButton1.Location = new Point(12, 12);
            guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            guna2GradientTileButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientTileButton1.Size = new Size(316, 100);
            guna2GradientTileButton1.TabIndex = 3;
            guna2GradientTileButton1.Text = "PROFILE";
            guna2GradientTileButton1.Click += guna2GradientTileButton1_Click;
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.BorderRadius = 15;
            guna2GradientButton1.CustomizableEdges = customizableEdges3;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.FromArgb(42, 101, 97);
            guna2GradientButton1.FillColor2 = Color.Teal;
            guna2GradientButton1.Font = new Font("Segoe UI", 9F);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.Location = new Point(120, 367);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientButton1.Size = new Size(95, 32);
            guna2GradientButton1.TabIndex = 4;
            guna2GradientButton1.Text = "MORE";
            guna2GradientButton1.Click += guna2GradientButton1_Click;
            // 
            // pfpMain
            // 
            pfpMain.Image = (Image)resources.GetObject("pfpMain.Image");
            pfpMain.ImageRotate = 0F;
            pfpMain.Location = new Point(120, 153);
            pfpMain.Name = "pfpMain";
            pfpMain.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pfpMain.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pfpMain.Size = new Size(100, 98);
            pfpMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pfpMain.TabIndex = 5;
            pfpMain.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(340, 435);
            Controls.Add(pfpMain);
            Controls.Add(guna2GradientButton1);
            Controls.Add(guna2GradientTileButton1);
            Controls.Add(pfptype);
            Controls.Add(pfpuser);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pfpMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel pfpuser;
        private Guna.UI2.WinForms.Guna2HtmlLabel pfptype;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pfpMain;
    }
}