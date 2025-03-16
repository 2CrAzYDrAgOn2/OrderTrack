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
            labelClientIDOrders = new Label();
            textBoxClientIDOrders = new TextBox();
            labelEmployeeIDOrders = new Label();
            textBoxEmployeeIDOrders = new TextBox();
            labelStatusID = new Label();
            comboBoxStatusID = new ComboBox();
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
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelClientIDOrders
            // 
            labelClientIDOrders.AutoSize = true;
            labelClientIDOrders.BackColor = Color.Transparent;
            labelClientIDOrders.ForeColor = Color.WhiteSmoke;
            labelClientIDOrders.Location = new Point(146, 500);
            labelClientIDOrders.Margin = new Padding(4, 0, 4, 0);
            labelClientIDOrders.Name = "labelClientIDOrders";
            labelClientIDOrders.Size = new Size(140, 15);
            labelClientIDOrders.TabIndex = 7;
            labelClientIDOrders.Text = "Наименование клиента:";
            // 
            // textBoxClientIDOrders
            // 
            textBoxClientIDOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxClientIDOrders.Location = new Point(292, 489);
            textBoxClientIDOrders.Margin = new Padding(4, 3, 4, 3);
            textBoxClientIDOrders.Name = "textBoxClientIDOrders";
            textBoxClientIDOrders.Size = new Size(455, 33);
            textBoxClientIDOrders.TabIndex = 0;
            // 
            // labelEmployeeIDOrders
            // 
            labelEmployeeIDOrders.AutoSize = true;
            labelEmployeeIDOrders.BackColor = Color.Transparent;
            labelEmployeeIDOrders.ForeColor = Color.WhiteSmoke;
            labelEmployeeIDOrders.Location = new Point(176, 545);
            labelEmployeeIDOrders.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeIDOrders.Name = "labelEmployeeIDOrders";
            labelEmployeeIDOrders.Size = new Size(105, 15);
            labelEmployeeIDOrders.TabIndex = 8;
            labelEmployeeIDOrders.Text = "ФИО Сотрудника:";
            // 
            // textBoxEmployeeIDOrders
            // 
            textBoxEmployeeIDOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDOrders.Location = new Point(292, 534);
            textBoxEmployeeIDOrders.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDOrders.Name = "textBoxEmployeeIDOrders";
            textBoxEmployeeIDOrders.Size = new Size(455, 33);
            textBoxEmployeeIDOrders.TabIndex = 1;
            // 
            // labelStatusID
            // 
            labelStatusID.AutoSize = true;
            labelStatusID.BackColor = Color.Transparent;
            labelStatusID.ForeColor = Color.WhiteSmoke;
            labelStatusID.Location = new Point(235, 590);
            labelStatusID.Margin = new Padding(4, 0, 4, 0);
            labelStatusID.Name = "labelStatusID";
            labelStatusID.Size = new Size(46, 15);
            labelStatusID.TabIndex = 10;
            labelStatusID.Text = "Статус:";
            // 
            // comboBoxStatusID
            // 
            comboBoxStatusID.Font = new Font("Segoe UI", 14.25F);
            comboBoxStatusID.FormattingEnabled = true;
            comboBoxStatusID.Items.AddRange(new object[] { "В обработке", "Подтвержден", "Отменен", "Выполнен" });
            comboBoxStatusID.Location = new Point(292, 579);
            comboBoxStatusID.Name = "comboBoxStatusID";
            comboBoxStatusID.Size = new Size(455, 33);
            comboBoxStatusID.TabIndex = 3;
            // 
            // AddFormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelClientIDOrders);
            Controls.Add(textBoxClientIDOrders);
            Controls.Add(labelEmployeeIDOrders);
            Controls.Add(textBoxEmployeeIDOrders);
            Controls.Add(labelStatusID);
            Controls.Add(comboBoxStatusID);
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
        private Label labelClientIDOrders;
        private TextBox textBoxClientIDOrders;
        private Label labelEmployeeIDOrders;
        private TextBox textBoxEmployeeIDOrders;
        private Label labelStatusID;
        private ComboBox comboBoxStatusID;
    }
}