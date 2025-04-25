namespace OrderTrack
{
    partial class AddFormOrderEstimates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormOrderEstimates));
            panel2 = new Panel();
            buttonSave = new Button();
            labelTitle = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            dateTimePickerOrderEstimateDate = new DateTimePicker();
            comboBoxOrderIDOrderEstimates = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(201, 201, 209);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePickerOrderEstimateDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxOrderIDOrderEstimates);
            panel2.Controls.Add(buttonSave);
            panel2.Location = new Point(-1, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 523);
            panel2.TabIndex = 20;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(260, 452);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(10, 115, 166);
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(273, 12);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(223, 32);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Создание записи:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(10, 115, 166);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(10, 115, 166);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(344, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 8;
            label1.Text = "Смета";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 115, 166);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 97);
            panel1.TabIndex = 19;
            // 
            // dateTimePickerOrderEstimateDate
            // 
            dateTimePickerOrderEstimateDate.Enabled = false;
            dateTimePickerOrderEstimateDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerOrderEstimateDate.Location = new Point(152, 35);
            dateTimePickerOrderEstimateDate.Name = "dateTimePickerOrderEstimateDate";
            dateTimePickerOrderEstimateDate.Size = new Size(455, 33);
            dateTimePickerOrderEstimateDate.TabIndex = 0;
            // 
            // comboBoxOrderIDOrderEstimates
            // 
            comboBoxOrderIDOrderEstimates.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderIDOrderEstimates.Font = new Font("Segoe UI", 14.25F);
            comboBoxOrderIDOrderEstimates.FormattingEnabled = true;
            comboBoxOrderIDOrderEstimates.Location = new Point(152, 99);
            comboBoxOrderIDOrderEstimates.Name = "comboBoxOrderIDOrderEstimates";
            comboBoxOrderIDOrderEstimates.Size = new Size(455, 33);
            comboBoxOrderIDOrderEstimates.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(97, 97, 97);
            label2.Location = new Point(312, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 3;
            label2.Text = "Дата сметы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(97, 97, 97);
            label3.Location = new Point(302, 71);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 4;
            label3.Text = "Номер заказа:";
            // 
            // AddFormOrderEstimates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 614);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "AddFormOrderEstimates";
            Text = "Добавить смету";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonSave;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerOrderEstimateDate;
        private ComboBox comboBoxOrderIDOrderEstimates;
    }
}