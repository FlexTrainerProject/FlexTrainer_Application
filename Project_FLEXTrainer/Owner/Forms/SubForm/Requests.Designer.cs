namespace Project_FLEXTrainer.Owner.Forms.SubForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            panel1 = new Panel();
            name = new Label();
            templatePanel = new Panel();
            btnReject = new Button();
            btnAccept = new Button();
            txtSpecs = new Label();
            txtQual = new Label();
            btnRemove = new Button();
            txtExp = new Label();
            txtName = new Label();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            templatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 46, 53);
            panel1.Controls.Add(name);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 62);
            panel1.TabIndex = 0;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(12, 9);
            name.Name = "name";
            name.Size = new Size(146, 37);
            name.TabIndex = 2;
            name.Text = "REQUESTS";
            // 
            // templatePanel
            // 
            templatePanel.BackColor = Color.FromArgb(126, 46, 53);
            templatePanel.Controls.Add(btnReject);
            templatePanel.Controls.Add(btnAccept);
            templatePanel.Controls.Add(txtSpecs);
            templatePanel.Controls.Add(txtQual);
            templatePanel.Controls.Add(btnRemove);
            templatePanel.Controls.Add(txtExp);
            templatePanel.Controls.Add(txtName);
            templatePanel.Location = new Point(12, 92);
            templatePanel.Name = "templatePanel";
            templatePanel.Size = new Size(458, 136);
            templatePanel.TabIndex = 4;
            // 
            // btnReject
            // 
            btnReject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.ForeColor = SystemColors.ControlLight;
            btnReject.Image = (Image)resources.GetObject("btnReject.Image");
            btnReject.Location = new Point(404, 45);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(51, 36);
            btnReject.TabIndex = 7;
            btnReject.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.ForeColor = SystemColors.ControlLight;
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(407, 9);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(48, 36);
            btnAccept.TabIndex = 6;
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // txtSpecs
            // 
            txtSpecs.AutoSize = true;
            txtSpecs.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtSpecs.ForeColor = Color.White;
            txtSpecs.Location = new Point(22, 96);
            txtSpecs.Name = "txtSpecs";
            txtSpecs.Size = new Size(135, 25);
            txtSpecs.TabIndex = 5;
            txtSpecs.Text = "Specialization:";
            // 
            // txtQual
            // 
            txtQual.AutoSize = true;
            txtQual.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtQual.ForeColor = Color.White;
            txtQual.Location = new Point(22, 45);
            txtQual.Name = "txtQual";
            txtQual.Size = new Size(127, 25);
            txtQual.TabIndex = 4;
            txtQual.Text = "Qualification:";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(76, 126, 122);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.WhiteSmoke;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(826, 45);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(141, 79);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // txtExp
            // 
            txtExp.AutoSize = true;
            txtExp.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtExp.ForeColor = Color.White;
            txtExp.Location = new Point(22, 69);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(110, 25);
            txtExp.TabIndex = 2;
            txtExp.Text = "Experience:";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(22, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(74, 25);
            txtName.TabIndex = 1;
            txtName.Text = "Name: ";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add4.png");
            imageList1.Images.SetKeyName(1, "close.png");
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 598);
            Controls.Add(templatePanel);
            Controls.Add(panel1);
            Name = "Requests";
            Text = "Requests";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            templatePanel.ResumeLayout(false);
            templatePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label name;
        private Panel templatePanel;
        private Button btnRemove;
        private Label txtExp;
        private Label txtName;
        private Label txtQual;
        private Button btnReject;
        private Button btnAccept;
        private Label txtSpecs;
        private ImageList imageList1;
    }
}