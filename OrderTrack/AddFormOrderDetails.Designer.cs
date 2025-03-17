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
            labelProductIDOrderDetails = new Label();
            textBoxProductIDOrderDetails = new TextBox();
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
            labelTitle.Location = new Point(260, 20);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(223, 32);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(292, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 4;
            label1.Text = "Позиция заказа";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(246, 276);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelOrderIDOrderDetails
            // 
            labelOrderIDOrderDetails.AutoSize = true;
            labelOrderIDOrderDetails.BackColor = Color.Transparent;
            labelOrderIDOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelOrderIDOrderDetails.ForeColor = Color.FromArgb(97, 97, 97);
            labelOrderIDOrderDetails.Location = new Point(296, 115);
            labelOrderIDOrderDetails.Margin = new Padding(4, 0, 4, 0);
            labelOrderIDOrderDetails.Name = "labelOrderIDOrderDetails";
            labelOrderIDOrderDetails.Size = new Size(145, 25);
            labelOrderIDOrderDetails.TabIndex = 5;
            labelOrderIDOrderDetails.Text = "Номер заказа:";
            // 
            // textBoxOrderIDOrderDetails
            // 
            textBoxOrderIDOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOrderIDOrderDetails.Location = new Point(178, 143);
            textBoxOrderIDOrderDetails.Margin = new Padding(4, 3, 4, 3);
            textBoxOrderIDOrderDetails.Name = "textBoxOrderIDOrderDetails";
            textBoxOrderIDOrderDetails.Size = new Size(369, 33);
            textBoxOrderIDOrderDetails.TabIndex = 0;
            // 
            // labelProductIDOrderDetails
            // 
            labelProductIDOrderDetails.AutoSize = true;
            labelProductIDOrderDetails.BackColor = Color.Transparent;
            labelProductIDOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelProductIDOrderDetails.ForeColor = Color.FromArgb(97, 97, 97);
            labelProductIDOrderDetails.Location = new Point(314, 186);
            labelProductIDOrderDetails.Margin = new Padding(4, 0, 4, 0);
            labelProductIDOrderDetails.Name = "labelProductIDOrderDetails";
            labelProductIDOrderDetails.Size = new Size(103, 25);
            labelProductIDOrderDetails.TabIndex = 6;
            labelProductIDOrderDetails.Text = " Продукт:";
            // 
            // textBoxProductIDOrderDetails
            // 
            textBoxProductIDOrderDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxProductIDOrderDetails.Location = new Point(140, 214);
            textBoxProductIDOrderDetails.Margin = new Padding(4, 3, 4, 3);
            textBoxProductIDOrderDetails.Name = "textBoxProductIDOrderDetails";
            textBoxProductIDOrderDetails.Size = new Size(446, 33);
            textBoxProductIDOrderDetails.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 43, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 100);
            panel1.TabIndex = 18;
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
            // AddFormOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 201, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(735, 347);
            Controls.Add(panel1);
            Controls.Add(labelOrderIDOrderDetails);
            Controls.Add(textBoxOrderIDOrderDetails);
            Controls.Add(labelProductIDOrderDetails);
            Controls.Add(textBoxProductIDOrderDetails);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormOrderDetails";
            Text = "Добавить позицию заказа";
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
        private Label labelOrderIDOrderDetails;
        private TextBox textBoxOrderIDOrderDetails;
        private Label labelProductIDOrderDetails;
        private TextBox textBoxProductIDOrderDetails;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}