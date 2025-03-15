namespace OrderTrack
{
    partial class AddFormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormOrders));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelClientFullNameOrders = new Label();
            textBoxClientFullNameOrders = new TextBox();
            labelEmployeeFullNameOrders = new Label();
            textBoxEmployeeFullNameOrders = new TextBox();
            labelOrderDate = new Label();
            dateTimePickerOrderDate = new DateTimePicker();
            labelStatus = new Label();
            comboBoxStatus = new ComboBox();
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
            labelTitle.TabIndex = 5;
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
            label1.Size = new Size(54, 21);
            label1.TabIndex = 6;
            label1.Text = "Заказ";
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
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelClientFullNameOrders
            // 
            labelClientFullNameOrders.AutoSize = true;
            labelClientFullNameOrders.BackColor = Color.Transparent;
            labelClientFullNameOrders.ForeColor = Color.WhiteSmoke;
            labelClientFullNameOrders.Location = new Point(146, 500);
            labelClientFullNameOrders.Margin = new Padding(4, 0, 4, 0);
            labelClientFullNameOrders.Name = "labelClientFullNameOrders";
            labelClientFullNameOrders.Size = new Size(140, 15);
            labelClientFullNameOrders.TabIndex = 7;
            labelClientFullNameOrders.Text = "Наименование клиента:";
            // 
            // textBoxClientFullNameOrders
            // 
            textBoxClientFullNameOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxClientFullNameOrders.Location = new Point(292, 489);
            textBoxClientFullNameOrders.Margin = new Padding(4, 3, 4, 3);
            textBoxClientFullNameOrders.Name = "textBoxClientFullNameOrders";
            textBoxClientFullNameOrders.Size = new Size(455, 33);
            textBoxClientFullNameOrders.TabIndex = 0;
            // 
            // labelEmployeeFullNameOrders
            // 
            labelEmployeeFullNameOrders.AutoSize = true;
            labelEmployeeFullNameOrders.BackColor = Color.Transparent;
            labelEmployeeFullNameOrders.ForeColor = Color.WhiteSmoke;
            labelEmployeeFullNameOrders.Location = new Point(176, 545);
            labelEmployeeFullNameOrders.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeFullNameOrders.Name = "labelEmployeeFullNameOrders";
            labelEmployeeFullNameOrders.Size = new Size(105, 15);
            labelEmployeeFullNameOrders.TabIndex = 8;
            labelEmployeeFullNameOrders.Text = "ФИО Сотрудника:";
            // 
            // textBoxEmployeeFullNameOrders
            // 
            textBoxEmployeeFullNameOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeFullNameOrders.Location = new Point(292, 534);
            textBoxEmployeeFullNameOrders.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeFullNameOrders.Name = "textBoxEmployeeFullNameOrders";
            textBoxEmployeeFullNameOrders.Size = new Size(455, 33);
            textBoxEmployeeFullNameOrders.TabIndex = 1;
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.BackColor = Color.Transparent;
            labelOrderDate.ForeColor = Color.WhiteSmoke;
            labelOrderDate.Location = new Point(209, 593);
            labelOrderDate.Margin = new Padding(4, 0, 4, 0);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(72, 15);
            labelOrderDate.TabIndex = 9;
            labelOrderDate.Text = "Дата заказа:";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerOrderDate.Location = new Point(292, 579);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(455, 33);
            dateTimePickerOrderDate.TabIndex = 2;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.ForeColor = Color.WhiteSmoke;
            labelStatus.Location = new Point(235, 644);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(46, 15);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Segoe UI", 14.25F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "В обработке", "Подтвержден", "Отменен", "Выполнен" });
            comboBoxStatus.Location = new Point(292, 633);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(455, 33);
            comboBoxStatus.TabIndex = 3;
            // 
            // AddFormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelClientFullNameOrders);
            Controls.Add(textBoxClientFullNameOrders);
            Controls.Add(labelEmployeeFullNameOrders);
            Controls.Add(textBoxEmployeeFullNameOrders);
            Controls.Add(labelOrderDate);
            Controls.Add(dateTimePickerOrderDate);
            Controls.Add(labelStatus);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormOrders";
            Text = "Добавить заказ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelClientFullNameOrders;
        private TextBox textBoxClientFullNameOrders;
        private Label labelEmployeeFullNameOrders;
        private TextBox textBoxEmployeeFullNameOrders;
        private Label labelOrderDate;
        private DateTimePicker dateTimePickerOrderDate;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
    }
}