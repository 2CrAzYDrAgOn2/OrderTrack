namespace OrderTrack
{
    partial class AddFormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormProducts));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelName = new Label();
            textBoxName = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
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
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(314, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 5;
            label1.Text = "Продукт";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(243, 338);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelName.ForeColor = Color.FromArgb(97, 97, 97);
            labelName.Location = new Point(310, 113);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(98, 25);
            labelName.TabIndex = 6;
            labelName.Text = "Продукт:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(134, 141);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(455, 33);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = Color.Transparent;
            labelDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelDescription.ForeColor = Color.FromArgb(97, 97, 97);
            labelDescription.Location = new Point(310, 184);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(108, 25);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Описание:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDescription.Location = new Point(134, 212);
            textBoxDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(455, 33);
            textBoxDescription.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelPrice.ForeColor = Color.FromArgb(97, 97, 97);
            labelPrice.Location = new Point(331, 252);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(65, 25);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Цена:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(134, 280);
            textBoxPrice.Margin = new Padding(4, 3, 4, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(455, 33);
            textBoxPrice.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 43, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 100);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(61, 43, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // AddFormProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 201, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(722, 408);
            Controls.Add(panel1);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormProducts";
            Text = "Добавить продукт";
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
        private Label labelName;
        private TextBox textBoxName;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}