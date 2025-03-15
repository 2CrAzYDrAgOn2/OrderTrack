namespace OrderTrack
{
    partial class AddFormOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormOrderDetails));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelOrderIDOrderDetails = new Label();
            textBoxOrderIDOrderDetails = new TextBox();
            labelNameOrderDetails = new Label();
            textBoxNameIDOrderDetails = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(242, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 4;
            label1.Text = "Позиция заказа";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(329, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelOrderIDOrderDetails
            // 
            labelOrderIDOrderDetails.AutoSize = true;
            labelOrderIDOrderDetails.BackColor = Color.Transparent;
            labelOrderIDOrderDetails.ForeColor = Color.WhiteSmoke;
            labelOrderIDOrderDetails.Location = new Point(195, 500);
            labelOrderIDOrderDetails.Margin = new Padding(4, 0, 4, 0);
            labelOrderIDOrderDetails.Name = "labelOrderIDOrderDetails";
            labelOrderIDOrderDetails.Size = new Size(85, 15);
            labelOrderIDOrderDetails.TabIndex = 5;
            labelOrderIDOrderDetails.Text = "Номер заказа:";
            // 
            // textBoxOrderIDOrderDetails
            // 
            textBoxOrderIDOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOrderIDOrderDetails.Location = new Point(291, 489);
            textBoxOrderIDOrderDetails.Margin = new Padding(4, 3, 4, 3);
            textBoxOrderIDOrderDetails.Name = "textBoxOrderIDOrderDetails";
            textBoxOrderIDOrderDetails.Size = new Size(455, 33);
            textBoxOrderIDOrderDetails.TabIndex = 0;
            // 
            // labelNameOrderDetails
            // 
            labelNameOrderDetails.AutoSize = true;
            labelNameOrderDetails.BackColor = Color.Transparent;
            labelNameOrderDetails.ForeColor = Color.WhiteSmoke;
            labelNameOrderDetails.Location = new Point(139, 545);
            labelNameOrderDetails.Margin = new Padding(4, 0, 4, 0);
            labelNameOrderDetails.Name = "labelNameOrderDetails";
            labelNameOrderDetails.Size = new Size(146, 15);
            labelNameOrderDetails.TabIndex = 6;
            labelNameOrderDetails.Text = "Наименование продукта:";
            // 
            // textBoxNameIDOrderDetails
            // 
            textBoxNameIDOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNameIDOrderDetails.Location = new Point(291, 534);
            textBoxNameIDOrderDetails.Margin = new Padding(4, 3, 4, 3);
            textBoxNameIDOrderDetails.Name = "textBoxNameIDOrderDetails";
            textBoxNameIDOrderDetails.Size = new Size(455, 33);
            textBoxNameIDOrderDetails.TabIndex = 1;
            // 
            // AddFormOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelOrderIDOrderDetails);
            Controls.Add(textBoxOrderIDOrderDetails);
            Controls.Add(labelNameOrderDetails);
            Controls.Add(textBoxNameIDOrderDetails);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormOrderDetails";
            Text = "Добавить позицию заказа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelOrderIDOrderDetails;
        private TextBox textBoxOrderIDOrderDetails;
        private Label labelNameOrderDetails;
        private TextBox textBoxNameIDOrderDetails;
    }
}