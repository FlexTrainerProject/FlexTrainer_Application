namespace Project_FLEXTrainer.Trainer.Forms
{
    partial class createDietPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createDietPlan));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnCreate = new Button();
            clientCombo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            AllergensTxt = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddMeal = new Button();
            label4 = new Label();
            panelExercise = new Panel();
            addButton = new Button();
            goalTxt = new ComboBox();
            typeTxt = new ComboBox();
            NutritionTxt = new ComboBox();
            NutritionValTxt = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Controls.Add(NutritionTxt);
            panel1.Controls.Add(typeTxt);
            panel1.Controls.Add(goalTxt);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(clientCombo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 607);
            panel1.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Image = (Image)resources.GetObject("btnCreate.Image");
            btnCreate.Location = new Point(1376, 504);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(83, 594);
            btnCreate.TabIndex = 13;
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // clientCombo
            // 
            clientCombo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientCombo.FormattingEnabled = true;
            clientCombo.Location = new Point(381, 64);
            clientCombo.Name = "clientCombo";
            clientCombo.Size = new Size(180, 33);
            clientCombo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(372, 24);
            label6.Name = "label6";
            label6.Size = new Size(88, 37);
            label6.TabIndex = 11;
            label6.Text = "Client";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 34);
            label5.Name = "label5";
            label5.Size = new Size(185, 54);
            label5.TabIndex = 10;
            label5.Text = "Diet Plan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(125, 383);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 9;
            label3.Text = "Nutrition";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(125, 266);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 7;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(125, 161);
            label1.Name = "label1";
            label1.Size = new Size(73, 37);
            label1.TabIndex = 1;
            label1.Text = "Goal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(140, 147, 148);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnAddMeal);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panelExercise);
            panel2.Controls.Add(addButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(581, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 607);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(26, 46, 53);
            panel3.Controls.Add(NutritionValTxt);
            panel3.Controls.Add(AllergensTxt);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(53, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 166);
            panel3.TabIndex = 3;
            // 
            // AllergensTxt
            // 
            AllergensTxt.BorderRadius = 10;
            AllergensTxt.CustomizableEdges = customizableEdges3;
            AllergensTxt.DefaultText = "";
            AllergensTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AllergensTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AllergensTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AllergensTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AllergensTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AllergensTxt.Font = new Font("Segoe UI", 9F);
            AllergensTxt.ForeColor = Color.DimGray;
            AllergensTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AllergensTxt.Location = new Point(108, 63);
            AllergensTxt.Name = "AllergensTxt";
            AllergensTxt.PasswordChar = '\0';
            AllergensTxt.PlaceholderText = "Allergens";
            AllergensTxt.SelectedText = "";
            AllergensTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AllergensTxt.Size = new Size(208, 38);
            AllergensTxt.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges5;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(108, 18);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtName.Size = new Size(208, 39);
            txtName.TabIndex = 0;
            // 
            // btnAddMeal
            // 
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Image = (Image)resources.GetObject("btnAddMeal.Image");
            btnAddMeal.Location = new Point(433, 34);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(35, 30);
            btnAddMeal.TabIndex = 11;
            btnAddMeal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(53, 27);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 10;
            label4.Text = "Meals";
            // 
            // panelExercise
            // 
            panelExercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelExercise.BackColor = Color.WhiteSmoke;
            panelExercise.Location = new Point(53, 242);
            panelExercise.Name = "panelExercise";
            panelExercise.Size = new Size(427, 841);
            panelExercise.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(170, 52, 60);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(936, 1546);
            addButton.Name = "addButton";
            addButton.Size = new Size(186, 51);
            addButton.TabIndex = 1;
            addButton.Text = "ADD TRAINER";
            addButton.UseVisualStyleBackColor = false;
            // 
            // goalTxt
            // 
            goalTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalTxt.FormattingEnabled = true;
            goalTxt.Location = new Point(135, 201);
            goalTxt.Name = "goalTxt";
            goalTxt.Size = new Size(262, 33);
            goalTxt.TabIndex = 14;
            // 
            // typeTxt
            // 
            typeTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeTxt.FormattingEnabled = true;
            typeTxt.Location = new Point(135, 320);
            typeTxt.Name = "typeTxt";
            typeTxt.Size = new Size(262, 33);
            typeTxt.TabIndex = 15;
            // 
            // NutritionTxt
            // 
            NutritionTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NutritionTxt.FormattingEnabled = true;
            NutritionTxt.Location = new Point(135, 434);
            NutritionTxt.Name = "NutritionTxt";
            NutritionTxt.Size = new Size(262, 33);
            NutritionTxt.TabIndex = 16;
            // 
            // NutritionValTxt
            // 
            NutritionValTxt.BorderRadius = 10;
            NutritionValTxt.CustomizableEdges = customizableEdges1;
            NutritionValTxt.DefaultText = "";
            NutritionValTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            NutritionValTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            NutritionValTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            NutritionValTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            NutritionValTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            NutritionValTxt.Font = new Font("Segoe UI", 9F);
            NutritionValTxt.ForeColor = Color.DimGray;
            NutritionValTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            NutritionValTxt.Location = new Point(108, 107);
            NutritionValTxt.Name = "NutritionValTxt";
            NutritionValTxt.PasswordChar = '\0';
            NutritionValTxt.PlaceholderText = "Nutritional Value";
            NutritionValTxt.SelectedText = "";
            NutritionValTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            NutritionValTxt.Size = new Size(208, 38);
            NutritionValTxt.TabIndex = 2;
            // 
            // createDietPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 631);
            Controls.Add(panel1);
            Name = "createDietPlan";
            Text = "createDietPlan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCreate;
        private ComboBox clientCombo;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox AllergensTxt;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Button btnAddMeal;
        private Label label4;
        private Panel panelExercise;
        private Button addButton;
        private ComboBox NutritionTxt;
        private ComboBox typeTxt;
        private ComboBox goalTxt;
        private Guna.UI2.WinForms.Guna2TextBox NutritionValTxt;
    }
}