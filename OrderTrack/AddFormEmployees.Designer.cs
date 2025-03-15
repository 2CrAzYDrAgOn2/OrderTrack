namespace OrderTrack
{
    partial class AddFormEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormEmployees));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelFullNameEmployees = new Label();
            textBoxFullNameEmployees = new TextBox();
            labelPhoneEmployees = new Label();
            maskedTextBox1 = new MaskedTextBox();
            labelEmailEmployees = new Label();
            textBoxEmailEmployees = new TextBox();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            labelPost = new Label();
            comboBoxPost = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(243, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(244, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 7;
            label1.Text = "Сотрудник";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(330, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelFullNameEmployees
            // 
            labelFullNameEmployees.AutoSize = true;
            labelFullNameEmployees.BackColor = Color.Transparent;
            labelFullNameEmployees.ForeColor = Color.WhiteSmoke;
            labelFullNameEmployees.Location = new Point(244, 500);
            labelFullNameEmployees.Margin = new Padding(4, 0, 4, 0);
            labelFullNameEmployees.Name = "labelFullNameEmployees";
            labelFullNameEmployees.Size = new Size(37, 15);
            labelFullNameEmployees.TabIndex = 8;
            labelFullNameEmployees.Text = "ФИО:";
            // 
            // textBoxFullNameEmployees
            // 
            textBoxFullNameEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFullNameEmployees.Location = new Point(292, 489);
            textBoxFullNameEmployees.Margin = new Padding(4, 3, 4, 3);
            textBoxFullNameEmployees.Name = "textBoxFullNameEmployees";
            textBoxFullNameEmployees.Size = new Size(455, 33);
            textBoxFullNameEmployees.TabIndex = 0;
            // 
            // labelPhoneEmployees
            // 
            labelPhoneEmployees.AutoSize = true;
            labelPhoneEmployees.BackColor = Color.Transparent;
            labelPhoneEmployees.ForeColor = Color.WhiteSmoke;
            labelPhoneEmployees.Location = new Point(223, 545);
            labelPhoneEmployees.Margin = new Padding(4, 0, 4, 0);
            labelPhoneEmployees.Name = "labelPhoneEmployees";
            labelPhoneEmployees.Size = new Size(58, 15);
            labelPhoneEmployees.TabIndex = 9;
            labelPhoneEmployees.Text = "Телефон:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 14.25F);
            maskedTextBox1.Location = new Point(292, 534);
            maskedTextBox1.Mask = "+7 (999) 999-99-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(455, 33);
            maskedTextBox1.TabIndex = 1;
            // 
            // labelEmailEmployees
            // 
            labelEmailEmployees.AutoSize = true;
            labelEmailEmployees.BackColor = Color.Transparent;
            labelEmailEmployees.ForeColor = Color.WhiteSmoke;
            labelEmailEmployees.Location = new Point(237, 593);
            labelEmailEmployees.Margin = new Padding(4, 0, 4, 0);
            labelEmailEmployees.Name = "labelEmailEmployees";
            labelEmailEmployees.Size = new Size(44, 15);
            labelEmailEmployees.TabIndex = 10;
            labelEmailEmployees.Text = "Почта:";
            // 
            // textBoxEmailEmployees
            // 
            textBoxEmailEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmailEmployees.Location = new Point(292, 582);
            textBoxEmailEmployees.Margin = new Padding(4, 3, 4, 3);
            textBoxEmailEmployees.Name = "textBoxEmailEmployees";
            textBoxEmailEmployees.ReadOnly = true;
            textBoxEmailEmployees.Size = new Size(455, 33);
            textBoxEmailEmployees.TabIndex = 2;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.ForeColor = Color.WhiteSmoke;
            labelGender.Location = new Point(248, 638);
            labelGender.Margin = new Padding(4, 0, 4, 0);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(33, 15);
            labelGender.TabIndex = 11;
            labelGender.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 14.25F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxGender.Location = new Point(292, 627);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(455, 33);
            comboBoxGender.TabIndex = 3;
            // 
            // labelPost
            // 
            labelPost.AutoSize = true;
            labelPost.BackColor = Color.Transparent;
            labelPost.ForeColor = Color.WhiteSmoke;
            labelPost.Location = new Point(209, 680);
            labelPost.Margin = new Padding(4, 0, 4, 0);
            labelPost.Name = "labelPost";
            labelPost.Size = new Size(72, 15);
            labelPost.TabIndex = 12;
            labelPost.Text = "Должность:";
            // 
            // comboBoxPost
            // 
            comboBoxPost.Font = new Font("Segoe UI", 14.25F);
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Items.AddRange(new object[] { "Менеджер по продажам", "Администратор" });
            comboBoxPost.Location = new Point(292, 669);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(455, 33);
            comboBoxPost.TabIndex = 4;
            // 
            // AddFormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelFullNameEmployees);
            Controls.Add(textBoxFullNameEmployees);
            Controls.Add(labelPhoneEmployees);
            Controls.Add(maskedTextBox1);
            Controls.Add(labelEmailEmployees);
            Controls.Add(textBoxEmailEmployees);
            Controls.Add(labelGender);
            Controls.Add(comboBoxGender);
            Controls.Add(labelPost);
            Controls.Add(comboBoxPost);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormEmployees";
            Text = "Добавить сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelFullNameEmployees;
        private TextBox textBoxFullNameEmployees;
        private Label labelPhoneEmployees;
        private MaskedTextBox maskedTextBox1;
        private Label labelEmailEmployees;
        private TextBox textBoxEmailEmployees;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private Label labelPost;
        private ComboBox comboBoxPost;
    }
}