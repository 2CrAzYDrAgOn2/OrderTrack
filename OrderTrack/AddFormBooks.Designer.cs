namespace OrderTrack
{
    partial class AddFormBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormBooks));
            buttonSave = new Button();
            labelTitle = new Label();
            label1 = new Label();
            labelTitleBooks = new Label();
            textBoxTitleBooks = new TextBox();
            labelAuthorBooks = new Label();
            textBoxAuthorBooks = new TextBox();
            labelGenreBooks = new Label();
            textBoxGenreBooks = new TextBox();
            labelPublishedYearBooks = new Label();
            textBoxPublishedYearBooks = new TextBox();
            labelISBNBooks = new Label();
            textBoxISBNBooks = new TextBox();
            labelCopiesAvailableBooks = new Label();
            textBoxCopiesAvailableBooks = new TextBox();
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
            label1.Size = new Size(56, 21);
            label1.TabIndex = 8;
            label1.Text = "Книга";
            // 
            // labelTitleBooks
            // 
            labelTitleBooks.AutoSize = true;
            labelTitleBooks.BackColor = Color.Transparent;
            labelTitleBooks.ForeColor = Color.Black;
            labelTitleBooks.Location = new Point(213, 459);
            labelTitleBooks.Margin = new Padding(4, 0, 4, 0);
            labelTitleBooks.Name = "labelTitleBooks";
            labelTitleBooks.Size = new Size(68, 15);
            labelTitleBooks.TabIndex = 9;
            labelTitleBooks.Text = "Заголовок:";
            // 
            // textBoxTitleBooks
            // 
            textBoxTitleBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTitleBooks.Location = new Point(292, 448);
            textBoxTitleBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxTitleBooks.Name = "textBoxTitleBooks";
            textBoxTitleBooks.Size = new Size(455, 33);
            textBoxTitleBooks.TabIndex = 0;
            // 
            // labelAuthorBooks
            // 
            labelAuthorBooks.AutoSize = true;
            labelAuthorBooks.BackColor = Color.Transparent;
            labelAuthorBooks.ForeColor = Color.Black;
            labelAuthorBooks.Location = new Point(238, 504);
            labelAuthorBooks.Margin = new Padding(4, 0, 4, 0);
            labelAuthorBooks.Name = "labelAuthorBooks";
            labelAuthorBooks.Size = new Size(43, 15);
            labelAuthorBooks.TabIndex = 10;
            labelAuthorBooks.Text = "Автор:";
            // 
            // textBoxAuthorBooks
            // 
            textBoxAuthorBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAuthorBooks.Location = new Point(292, 493);
            textBoxAuthorBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxAuthorBooks.Name = "textBoxAuthorBooks";
            textBoxAuthorBooks.Size = new Size(455, 33);
            textBoxAuthorBooks.TabIndex = 1;
            // 
            // labelGenreBooks
            // 
            labelGenreBooks.AutoSize = true;
            labelGenreBooks.BackColor = Color.Transparent;
            labelGenreBooks.ForeColor = Color.Black;
            labelGenreBooks.Location = new Point(240, 552);
            labelGenreBooks.Margin = new Padding(4, 0, 4, 0);
            labelGenreBooks.Name = "labelGenreBooks";
            labelGenreBooks.Size = new Size(41, 15);
            labelGenreBooks.TabIndex = 11;
            labelGenreBooks.Text = "Жанр:";
            // 
            // textBoxGenreBooks
            // 
            textBoxGenreBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGenreBooks.Location = new Point(292, 541);
            textBoxGenreBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxGenreBooks.Name = "textBoxGenreBooks";
            textBoxGenreBooks.Size = new Size(455, 33);
            textBoxGenreBooks.TabIndex = 2;
            // 
            // labelPublishedYearBooks
            // 
            labelPublishedYearBooks.AutoSize = true;
            labelPublishedYearBooks.BackColor = Color.Transparent;
            labelPublishedYearBooks.ForeColor = Color.Black;
            labelPublishedYearBooks.Location = new Point(203, 594);
            labelPublishedYearBooks.Margin = new Padding(4, 0, 4, 0);
            labelPublishedYearBooks.Name = "labelPublishedYearBooks";
            labelPublishedYearBooks.Size = new Size(78, 15);
            labelPublishedYearBooks.TabIndex = 12;
            labelPublishedYearBooks.Text = "Год выпуска:";
            // 
            // textBoxPublishedYearBooks
            // 
            textBoxPublishedYearBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPublishedYearBooks.Location = new Point(292, 583);
            textBoxPublishedYearBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxPublishedYearBooks.Name = "textBoxPublishedYearBooks";
            textBoxPublishedYearBooks.Size = new Size(455, 33);
            textBoxPublishedYearBooks.TabIndex = 3;
            // 
            // labelISBNBooks
            // 
            labelISBNBooks.AutoSize = true;
            labelISBNBooks.BackColor = Color.Transparent;
            labelISBNBooks.ForeColor = Color.Black;
            labelISBNBooks.Location = new Point(246, 639);
            labelISBNBooks.Margin = new Padding(4, 0, 4, 0);
            labelISBNBooks.Name = "labelISBNBooks";
            labelISBNBooks.Size = new Size(35, 15);
            labelISBNBooks.TabIndex = 13;
            labelISBNBooks.Text = "ISBN:";
            // 
            // textBoxISBNBooks
            // 
            textBoxISBNBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxISBNBooks.Location = new Point(292, 628);
            textBoxISBNBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxISBNBooks.Name = "textBoxISBNBooks";
            textBoxISBNBooks.Size = new Size(455, 33);
            textBoxISBNBooks.TabIndex = 4;
            // 
            // labelCopiesAvailableBooks
            // 
            labelCopiesAvailableBooks.AutoSize = true;
            labelCopiesAvailableBooks.BackColor = Color.Transparent;
            labelCopiesAvailableBooks.ForeColor = Color.Black;
            labelCopiesAvailableBooks.Location = new Point(181, 684);
            labelCopiesAvailableBooks.Margin = new Padding(4, 0, 4, 0);
            labelCopiesAvailableBooks.Name = "labelCopiesAvailableBooks";
            labelCopiesAvailableBooks.Size = new Size(100, 15);
            labelCopiesAvailableBooks.TabIndex = 14;
            labelCopiesAvailableBooks.Text = "Доступно копий:";
            // 
            // textBoxCopiesAvailableBooks
            // 
            textBoxCopiesAvailableBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCopiesAvailableBooks.Location = new Point(292, 673);
            textBoxCopiesAvailableBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxCopiesAvailableBooks.Name = "textBoxCopiesAvailableBooks";
            textBoxCopiesAvailableBooks.Size = new Size(455, 33);
            textBoxCopiesAvailableBooks.TabIndex = 5;
            // 
            // AddFormBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelTitleBooks);
            Controls.Add(textBoxTitleBooks);
            Controls.Add(labelAuthorBooks);
            Controls.Add(textBoxAuthorBooks);
            Controls.Add(labelGenreBooks);
            Controls.Add(textBoxGenreBooks);
            Controls.Add(labelPublishedYearBooks);
            Controls.Add(textBoxPublishedYearBooks);
            Controls.Add(labelISBNBooks);
            Controls.Add(textBoxISBNBooks);
            Controls.Add(labelCopiesAvailableBooks);
            Controls.Add(textBoxCopiesAvailableBooks);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormBooks";
            Text = "Добавить книгу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private Label labelTitleBooks;
        private TextBox textBoxTitleBooks;
        private Label labelAuthorBooks;
        private TextBox textBoxAuthorBooks;
        private Label labelGenreBooks;
        private TextBox textBoxGenreBooks;
        private Label labelPublishedYearBooks;
        private TextBox textBoxPublishedYearBooks;
        private Label labelISBNBooks;
        private TextBox textBoxISBNBooks;
        private Label labelCopiesAvailableBooks;
        private TextBox textBoxCopiesAvailableBooks;
    }
}