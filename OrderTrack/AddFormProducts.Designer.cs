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
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(244, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(245, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 5;
            label1.Text = "Продукт";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(331, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.ForeColor = Color.WhiteSmoke;
            labelName.Location = new Point(189, 500);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(93, 15);
            labelName.TabIndex = 6;
            labelName.Text = "Наименование:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(293, 489);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(455, 33);
            textBoxName.TabIndex = 0;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = Color.Transparent;
            labelDescription.ForeColor = Color.WhiteSmoke;
            labelDescription.Location = new Point(217, 545);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(65, 15);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Описание:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDescription.Location = new Point(293, 534);
            textBoxDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(455, 33);
            textBoxDescription.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.ForeColor = Color.WhiteSmoke;
            labelPrice.Location = new Point(244, 593);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(38, 15);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Цена:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(293, 582);
            textBoxPrice.Margin = new Padding(4, 3, 4, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(455, 33);
            textBoxPrice.TabIndex = 2;
            // 
            // AddFormProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormProducts";
            Text = "Добавить продукт";
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
    }
}