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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(243, 20);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(223, 32);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(332, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 6;
            label1.Text = "Заказ";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(246, 347);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelClientIDOrders
            // 
            labelClientIDOrders.AutoSize = true;
            labelClientIDOrders.BackColor = Color.Transparent;
            labelClientIDOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelClientIDOrders.ForeColor = Color.FromArgb(97, 97, 97);
            labelClientIDOrders.Location = new Point(244, 121);
            labelClientIDOrders.Margin = new Padding(4, 0, 4, 0);
            labelClientIDOrders.Name = "labelClientIDOrders";
            labelClientIDOrders.Size = new Size(238, 25);
            labelClientIDOrders.TabIndex = 7;
            labelClientIDOrders.Text = "Наименование клиента:";
            // 
            // textBoxClientIDOrders
            // 
            textBoxClientIDOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxClientIDOrders.Location = new Point(141, 149);
            textBoxClientIDOrders.Margin = new Padding(4, 3, 4, 3);
            textBoxClientIDOrders.Name = "textBoxClientIDOrders";
            textBoxClientIDOrders.Size = new Size(455, 33);
            textBoxClientIDOrders.TabIndex = 0;
            // 
            // labelEmployeeIDOrders
            // 
            labelEmployeeIDOrders.AutoSize = true;
            labelEmployeeIDOrders.BackColor = Color.Transparent;
            labelEmployeeIDOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEmployeeIDOrders.ForeColor = Color.FromArgb(97, 97, 97);
            labelEmployeeIDOrders.Location = new Point(284, 190);
            labelEmployeeIDOrders.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeIDOrders.Name = "labelEmployeeIDOrders";
            labelEmployeeIDOrders.Size = new Size(178, 25);
            labelEmployeeIDOrders.TabIndex = 8;
            labelEmployeeIDOrders.Text = "ФИО Сотрудника:";
            // 
            // textBoxEmployeeIDOrders
            // 
            textBoxEmployeeIDOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDOrders.Location = new Point(141, 218);
            textBoxEmployeeIDOrders.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDOrders.Name = "textBoxEmployeeIDOrders";
            textBoxEmployeeIDOrders.Size = new Size(455, 33);
            textBoxEmployeeIDOrders.TabIndex = 1;
            // 
            // labelStatusID
            // 
            labelStatusID.AutoSize = true;
            labelStatusID.BackColor = Color.Transparent;
            labelStatusID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelStatusID.ForeColor = Color.FromArgb(97, 97, 97);
            labelStatusID.Location = new Point(332, 259);
            labelStatusID.Margin = new Padding(4, 0, 4, 0);
            labelStatusID.Name = "labelStatusID";
            labelStatusID.Size = new Size(76, 25);
            labelStatusID.TabIndex = 10;
            labelStatusID.Text = "Статус:";
            // 
            // comboBoxStatusID
            // 
            comboBoxStatusID.Font = new Font("Segoe UI", 14.25F);
            comboBoxStatusID.FormattingEnabled = true;
            comboBoxStatusID.Items.AddRange(new object[] { "В обработке", "Подтвержден", "Отменен", "Выполнен" });
            comboBoxStatusID.Location = new Point(141, 287);
            comboBoxStatusID.Name = "comboBoxStatusID";
            comboBoxStatusID.Size = new Size(455, 33);
            comboBoxStatusID.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 115, 166);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 100);
            panel1.TabIndex = 19;
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
            // AddFormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 201, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(729, 416);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}