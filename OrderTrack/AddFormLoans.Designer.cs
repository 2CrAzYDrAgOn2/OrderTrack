namespace OrderTrack
{
    partial class AddFormLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormLoans));
            buttonSave = new Button();
            labelTitle = new Label();
            label1 = new Label();
            labelRegistrationIDLoans = new Label();
            textBoxRegistrationIDLoans = new TextBox();
            labelBookIDLoans = new Label();
            textBoxBookIDLoans = new TextBox();
            labelLoanDateLoans = new Label();
            dateTimePickerLoanDateLoans = new DateTimePicker();
            labelReturnDateLoans = new Label();
            labelIsReturnedLoans = new Label();
            textBoxIsReturnedLoans = new TextBox();
            dateTimePickerReturnDateLoans = new DateTimePicker();
            checkBoxReturnDateLoans = new CheckBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(330, 763);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(243, 10);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(244, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 8;
            label1.Text = "Выдача";
            // 
            // labelRegistrationIDLoans
            // 
            labelRegistrationIDLoans.AutoSize = true;
            labelRegistrationIDLoans.BackColor = Color.Transparent;
            labelRegistrationIDLoans.ForeColor = Color.WhiteSmoke;
            labelRegistrationIDLoans.Location = new Point(155, 459);
            labelRegistrationIDLoans.Margin = new Padding(4, 0, 4, 0);
            labelRegistrationIDLoans.Name = "labelRegistrationIDLoans";
            labelRegistrationIDLoans.Size = new Size(122, 15);
            labelRegistrationIDLoans.TabIndex = 9;
            labelRegistrationIDLoans.Text = "Логин пользователя:";
            // 
            // textBoxRegistrationIDLoans
            // 
            textBoxRegistrationIDLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRegistrationIDLoans.Location = new Point(292, 448);
            textBoxRegistrationIDLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxRegistrationIDLoans.Name = "textBoxRegistrationIDLoans";
            textBoxRegistrationIDLoans.Size = new Size(455, 33);
            textBoxRegistrationIDLoans.TabIndex = 0;
            // 
            // labelBookIDLoans
            // 
            labelBookIDLoans.AutoSize = true;
            labelBookIDLoans.BackColor = Color.Transparent;
            labelBookIDLoans.ForeColor = Color.WhiteSmoke;
            labelBookIDLoans.Location = new Point(198, 504);
            labelBookIDLoans.Margin = new Padding(4, 0, 4, 0);
            labelBookIDLoans.Name = "labelBookIDLoans";
            labelBookIDLoans.Size = new Size(83, 15);
            labelBookIDLoans.TabIndex = 10;
            labelBookIDLoans.Text = "Номер книги:";
            // 
            // textBoxBookIDLoans
            // 
            textBoxBookIDLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBookIDLoans.Location = new Point(292, 493);
            textBoxBookIDLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxBookIDLoans.Name = "textBoxBookIDLoans";
            textBoxBookIDLoans.Size = new Size(455, 33);
            textBoxBookIDLoans.TabIndex = 1;
            // 
            // labelLoanDateLoans
            // 
            labelLoanDateLoans.AutoSize = true;
            labelLoanDateLoans.BackColor = Color.Transparent;
            labelLoanDateLoans.ForeColor = Color.WhiteSmoke;
            labelLoanDateLoans.Location = new Point(202, 552);
            labelLoanDateLoans.Margin = new Padding(4, 0, 4, 0);
            labelLoanDateLoans.Name = "labelLoanDateLoans";
            labelLoanDateLoans.Size = new Size(79, 15);
            labelLoanDateLoans.TabIndex = 11;
            labelLoanDateLoans.Text = "Дата выдачи:";
            // 
            // dateTimePickerLoanDateLoans
            // 
            dateTimePickerLoanDateLoans.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerLoanDateLoans.Location = new Point(292, 538);
            dateTimePickerLoanDateLoans.Name = "dateTimePickerLoanDateLoans";
            dateTimePickerLoanDateLoans.Size = new Size(455, 33);
            dateTimePickerLoanDateLoans.TabIndex = 2;
            // 
            // labelReturnDateLoans
            // 
            labelReturnDateLoans.AutoSize = true;
            labelReturnDateLoans.BackColor = Color.Transparent;
            labelReturnDateLoans.ForeColor = Color.WhiteSmoke;
            labelReturnDateLoans.Location = new Point(195, 594);
            labelReturnDateLoans.Margin = new Padding(4, 0, 4, 0);
            labelReturnDateLoans.Name = "labelReturnDateLoans";
            labelReturnDateLoans.Size = new Size(86, 15);
            labelReturnDateLoans.TabIndex = 12;
            labelReturnDateLoans.Text = "Дата возврата:";
            // 
            // labelIsReturnedLoans
            // 
            labelIsReturnedLoans.AutoSize = true;
            labelIsReturnedLoans.BackColor = Color.Transparent;
            labelIsReturnedLoans.ForeColor = Color.WhiteSmoke;
            labelIsReturnedLoans.Location = new Point(235, 639);
            labelIsReturnedLoans.Margin = new Padding(4, 0, 4, 0);
            labelIsReturnedLoans.Name = "labelIsReturnedLoans";
            labelIsReturnedLoans.Size = new Size(46, 15);
            labelIsReturnedLoans.TabIndex = 13;
            labelIsReturnedLoans.Text = "Статус:";
            // 
            // textBoxIsReturnedLoans
            // 
            textBoxIsReturnedLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIsReturnedLoans.Location = new Point(292, 628);
            textBoxIsReturnedLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxIsReturnedLoans.Name = "textBoxIsReturnedLoans";
            textBoxIsReturnedLoans.ReadOnly = true;
            textBoxIsReturnedLoans.Size = new Size(455, 33);
            textBoxIsReturnedLoans.TabIndex = 5;
            // 
            // dateTimePickerReturnDateLoans
            // 
            dateTimePickerReturnDateLoans.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerReturnDateLoans.Location = new Point(292, 580);
            dateTimePickerReturnDateLoans.Name = "dateTimePickerReturnDateLoans";
            dateTimePickerReturnDateLoans.Size = new Size(244, 33);
            dateTimePickerReturnDateLoans.TabIndex = 3;
            // 
            // checkBoxReturnDateLoans
            // 
            checkBoxReturnDateLoans.AutoSize = true;
            checkBoxReturnDateLoans.BackColor = Color.Transparent;
            checkBoxReturnDateLoans.Font = new Font("Segoe UI", 14.25F);
            checkBoxReturnDateLoans.ForeColor = Color.WhiteSmoke;
            checkBoxReturnDateLoans.Location = new Point(542, 585);
            checkBoxReturnDateLoans.Name = "checkBoxReturnDateLoans";
            checkBoxReturnDateLoans.Size = new Size(205, 29);
            checkBoxReturnDateLoans.TabIndex = 4;
            checkBoxReturnDateLoans.Text = "Еще не возвращена";
            checkBoxReturnDateLoans.UseVisualStyleBackColor = false;
            checkBoxReturnDateLoans.CheckedChanged += CheckBoxReturnDateLoans_CheckedChanged;
            // 
            // AddFormLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelRegistrationIDLoans);
            Controls.Add(textBoxRegistrationIDLoans);
            Controls.Add(labelBookIDLoans);
            Controls.Add(textBoxBookIDLoans);
            Controls.Add(labelLoanDateLoans);
            Controls.Add(dateTimePickerLoanDateLoans);
            Controls.Add(labelReturnDateLoans);
            Controls.Add(dateTimePickerReturnDateLoans);
            Controls.Add(checkBoxReturnDateLoans);
            Controls.Add(labelIsReturnedLoans);
            Controls.Add(textBoxIsReturnedLoans);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormLoans";
            Text = "Добавить выдачу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private Label labelRegistrationIDLoans;
        private TextBox textBoxRegistrationIDLoans;
        private Label labelBookIDLoans;
        private TextBox textBoxBookIDLoans;
        private Label labelLoanDateLoans;
        private DateTimePicker dateTimePickerLoanDateLoans;
        private Label labelReturnDateLoans;
        private Label labelIsReturnedLoans;
        private TextBox textBoxIsReturnedLoans;
        private DateTimePicker dateTimePickerReturnDateLoans;
        private CheckBox checkBoxReturnDateLoans;
    }
}