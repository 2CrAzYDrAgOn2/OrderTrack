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
            maskedTextBoxPhoneEmployees = new MaskedTextBox();
            labelEmailEmployees = new Label();
            textBoxEmailEmployees = new TextBox();
            labelGenderID = new Label();
            comboBoxGenderID = new ComboBox();
            labelPostID = new Label();
            comboBoxPostID = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(260, 20);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(223, 32);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(316, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 7;
            label1.Text = "Сотрудник";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(261, 499);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelFullNameEmployees
            // 
            labelFullNameEmployees.AutoSize = true;
            labelFullNameEmployees.BackColor = Color.Transparent;
            labelFullNameEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFullNameEmployees.ForeColor = Color.FromArgb(97, 97, 97);
            labelFullNameEmployees.Location = new Point(344, 121);
            labelFullNameEmployees.Margin = new Padding(4, 0, 4, 0);
            labelFullNameEmployees.Name = "labelFullNameEmployees";
            labelFullNameEmployees.Size = new Size(62, 25);
            labelFullNameEmployees.TabIndex = 8;
            labelFullNameEmployees.Text = "ФИО:";
            // 
            // textBoxFullNameEmployees
            // 
            textBoxFullNameEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFullNameEmployees.Location = new Point(139, 149);
            textBoxFullNameEmployees.Margin = new Padding(4, 3, 4, 3);
            textBoxFullNameEmployees.Name = "textBoxFullNameEmployees";
            textBoxFullNameEmployees.Size = new Size(455, 33);
            textBoxFullNameEmployees.TabIndex = 0;
            // 
            // labelPhoneEmployees
            // 
            labelPhoneEmployees.AutoSize = true;
            labelPhoneEmployees.BackColor = Color.Transparent;
            labelPhoneEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelPhoneEmployees.ForeColor = Color.FromArgb(97, 97, 97);
            labelPhoneEmployees.Location = new Point(328, 193);
            labelPhoneEmployees.Margin = new Padding(4, 0, 4, 0);
            labelPhoneEmployees.Name = "labelPhoneEmployees";
            labelPhoneEmployees.Size = new Size(96, 25);
            labelPhoneEmployees.TabIndex = 9;
            labelPhoneEmployees.Text = "Телефон:";
            // 
            // maskedTextBoxPhoneEmployees
            // 
            maskedTextBoxPhoneEmployees.Font = new Font("Segoe UI", 14.25F);
            maskedTextBoxPhoneEmployees.Location = new Point(209, 221);
            maskedTextBoxPhoneEmployees.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhoneEmployees.Name = "maskedTextBoxPhoneEmployees";
            maskedTextBoxPhoneEmployees.Size = new Size(325, 33);
            maskedTextBoxPhoneEmployees.TabIndex = 1;
            // 
            // labelEmailEmployees
            // 
            labelEmailEmployees.AutoSize = true;
            labelEmailEmployees.BackColor = Color.Transparent;
            labelEmailEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEmailEmployees.ForeColor = Color.FromArgb(97, 97, 97);
            labelEmailEmployees.Location = new Point(277, 266);
            labelEmailEmployees.Margin = new Padding(4, 0, 4, 0);
            labelEmailEmployees.Name = "labelEmailEmployees";
            labelEmailEmployees.Size = new Size(198, 25);
            labelEmailEmployees.TabIndex = 10;
            labelEmailEmployees.Text = "Электронная почта:";
            // 
            // textBoxEmailEmployees
            // 
            textBoxEmailEmployees.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmailEmployees.Location = new Point(139, 294);
            textBoxEmailEmployees.Margin = new Padding(4, 3, 4, 3);
            textBoxEmailEmployees.Name = "textBoxEmailEmployees";
            textBoxEmailEmployees.Size = new Size(455, 33);
            textBoxEmailEmployees.TabIndex = 2;
            // 
            // labelGenderID
            // 
            labelGenderID.AutoSize = true;
            labelGenderID.BackColor = Color.Transparent;
            labelGenderID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelGenderID.ForeColor = Color.FromArgb(97, 97, 97);
            labelGenderID.Location = new Point(351, 336);
            labelGenderID.Margin = new Padding(4, 0, 4, 0);
            labelGenderID.Name = "labelGenderID";
            labelGenderID.Size = new Size(55, 25);
            labelGenderID.TabIndex = 11;
            labelGenderID.Text = "Пол:";
            // 
            // comboBoxGenderID
            // 
            comboBoxGenderID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenderID.Font = new Font("Segoe UI", 14.25F);
            comboBoxGenderID.FormattingEnabled = true;
            comboBoxGenderID.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxGenderID.Location = new Point(209, 364);
            comboBoxGenderID.Name = "comboBoxGenderID";
            comboBoxGenderID.Size = new Size(325, 33);
            comboBoxGenderID.TabIndex = 3;
            // 
            // labelPostID
            // 
            labelPostID.AutoSize = true;
            labelPostID.BackColor = Color.Transparent;
            labelPostID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelPostID.ForeColor = Color.FromArgb(97, 97, 97);
            labelPostID.Location = new Point(317, 411);
            labelPostID.Margin = new Padding(4, 0, 4, 0);
            labelPostID.Name = "labelPostID";
            labelPostID.Size = new Size(124, 25);
            labelPostID.TabIndex = 12;
            labelPostID.Text = "Должность:";
            // 
            // comboBoxPostID
            // 
            comboBoxPostID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPostID.Font = new Font("Segoe UI", 14.25F);
            comboBoxPostID.FormattingEnabled = true;
            comboBoxPostID.Items.AddRange(new object[] { "Менеджер по продажам", "Администратор" });
            comboBoxPostID.Location = new Point(139, 439);
            comboBoxPostID.Name = "comboBoxPostID";
            comboBoxPostID.Size = new Size(455, 33);
            comboBoxPostID.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(10, 115, 166);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 115, 166);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 100);
            panel1.TabIndex = 17;
            // 
            // AddFormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 201, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 562);
            Controls.Add(panel1);
            Controls.Add(labelFullNameEmployees);
            Controls.Add(textBoxFullNameEmployees);
            Controls.Add(labelPhoneEmployees);
            Controls.Add(maskedTextBoxPhoneEmployees);
            Controls.Add(labelEmailEmployees);
            Controls.Add(textBoxEmailEmployees);
            Controls.Add(labelGenderID);
            Controls.Add(comboBoxGenderID);
            Controls.Add(labelPostID);
            Controls.Add(comboBoxPostID);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormEmployees";
            Text = "Добавить сотрудника";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private MaskedTextBox maskedTextBoxPhoneEmployees;
        private Label labelEmailEmployees;
        private TextBox textBoxEmailEmployees;
        private Label labelGenderID;
        private ComboBox comboBoxGenderID;
        private Label labelPostID;
        private ComboBox comboBoxPostID;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}