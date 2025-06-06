﻿namespace OrderTrack
{
    partial class AddFormOrderMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormOrderMaterials));
            panel2 = new Panel();
            labelFullNameClients = new Label();
            dateTimePickerRequestDate = new DateTimePicker();
            label2 = new Label();
            comboBoxMaterialIDOrderMaterials = new ComboBox();
            label3 = new Label();
            textBoxQuantinityOrderMaterials = new TextBox();
            buttonSave = new Button();
            labelTitle = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(201, 201, 209);
            panel2.Controls.Add(labelFullNameClients);
            panel2.Controls.Add(dateTimePickerRequestDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxMaterialIDOrderMaterials);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxQuantinityOrderMaterials);
            panel2.Controls.Add(buttonSave);
            panel2.Location = new Point(-1, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 523);
            panel2.TabIndex = 0;
            // 
            // labelFullNameClients
            // 
            labelFullNameClients.AutoSize = true;
            labelFullNameClients.BackColor = Color.Transparent;
            labelFullNameClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFullNameClients.ForeColor = Color.FromArgb(97, 97, 97);
            labelFullNameClients.Location = new Point(325, 18);
            labelFullNameClients.Margin = new Padding(4, 0, 4, 0);
            labelFullNameClients.Name = "labelFullNameClients";
            labelFullNameClients.Size = new Size(130, 25);
            labelFullNameClients.TabIndex = 4;
            labelFullNameClients.Text = "Дата заявки:";
            // 
            // dateTimePickerRequestDate
            // 
            dateTimePickerRequestDate.Enabled = false;
            dateTimePickerRequestDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerRequestDate.Location = new Point(151, 46);
            dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            dateTimePickerRequestDate.Size = new Size(455, 33);
            dateTimePickerRequestDate.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(97, 97, 97);
            label2.Location = new Point(260, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 25);
            label2.TabIndex = 5;
            label2.Text = "Наименование материала:";
            // 
            // comboBoxMaterialIDOrderMaterials
            // 
            comboBoxMaterialIDOrderMaterials.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterialIDOrderMaterials.Font = new Font("Segoe UI", 14.25F);
            comboBoxMaterialIDOrderMaterials.FormattingEnabled = true;
            comboBoxMaterialIDOrderMaterials.Location = new Point(151, 110);
            comboBoxMaterialIDOrderMaterials.Name = "comboBoxMaterialIDOrderMaterials";
            comboBoxMaterialIDOrderMaterials.Size = new Size(455, 33);
            comboBoxMaterialIDOrderMaterials.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(97, 97, 97);
            label3.Location = new Point(325, 146);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 6;
            label3.Text = "Количество:";
            // 
            // textBoxQuantinityOrderMaterials
            // 
            textBoxQuantinityOrderMaterials.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxQuantinityOrderMaterials.Location = new Point(151, 174);
            textBoxQuantinityOrderMaterials.Margin = new Padding(4, 3, 4, 3);
            textBoxQuantinityOrderMaterials.Name = "textBoxQuantinityOrderMaterials";
            textBoxQuantinityOrderMaterials.Size = new Size(455, 33);
            textBoxQuantinityOrderMaterials.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(260, 224);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
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
            label1.Location = new Point(286, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 8;
            label1.Text = "Заявка на материал";
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
            // AddFormOrderMaterials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 369);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "AddFormOrderMaterials";
            Text = "Добавить заявку на материал";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label labelFullNameClients;
        private Button buttonSave;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dateTimePickerRequestDate;
        private Label label2;
        private ComboBox comboBoxMaterialIDOrderMaterials;
        private Label label3;
        private TextBox textBoxQuantinityOrderMaterials;
    }
}