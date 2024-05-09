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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            button1 = new Button();
            ListNutrition = new ComboBox();
            listType = new ComboBox();
            listGoals = new ComboBox();
            btnCreate = new Button();
            clientCombo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            comboAddedMeals = new Guna.UI2.WinForms.Guna2ComboBox();
            panel3 = new Panel();
            NutritionValTxt = new Guna.UI2.WinForms.Guna2TextBox();
            AllergensTxt = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddMeal = new Button();
            label4 = new Label();
            addButton = new Button();
            DName = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(26, 46, 53);
            panel1.Controls.Add(DName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ListNutrition);
            panel1.Controls.Add(listType);
            panel1.Controls.Add(listGoals);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(126, 46, 53);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(191, 534);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 17;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ListNutrition
            // 
            ListNutrition.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListNutrition.FormattingEnabled = true;
            ListNutrition.Location = new Point(136, 474);
            ListNutrition.Name = "ListNutrition";
            ListNutrition.Size = new Size(262, 33);
            ListNutrition.TabIndex = 16;
            // 
            // listType
            // 
            listType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listType.FormattingEnabled = true;
            listType.Location = new Point(136, 360);
            listType.Name = "listType";
            listType.Size = new Size(262, 33);
            listType.TabIndex = 15;
            // 
            // listGoals
            // 
            listGoals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listGoals.FormattingEnabled = true;
            listGoals.Location = new Point(136, 241);
            listGoals.Name = "listGoals";
            listGoals.Size = new Size(262, 33);
            listGoals.TabIndex = 14;
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
            label3.Location = new Point(126, 423);
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
            label2.Location = new Point(126, 306);
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
            label1.Location = new Point(126, 201);
            label1.Name = "label1";
            label1.Size = new Size(73, 37);
            label1.TabIndex = 1;
            label1.Text = "Goal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(140, 147, 148);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboAddedMeals);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnAddMeal);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(581, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 607);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(148, 427);
            label7.Name = "label7";
            label7.Size = new Size(176, 37);
            label7.TabIndex = 13;
            label7.Text = "Added Meals";
            // 
            // comboAddedMeals
            // 
            comboAddedMeals.BackColor = Color.Transparent;
            comboAddedMeals.CustomizableEdges = customizableEdges3;
            comboAddedMeals.DrawMode = DrawMode.OwnerDrawFixed;
            comboAddedMeals.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAddedMeals.FocusedColor = Color.FromArgb(94, 148, 255);
            comboAddedMeals.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboAddedMeals.Font = new Font("Segoe UI", 16F);
            comboAddedMeals.ForeColor = Color.FromArgb(68, 88, 112);
            comboAddedMeals.ItemHeight = 30;
            comboAddedMeals.Location = new Point(81, 467);
            comboAddedMeals.Name = "comboAddedMeals";
            comboAddedMeals.ShadowDecoration.CustomizableEdges = customizableEdges4;
            comboAddedMeals.Size = new Size(337, 36);
            comboAddedMeals.TabIndex = 12;
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
            panel3.Size = new Size(427, 310);
            panel3.TabIndex = 3;
            // 
            // NutritionValTxt
            // 
            NutritionValTxt.BorderRadius = 10;
            NutritionValTxt.CustomizableEdges = customizableEdges5;
            NutritionValTxt.DefaultText = "";
            NutritionValTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            NutritionValTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            NutritionValTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            NutritionValTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            NutritionValTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            NutritionValTxt.Font = new Font("Segoe UI", 14F);
            NutritionValTxt.ForeColor = Color.DimGray;
            NutritionValTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            NutritionValTxt.Location = new Point(44, 201);
            NutritionValTxt.Margin = new Padding(5);
            NutritionValTxt.Name = "NutritionValTxt";
            NutritionValTxt.PasswordChar = '\0';
            NutritionValTxt.PlaceholderText = "Nutritional Value";
            NutritionValTxt.SelectedText = "";
            NutritionValTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            NutritionValTxt.Size = new Size(321, 60);
            NutritionValTxt.TabIndex = 2;
            // 
            // AllergensTxt
            // 
            AllergensTxt.BorderRadius = 10;
            AllergensTxt.CustomizableEdges = customizableEdges7;
            AllergensTxt.DefaultText = "";
            AllergensTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AllergensTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AllergensTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AllergensTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AllergensTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AllergensTxt.Font = new Font("Segoe UI", 14F);
            AllergensTxt.ForeColor = Color.DimGray;
            AllergensTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AllergensTxt.Location = new Point(44, 131);
            AllergensTxt.Margin = new Padding(5);
            AllergensTxt.Name = "AllergensTxt";
            AllergensTxt.PasswordChar = '\0';
            AllergensTxt.PlaceholderText = "Allergens";
            AllergensTxt.SelectedText = "";
            AllergensTxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AllergensTxt.Size = new Size(321, 60);
            AllergensTxt.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges9;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(44, 59);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtName.Size = new Size(321, 62);
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
            btnAddMeal.Click += btnAddMeal_Click;
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
            // DName
            // 
            DName.BorderRadius = 10;
            DName.CustomizableEdges = customizableEdges1;
            DName.DefaultText = "";
            DName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DName.Font = new Font("Segoe UI", 14F);
            DName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DName.Location = new Point(149, 129);
            DName.Margin = new Padding(5);
            DName.Name = "DName";
            DName.PasswordChar = '\0';
            DName.PlaceholderText = "Name";
            DName.SelectedText = "";
            DName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DName.Size = new Size(234, 51);
            DName.TabIndex = 3;
            // 
            // createDietPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 631);
            Controls.Add(panel1);
            Name = "createDietPlan";
            Text = "Create Diet Plan";
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
        private Button addButton;
        private ComboBox ListNutrition;
        private ComboBox listType;
        private ComboBox listGoals;
        private Guna.UI2.WinForms.Guna2TextBox NutritionValTxt;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox comboAddedMeals;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox DName;
    }
}