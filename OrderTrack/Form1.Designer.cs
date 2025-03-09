namespace OrderTrack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPageBooks = new TabPage();
            panelTitleBooks = new Panel();
            labelTitle = new Label();
            buttonClearBooks = new Button();
            buttonRefreshBooks = new Button();
            textBoxSearchBooks = new TextBox();
            dataGridViewBooks = new DataGridView();
            panelRecordBooks = new Panel();
            labelRecordBooks = new Label();
            labelBookID = new Label();
            textBoxBookID = new TextBox();
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
            labelControlBooks = new Label();
            panelControlBooks = new Panel();
            buttonNewBook = new Button();
            buttonDeleteBook = new Button();
            buttonChangeBook = new Button();
            buttonSaveBook = new Button();
            buttonWordBook = new Button();
            buttonExcelBook = new Button();
            buttonTXTBook = new Button();
            tabControl1 = new TabControl();
            tabPageLoans = new TabPage();
            panelTitleLoans = new Panel();
            labelTitleLoans = new Label();
            buttonClearLoans = new Button();
            buttonRefreshLoans = new Button();
            textBoxSearchLoans = new TextBox();
            dataGridViewLoans = new DataGridView();
            panelRecordLoans = new Panel();
            labelRecordLoans = new Label();
            labelLoanID = new Label();
            textBoxLoanID = new TextBox();
            labelRegistrationIDLoans = new Label();
            textBoxRegistrationIDLoans = new TextBox();
            labelBookIDLoans = new Label();
            textBoxBookIDLoans = new TextBox();
            labelLoanDateLoans = new Label();
            dateTimePickerLoanDateLoans = new DateTimePicker();
            labelReturnDateLoans = new Label();
            dateTimePickerReturnDateLoans = new DateTimePicker();
            checkBoxReturnDateLoans = new CheckBox();
            labelIsReturnedLoans = new Label();
            textBoxIsReturnedLoans = new TextBox();
            labelControlLoans = new Label();
            panelControlLoans = new Panel();
            buttonNewLoan = new Button();
            buttonDeleteLoan = new Button();
            buttonChangeLoan = new Button();
            buttonSaveLoan = new Button();
            buttonWordLoan = new Button();
            buttonExcelLoan = new Button();
            buttonTXTLoan = new Button();
            tabPageBooks.SuspendLayout();
            panelTitleBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            panelRecordBooks.SuspendLayout();
            panelControlBooks.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageLoans.SuspendLayout();
            panelTitleLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).BeginInit();
            panelRecordLoans.SuspendLayout();
            panelControlLoans.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageBooks
            // 
            tabPageBooks.BackgroundImage = (Image)resources.GetObject("tabPageBooks.BackgroundImage");
            tabPageBooks.Controls.Add(panelTitleBooks);
            tabPageBooks.Controls.Add(dataGridViewBooks);
            tabPageBooks.Controls.Add(panelRecordBooks);
            tabPageBooks.Controls.Add(labelControlBooks);
            tabPageBooks.Controls.Add(panelControlBooks);
            tabPageBooks.Location = new Point(4, 24);
            tabPageBooks.Margin = new Padding(4, 3, 4, 3);
            tabPageBooks.Name = "tabPageBooks";
            tabPageBooks.Padding = new Padding(4, 3, 4, 3);
            tabPageBooks.Size = new Size(889, 1010);
            tabPageBooks.TabIndex = 0;
            tabPageBooks.Text = "Книги";
            tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // panelTitleBooks
            // 
            panelTitleBooks.Controls.Add(labelTitle);
            panelTitleBooks.Controls.Add(buttonClearBooks);
            panelTitleBooks.Controls.Add(buttonRefreshBooks);
            panelTitleBooks.Controls.Add(textBoxSearchBooks);
            panelTitleBooks.Location = new Point(0, 0);
            panelTitleBooks.Margin = new Padding(4, 3, 4, 3);
            panelTitleBooks.Name = "panelTitleBooks";
            panelTitleBooks.Size = new Size(876, 84);
            panelTitleBooks.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(4, 3);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(158, 65);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Книги";
            // 
            // buttonClearBooks
            // 
            buttonClearBooks.FlatStyle = FlatStyle.Flat;
            buttonClearBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClearBooks.Image = (Image)resources.GetObject("buttonClearBooks.Image");
            buttonClearBooks.Location = new Point(528, 3);
            buttonClearBooks.Margin = new Padding(4, 3, 4, 3);
            buttonClearBooks.Name = "buttonClearBooks";
            buttonClearBooks.Size = new Size(78, 77);
            buttonClearBooks.TabIndex = 0;
            buttonClearBooks.UseVisualStyleBackColor = true;
            buttonClearBooks.Click += ButtonClear_Click;
            // 
            // buttonRefreshBooks
            // 
            buttonRefreshBooks.FlatStyle = FlatStyle.Flat;
            buttonRefreshBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRefreshBooks.Image = (Image)resources.GetObject("buttonRefreshBooks.Image");
            buttonRefreshBooks.Location = new Point(614, 3);
            buttonRefreshBooks.Margin = new Padding(4, 3, 4, 3);
            buttonRefreshBooks.Name = "buttonRefreshBooks";
            buttonRefreshBooks.Size = new Size(78, 77);
            buttonRefreshBooks.TabIndex = 1;
            buttonRefreshBooks.UseVisualStyleBackColor = true;
            buttonRefreshBooks.Click += ButtonRefresh_Click;
            // 
            // textBoxSearchBooks
            // 
            textBoxSearchBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearchBooks.Location = new Point(699, 37);
            textBoxSearchBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxSearchBooks.Name = "textBoxSearchBooks";
            textBoxSearchBooks.Size = new Size(173, 33);
            textBoxSearchBooks.TabIndex = 2;
            textBoxSearchBooks.TextChanged += TextBoxSearchBooks_TextChanged;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(9, 91);
            dataGridViewBooks.Margin = new Padding(4, 3, 4, 3);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersWidth = 62;
            dataGridViewBooks.Size = new Size(867, 352);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellClick += DataGridViewBooks_CellClick;
            // 
            // panelRecordBooks
            // 
            panelRecordBooks.Controls.Add(labelRecordBooks);
            panelRecordBooks.Controls.Add(labelBookID);
            panelRecordBooks.Controls.Add(textBoxBookID);
            panelRecordBooks.Controls.Add(labelTitleBooks);
            panelRecordBooks.Controls.Add(textBoxTitleBooks);
            panelRecordBooks.Controls.Add(labelAuthorBooks);
            panelRecordBooks.Controls.Add(textBoxAuthorBooks);
            panelRecordBooks.Controls.Add(labelGenreBooks);
            panelRecordBooks.Controls.Add(textBoxGenreBooks);
            panelRecordBooks.Controls.Add(labelPublishedYearBooks);
            panelRecordBooks.Controls.Add(textBoxPublishedYearBooks);
            panelRecordBooks.Controls.Add(labelISBNBooks);
            panelRecordBooks.Controls.Add(textBoxISBNBooks);
            panelRecordBooks.Controls.Add(labelCopiesAvailableBooks);
            panelRecordBooks.Controls.Add(textBoxCopiesAvailableBooks);
            panelRecordBooks.Location = new Point(9, 450);
            panelRecordBooks.Margin = new Padding(4, 3, 4, 3);
            panelRecordBooks.Name = "panelRecordBooks";
            panelRecordBooks.Size = new Size(611, 552);
            panelRecordBooks.TabIndex = 1;
            // 
            // labelRecordBooks
            // 
            labelRecordBooks.AutoSize = true;
            labelRecordBooks.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRecordBooks.ForeColor = Color.WhiteSmoke;
            labelRecordBooks.Location = new Point(4, 10);
            labelRecordBooks.Margin = new Padding(4, 0, 4, 0);
            labelRecordBooks.Name = "labelRecordBooks";
            labelRecordBooks.Size = new Size(142, 47);
            labelRecordBooks.TabIndex = 7;
            labelRecordBooks.Text = "Запись:";
            // 
            // labelBookID
            // 
            labelBookID.AutoSize = true;
            labelBookID.ForeColor = Color.WhiteSmoke;
            labelBookID.Location = new Point(93, 82);
            labelBookID.Margin = new Padding(4, 0, 4, 0);
            labelBookID.Name = "labelBookID";
            labelBookID.Size = new Size(48, 15);
            labelBookID.TabIndex = 8;
            labelBookID.Text = "Номер:";
            // 
            // textBoxBookID
            // 
            textBoxBookID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBookID.Location = new Point(152, 68);
            textBoxBookID.Margin = new Padding(4, 3, 4, 3);
            textBoxBookID.Name = "textBoxBookID";
            textBoxBookID.Size = new Size(455, 33);
            textBoxBookID.TabIndex = 0;
            // 
            // labelTitleBooks
            // 
            labelTitleBooks.AutoSize = true;
            labelTitleBooks.ForeColor = Color.WhiteSmoke;
            labelTitleBooks.Location = new Point(73, 124);
            labelTitleBooks.Margin = new Padding(4, 0, 4, 0);
            labelTitleBooks.Name = "labelTitleBooks";
            labelTitleBooks.Size = new Size(68, 15);
            labelTitleBooks.TabIndex = 9;
            labelTitleBooks.Text = "Заголовок:";
            // 
            // textBoxTitleBooks
            // 
            textBoxTitleBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTitleBooks.Location = new Point(152, 113);
            textBoxTitleBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxTitleBooks.Name = "textBoxTitleBooks";
            textBoxTitleBooks.Size = new Size(455, 33);
            textBoxTitleBooks.TabIndex = 1;
            // 
            // labelAuthorBooks
            // 
            labelAuthorBooks.AutoSize = true;
            labelAuthorBooks.ForeColor = Color.WhiteSmoke;
            labelAuthorBooks.Location = new Point(98, 169);
            labelAuthorBooks.Margin = new Padding(4, 0, 4, 0);
            labelAuthorBooks.Name = "labelAuthorBooks";
            labelAuthorBooks.Size = new Size(43, 15);
            labelAuthorBooks.TabIndex = 10;
            labelAuthorBooks.Text = "Автор:";
            // 
            // textBoxAuthorBooks
            // 
            textBoxAuthorBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAuthorBooks.Location = new Point(152, 158);
            textBoxAuthorBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxAuthorBooks.Name = "textBoxAuthorBooks";
            textBoxAuthorBooks.Size = new Size(455, 33);
            textBoxAuthorBooks.TabIndex = 2;
            // 
            // labelGenreBooks
            // 
            labelGenreBooks.AutoSize = true;
            labelGenreBooks.ForeColor = Color.WhiteSmoke;
            labelGenreBooks.Location = new Point(100, 217);
            labelGenreBooks.Margin = new Padding(4, 0, 4, 0);
            labelGenreBooks.Name = "labelGenreBooks";
            labelGenreBooks.Size = new Size(41, 15);
            labelGenreBooks.TabIndex = 11;
            labelGenreBooks.Text = "Жанр:";
            // 
            // textBoxGenreBooks
            // 
            textBoxGenreBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGenreBooks.Location = new Point(152, 206);
            textBoxGenreBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxGenreBooks.Name = "textBoxGenreBooks";
            textBoxGenreBooks.Size = new Size(455, 33);
            textBoxGenreBooks.TabIndex = 3;
            // 
            // labelPublishedYearBooks
            // 
            labelPublishedYearBooks.AutoSize = true;
            labelPublishedYearBooks.ForeColor = Color.WhiteSmoke;
            labelPublishedYearBooks.Location = new Point(63, 259);
            labelPublishedYearBooks.Margin = new Padding(4, 0, 4, 0);
            labelPublishedYearBooks.Name = "labelPublishedYearBooks";
            labelPublishedYearBooks.Size = new Size(78, 15);
            labelPublishedYearBooks.TabIndex = 12;
            labelPublishedYearBooks.Text = "Год выпуска:";
            // 
            // textBoxPublishedYearBooks
            // 
            textBoxPublishedYearBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPublishedYearBooks.Location = new Point(152, 248);
            textBoxPublishedYearBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxPublishedYearBooks.Name = "textBoxPublishedYearBooks";
            textBoxPublishedYearBooks.Size = new Size(455, 33);
            textBoxPublishedYearBooks.TabIndex = 4;
            // 
            // labelISBNBooks
            // 
            labelISBNBooks.AutoSize = true;
            labelISBNBooks.ForeColor = Color.WhiteSmoke;
            labelISBNBooks.Location = new Point(106, 304);
            labelISBNBooks.Margin = new Padding(4, 0, 4, 0);
            labelISBNBooks.Name = "labelISBNBooks";
            labelISBNBooks.Size = new Size(35, 15);
            labelISBNBooks.TabIndex = 13;
            labelISBNBooks.Text = "ISBN:";
            // 
            // textBoxISBNBooks
            // 
            textBoxISBNBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxISBNBooks.Location = new Point(152, 293);
            textBoxISBNBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxISBNBooks.Name = "textBoxISBNBooks";
            textBoxISBNBooks.Size = new Size(455, 33);
            textBoxISBNBooks.TabIndex = 5;
            // 
            // labelCopiesAvailableBooks
            // 
            labelCopiesAvailableBooks.AutoSize = true;
            labelCopiesAvailableBooks.ForeColor = Color.WhiteSmoke;
            labelCopiesAvailableBooks.Location = new Point(41, 349);
            labelCopiesAvailableBooks.Margin = new Padding(4, 0, 4, 0);
            labelCopiesAvailableBooks.Name = "labelCopiesAvailableBooks";
            labelCopiesAvailableBooks.Size = new Size(100, 15);
            labelCopiesAvailableBooks.TabIndex = 14;
            labelCopiesAvailableBooks.Text = "Доступно копий:";
            // 
            // textBoxCopiesAvailableBooks
            // 
            textBoxCopiesAvailableBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCopiesAvailableBooks.Location = new Point(152, 338);
            textBoxCopiesAvailableBooks.Margin = new Padding(4, 3, 4, 3);
            textBoxCopiesAvailableBooks.Name = "textBoxCopiesAvailableBooks";
            textBoxCopiesAvailableBooks.Size = new Size(455, 33);
            textBoxCopiesAvailableBooks.TabIndex = 6;
            // 
            // labelControlBooks
            // 
            labelControlBooks.AutoSize = true;
            labelControlBooks.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelControlBooks.ForeColor = Color.WhiteSmoke;
            labelControlBooks.Location = new Point(628, 450);
            labelControlBooks.Margin = new Padding(4, 0, 4, 0);
            labelControlBooks.Name = "labelControlBooks";
            labelControlBooks.Size = new Size(213, 25);
            labelControlBooks.TabIndex = 4;
            labelControlBooks.Text = "Управление записями:";
            // 
            // panelControlBooks
            // 
            panelControlBooks.Controls.Add(buttonNewBook);
            panelControlBooks.Controls.Add(buttonDeleteBook);
            panelControlBooks.Controls.Add(buttonChangeBook);
            panelControlBooks.Controls.Add(buttonSaveBook);
            panelControlBooks.Controls.Add(buttonWordBook);
            panelControlBooks.Controls.Add(buttonExcelBook);
            panelControlBooks.Controls.Add(buttonTXTBook);
            panelControlBooks.Location = new Point(634, 482);
            panelControlBooks.Margin = new Padding(4, 3, 4, 3);
            panelControlBooks.Name = "panelControlBooks";
            panelControlBooks.Size = new Size(243, 520);
            panelControlBooks.TabIndex = 2;
            // 
            // buttonNewBook
            // 
            buttonNewBook.FlatStyle = FlatStyle.Flat;
            buttonNewBook.ForeColor = Color.WhiteSmoke;
            buttonNewBook.Location = new Point(4, 3);
            buttonNewBook.Margin = new Padding(4, 3, 4, 3);
            buttonNewBook.Name = "buttonNewBook";
            buttonNewBook.Size = new Size(236, 67);
            buttonNewBook.TabIndex = 0;
            buttonNewBook.Text = "Новая запись";
            buttonNewBook.UseVisualStyleBackColor = true;
            buttonNewBook.Click += ButtonNewBook_Click;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.FlatStyle = FlatStyle.Flat;
            buttonDeleteBook.ForeColor = Color.WhiteSmoke;
            buttonDeleteBook.Location = new Point(4, 78);
            buttonDeleteBook.Margin = new Padding(4, 3, 4, 3);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(236, 67);
            buttonDeleteBook.TabIndex = 1;
            buttonDeleteBook.Text = "Удалить";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += ButtonDeleteBook_Click;
            // 
            // buttonChangeBook
            // 
            buttonChangeBook.FlatStyle = FlatStyle.Flat;
            buttonChangeBook.ForeColor = Color.WhiteSmoke;
            buttonChangeBook.Location = new Point(4, 152);
            buttonChangeBook.Margin = new Padding(4, 3, 4, 3);
            buttonChangeBook.Name = "buttonChangeBook";
            buttonChangeBook.Size = new Size(236, 67);
            buttonChangeBook.TabIndex = 2;
            buttonChangeBook.Text = "Изменить";
            buttonChangeBook.UseVisualStyleBackColor = true;
            buttonChangeBook.Click += ButtonChangeBook_Click;
            // 
            // buttonSaveBook
            // 
            buttonSaveBook.FlatStyle = FlatStyle.Flat;
            buttonSaveBook.ForeColor = Color.WhiteSmoke;
            buttonSaveBook.Location = new Point(4, 226);
            buttonSaveBook.Margin = new Padding(4, 3, 4, 3);
            buttonSaveBook.Name = "buttonSaveBook";
            buttonSaveBook.Size = new Size(236, 67);
            buttonSaveBook.TabIndex = 3;
            buttonSaveBook.Text = "Сохранить";
            buttonSaveBook.UseVisualStyleBackColor = true;
            buttonSaveBook.Click += ButtonSaveBook_Click;
            // 
            // buttonWordBook
            // 
            buttonWordBook.FlatStyle = FlatStyle.Flat;
            buttonWordBook.ForeColor = Color.WhiteSmoke;
            buttonWordBook.Location = new Point(4, 301);
            buttonWordBook.Margin = new Padding(4, 3, 4, 3);
            buttonWordBook.Name = "buttonWordBook";
            buttonWordBook.Size = new Size(236, 67);
            buttonWordBook.TabIndex = 4;
            buttonWordBook.Text = "Вывод в Word";
            buttonWordBook.UseVisualStyleBackColor = true;
            buttonWordBook.Click += ButtonWordBook_Click;
            // 
            // buttonExcelBook
            // 
            buttonExcelBook.FlatStyle = FlatStyle.Flat;
            buttonExcelBook.ForeColor = Color.WhiteSmoke;
            buttonExcelBook.Location = new Point(4, 375);
            buttonExcelBook.Margin = new Padding(4, 3, 4, 3);
            buttonExcelBook.Name = "buttonExcelBook";
            buttonExcelBook.Size = new Size(236, 67);
            buttonExcelBook.TabIndex = 5;
            buttonExcelBook.Text = "Вывод в Excel";
            buttonExcelBook.UseVisualStyleBackColor = true;
            buttonExcelBook.Click += ButtonExcelBook_Click;
            // 
            // buttonTXTBook
            // 
            buttonTXTBook.FlatStyle = FlatStyle.Flat;
            buttonTXTBook.ForeColor = Color.WhiteSmoke;
            buttonTXTBook.Location = new Point(4, 449);
            buttonTXTBook.Margin = new Padding(4, 3, 4, 3);
            buttonTXTBook.Name = "buttonTXTBook";
            buttonTXTBook.Size = new Size(236, 67);
            buttonTXTBook.TabIndex = 6;
            buttonTXTBook.Text = "Вывод в TXT";
            buttonTXTBook.UseVisualStyleBackColor = true;
            buttonTXTBook.Click += ButtonTXTBook_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBooks);
            tabControl1.Controls.Add(tabPageLoans);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(897, 1038);
            tabControl1.TabIndex = 0;
            tabControl1.Click += ButtonClear_Click;
            // 
            // tabPageLoans
            // 
            tabPageLoans.BackgroundImage = (Image)resources.GetObject("tabPageLoans.BackgroundImage");
            tabPageLoans.Controls.Add(panelTitleLoans);
            tabPageLoans.Controls.Add(dataGridViewLoans);
            tabPageLoans.Controls.Add(panelRecordLoans);
            tabPageLoans.Controls.Add(labelControlLoans);
            tabPageLoans.Controls.Add(panelControlLoans);
            tabPageLoans.Location = new Point(4, 24);
            tabPageLoans.Margin = new Padding(4, 3, 4, 3);
            tabPageLoans.Name = "tabPageLoans";
            tabPageLoans.Padding = new Padding(4, 3, 4, 3);
            tabPageLoans.Size = new Size(889, 1010);
            tabPageLoans.TabIndex = 1;
            tabPageLoans.Text = "Выдачи";
            tabPageLoans.UseVisualStyleBackColor = true;
            // 
            // panelTitleLoans
            // 
            panelTitleLoans.Controls.Add(labelTitleLoans);
            panelTitleLoans.Controls.Add(buttonClearLoans);
            panelTitleLoans.Controls.Add(buttonRefreshLoans);
            panelTitleLoans.Controls.Add(textBoxSearchLoans);
            panelTitleLoans.Location = new Point(0, 0);
            panelTitleLoans.Margin = new Padding(4, 3, 4, 3);
            panelTitleLoans.Name = "panelTitleLoans";
            panelTitleLoans.Size = new Size(876, 84);
            panelTitleLoans.TabIndex = 3;
            // 
            // labelTitleLoans
            // 
            labelTitleLoans.AutoSize = true;
            labelTitleLoans.Font = new Font("Segoe UI", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelTitleLoans.ForeColor = Color.WhiteSmoke;
            labelTitleLoans.Location = new Point(4, 3);
            labelTitleLoans.Margin = new Padding(4, 0, 4, 0);
            labelTitleLoans.Name = "labelTitleLoans";
            labelTitleLoans.Size = new Size(195, 65);
            labelTitleLoans.TabIndex = 4;
            labelTitleLoans.Text = "Выдачи";
            // 
            // buttonClearLoans
            // 
            buttonClearLoans.FlatStyle = FlatStyle.Flat;
            buttonClearLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClearLoans.Image = (Image)resources.GetObject("buttonClearLoans.Image");
            buttonClearLoans.Location = new Point(528, 3);
            buttonClearLoans.Margin = new Padding(4, 3, 4, 3);
            buttonClearLoans.Name = "buttonClearLoans";
            buttonClearLoans.Size = new Size(78, 77);
            buttonClearLoans.TabIndex = 0;
            buttonClearLoans.UseVisualStyleBackColor = true;
            buttonClearLoans.Click += ButtonClear_Click;
            // 
            // buttonRefreshLoans
            // 
            buttonRefreshLoans.FlatStyle = FlatStyle.Flat;
            buttonRefreshLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRefreshLoans.Image = (Image)resources.GetObject("buttonRefreshLoans.Image");
            buttonRefreshLoans.Location = new Point(614, 3);
            buttonRefreshLoans.Margin = new Padding(4, 3, 4, 3);
            buttonRefreshLoans.Name = "buttonRefreshLoans";
            buttonRefreshLoans.Size = new Size(78, 77);
            buttonRefreshLoans.TabIndex = 1;
            buttonRefreshLoans.UseVisualStyleBackColor = true;
            buttonRefreshLoans.Click += ButtonRefresh_Click;
            // 
            // textBoxSearchLoans
            // 
            textBoxSearchLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearchLoans.Location = new Point(699, 37);
            textBoxSearchLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxSearchLoans.Name = "textBoxSearchLoans";
            textBoxSearchLoans.Size = new Size(173, 33);
            textBoxSearchLoans.TabIndex = 2;
            textBoxSearchLoans.TextChanged += TextBoxSearchLoans_TextChanged;
            // 
            // dataGridViewLoans
            // 
            dataGridViewLoans.AllowUserToAddRows = false;
            dataGridViewLoans.AllowUserToDeleteRows = false;
            dataGridViewLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoans.Location = new Point(9, 91);
            dataGridViewLoans.Margin = new Padding(4, 3, 4, 3);
            dataGridViewLoans.Name = "dataGridViewLoans";
            dataGridViewLoans.ReadOnly = true;
            dataGridViewLoans.RowHeadersWidth = 62;
            dataGridViewLoans.Size = new Size(867, 352);
            dataGridViewLoans.TabIndex = 0;
            dataGridViewLoans.CellClick += DataGridViewLoans_CellClick;
            // 
            // panelRecordLoans
            // 
            panelRecordLoans.Controls.Add(labelRecordLoans);
            panelRecordLoans.Controls.Add(labelLoanID);
            panelRecordLoans.Controls.Add(textBoxLoanID);
            panelRecordLoans.Controls.Add(labelRegistrationIDLoans);
            panelRecordLoans.Controls.Add(textBoxRegistrationIDLoans);
            panelRecordLoans.Controls.Add(labelBookIDLoans);
            panelRecordLoans.Controls.Add(textBoxBookIDLoans);
            panelRecordLoans.Controls.Add(labelLoanDateLoans);
            panelRecordLoans.Controls.Add(dateTimePickerLoanDateLoans);
            panelRecordLoans.Controls.Add(labelReturnDateLoans);
            panelRecordLoans.Controls.Add(dateTimePickerReturnDateLoans);
            panelRecordLoans.Controls.Add(checkBoxReturnDateLoans);
            panelRecordLoans.Controls.Add(labelIsReturnedLoans);
            panelRecordLoans.Controls.Add(textBoxIsReturnedLoans);
            panelRecordLoans.Location = new Point(9, 450);
            panelRecordLoans.Margin = new Padding(4, 3, 4, 3);
            panelRecordLoans.Name = "panelRecordLoans";
            panelRecordLoans.Size = new Size(611, 552);
            panelRecordLoans.TabIndex = 1;
            // 
            // labelRecordLoans
            // 
            labelRecordLoans.AutoSize = true;
            labelRecordLoans.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRecordLoans.ForeColor = Color.WhiteSmoke;
            labelRecordLoans.Location = new Point(4, 10);
            labelRecordLoans.Margin = new Padding(4, 0, 4, 0);
            labelRecordLoans.Name = "labelRecordLoans";
            labelRecordLoans.Size = new Size(142, 47);
            labelRecordLoans.TabIndex = 7;
            labelRecordLoans.Text = "Запись:";
            // 
            // labelLoanID
            // 
            labelLoanID.AutoSize = true;
            labelLoanID.ForeColor = Color.WhiteSmoke;
            labelLoanID.Location = new Point(93, 82);
            labelLoanID.Margin = new Padding(4, 0, 4, 0);
            labelLoanID.Name = "labelLoanID";
            labelLoanID.Size = new Size(48, 15);
            labelLoanID.TabIndex = 8;
            labelLoanID.Text = "Номер:";
            // 
            // textBoxLoanID
            // 
            textBoxLoanID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLoanID.Location = new Point(152, 68);
            textBoxLoanID.Margin = new Padding(4, 3, 4, 3);
            textBoxLoanID.Name = "textBoxLoanID";
            textBoxLoanID.Size = new Size(455, 33);
            textBoxLoanID.TabIndex = 0;
            // 
            // labelRegistrationIDLoans
            // 
            labelRegistrationIDLoans.AutoSize = true;
            labelRegistrationIDLoans.ForeColor = Color.WhiteSmoke;
            labelRegistrationIDLoans.Location = new Point(24, 124);
            labelRegistrationIDLoans.Margin = new Padding(4, 0, 4, 0);
            labelRegistrationIDLoans.Name = "labelRegistrationIDLoans";
            labelRegistrationIDLoans.Size = new Size(122, 15);
            labelRegistrationIDLoans.TabIndex = 9;
            labelRegistrationIDLoans.Text = "Логин пользователя:";
            // 
            // textBoxRegistrationIDLoans
            // 
            textBoxRegistrationIDLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRegistrationIDLoans.Location = new Point(152, 113);
            textBoxRegistrationIDLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxRegistrationIDLoans.Name = "textBoxRegistrationIDLoans";
            textBoxRegistrationIDLoans.Size = new Size(455, 33);
            textBoxRegistrationIDLoans.TabIndex = 1;
            // 
            // labelBookIDLoans
            // 
            labelBookIDLoans.AutoSize = true;
            labelBookIDLoans.ForeColor = Color.WhiteSmoke;
            labelBookIDLoans.Location = new Point(58, 169);
            labelBookIDLoans.Margin = new Padding(4, 0, 4, 0);
            labelBookIDLoans.Name = "labelBookIDLoans";
            labelBookIDLoans.Size = new Size(83, 15);
            labelBookIDLoans.TabIndex = 10;
            labelBookIDLoans.Text = "Номер книги:";
            // 
            // textBoxBookIDLoans
            // 
            textBoxBookIDLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBookIDLoans.Location = new Point(152, 158);
            textBoxBookIDLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxBookIDLoans.Name = "textBoxBookIDLoans";
            textBoxBookIDLoans.Size = new Size(455, 33);
            textBoxBookIDLoans.TabIndex = 2;
            // 
            // labelLoanDateLoans
            // 
            labelLoanDateLoans.AutoSize = true;
            labelLoanDateLoans.ForeColor = Color.WhiteSmoke;
            labelLoanDateLoans.Location = new Point(62, 217);
            labelLoanDateLoans.Margin = new Padding(4, 0, 4, 0);
            labelLoanDateLoans.Name = "labelLoanDateLoans";
            labelLoanDateLoans.Size = new Size(79, 15);
            labelLoanDateLoans.TabIndex = 11;
            labelLoanDateLoans.Text = "Дата выдачи:";
            // 
            // dateTimePickerLoanDateLoans
            // 
            dateTimePickerLoanDateLoans.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerLoanDateLoans.Location = new Point(152, 203);
            dateTimePickerLoanDateLoans.Name = "dateTimePickerLoanDateLoans";
            dateTimePickerLoanDateLoans.Size = new Size(455, 33);
            dateTimePickerLoanDateLoans.TabIndex = 3;
            // 
            // labelReturnDateLoans
            // 
            labelReturnDateLoans.AutoSize = true;
            labelReturnDateLoans.ForeColor = Color.WhiteSmoke;
            labelReturnDateLoans.Location = new Point(55, 259);
            labelReturnDateLoans.Margin = new Padding(4, 0, 4, 0);
            labelReturnDateLoans.Name = "labelReturnDateLoans";
            labelReturnDateLoans.Size = new Size(86, 15);
            labelReturnDateLoans.TabIndex = 12;
            labelReturnDateLoans.Text = "Дата возврата:";
            // 
            // dateTimePickerReturnDateLoans
            // 
            dateTimePickerReturnDateLoans.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerReturnDateLoans.Location = new Point(152, 245);
            dateTimePickerReturnDateLoans.Name = "dateTimePickerReturnDateLoans";
            dateTimePickerReturnDateLoans.Size = new Size(244, 33);
            dateTimePickerReturnDateLoans.TabIndex = 4;
            // 
            // checkBoxReturnDateLoans
            // 
            checkBoxReturnDateLoans.AutoSize = true;
            checkBoxReturnDateLoans.Font = new Font("Segoe UI", 14.25F);
            checkBoxReturnDateLoans.Location = new Point(402, 250);
            checkBoxReturnDateLoans.Name = "checkBoxReturnDateLoans";
            checkBoxReturnDateLoans.Size = new Size(205, 29);
            checkBoxReturnDateLoans.TabIndex = 5;
            checkBoxReturnDateLoans.Text = "Еще не возвращена";
            checkBoxReturnDateLoans.UseVisualStyleBackColor = true;
            checkBoxReturnDateLoans.CheckedChanged += CheckBoxReturnDateLoans_CheckedChanged;
            // 
            // labelIsReturnedLoans
            // 
            labelIsReturnedLoans.AutoSize = true;
            labelIsReturnedLoans.ForeColor = Color.WhiteSmoke;
            labelIsReturnedLoans.Location = new Point(95, 304);
            labelIsReturnedLoans.Margin = new Padding(4, 0, 4, 0);
            labelIsReturnedLoans.Name = "labelIsReturnedLoans";
            labelIsReturnedLoans.Size = new Size(46, 15);
            labelIsReturnedLoans.TabIndex = 13;
            labelIsReturnedLoans.Text = "Статус:";
            // 
            // textBoxIsReturnedLoans
            // 
            textBoxIsReturnedLoans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIsReturnedLoans.Location = new Point(152, 293);
            textBoxIsReturnedLoans.Margin = new Padding(4, 3, 4, 3);
            textBoxIsReturnedLoans.Name = "textBoxIsReturnedLoans";
            textBoxIsReturnedLoans.ReadOnly = true;
            textBoxIsReturnedLoans.Size = new Size(455, 33);
            textBoxIsReturnedLoans.TabIndex = 6;
            // 
            // labelControlLoans
            // 
            labelControlLoans.AutoSize = true;
            labelControlLoans.BackColor = Color.Transparent;
            labelControlLoans.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelControlLoans.ForeColor = Color.WhiteSmoke;
            labelControlLoans.Location = new Point(632, 453);
            labelControlLoans.Margin = new Padding(4, 0, 4, 0);
            labelControlLoans.Name = "labelControlLoans";
            labelControlLoans.Size = new Size(213, 25);
            labelControlLoans.TabIndex = 4;
            labelControlLoans.Text = "Управление записями:";
            // 
            // panelControlLoans
            // 
            panelControlLoans.Controls.Add(buttonNewLoan);
            panelControlLoans.Controls.Add(buttonDeleteLoan);
            panelControlLoans.Controls.Add(buttonChangeLoan);
            panelControlLoans.Controls.Add(buttonSaveLoan);
            panelControlLoans.Controls.Add(buttonWordLoan);
            panelControlLoans.Controls.Add(buttonExcelLoan);
            panelControlLoans.Controls.Add(buttonTXTLoan);
            panelControlLoans.Location = new Point(634, 482);
            panelControlLoans.Margin = new Padding(4, 3, 4, 3);
            panelControlLoans.Name = "panelControlLoans";
            panelControlLoans.Size = new Size(243, 520);
            panelControlLoans.TabIndex = 2;
            // 
            // buttonNewLoan
            // 
            buttonNewLoan.FlatStyle = FlatStyle.Flat;
            buttonNewLoan.ForeColor = Color.WhiteSmoke;
            buttonNewLoan.Location = new Point(4, 3);
            buttonNewLoan.Margin = new Padding(4, 3, 4, 3);
            buttonNewLoan.Name = "buttonNewLoan";
            buttonNewLoan.Size = new Size(236, 67);
            buttonNewLoan.TabIndex = 0;
            buttonNewLoan.Text = "Новая запись";
            buttonNewLoan.UseVisualStyleBackColor = true;
            buttonNewLoan.Click += ButtonNewLoan_Click;
            // 
            // buttonDeleteLoan
            // 
            buttonDeleteLoan.FlatStyle = FlatStyle.Flat;
            buttonDeleteLoan.ForeColor = Color.WhiteSmoke;
            buttonDeleteLoan.Location = new Point(4, 78);
            buttonDeleteLoan.Margin = new Padding(4, 3, 4, 3);
            buttonDeleteLoan.Name = "buttonDeleteLoan";
            buttonDeleteLoan.Size = new Size(236, 67);
            buttonDeleteLoan.TabIndex = 1;
            buttonDeleteLoan.Text = "Удалить";
            buttonDeleteLoan.UseVisualStyleBackColor = true;
            buttonDeleteLoan.Click += ButtonDeleteLoan_Click;
            // 
            // buttonChangeLoan
            // 
            buttonChangeLoan.FlatStyle = FlatStyle.Flat;
            buttonChangeLoan.ForeColor = Color.WhiteSmoke;
            buttonChangeLoan.Location = new Point(4, 152);
            buttonChangeLoan.Margin = new Padding(4, 3, 4, 3);
            buttonChangeLoan.Name = "buttonChangeLoan";
            buttonChangeLoan.Size = new Size(236, 67);
            buttonChangeLoan.TabIndex = 2;
            buttonChangeLoan.Text = "Изменить";
            buttonChangeLoan.UseVisualStyleBackColor = true;
            buttonChangeLoan.Click += ButtonChangeLoan_Click;
            // 
            // buttonSaveLoan
            // 
            buttonSaveLoan.FlatStyle = FlatStyle.Flat;
            buttonSaveLoan.ForeColor = Color.WhiteSmoke;
            buttonSaveLoan.Location = new Point(4, 226);
            buttonSaveLoan.Margin = new Padding(4, 3, 4, 3);
            buttonSaveLoan.Name = "buttonSaveLoan";
            buttonSaveLoan.Size = new Size(236, 67);
            buttonSaveLoan.TabIndex = 3;
            buttonSaveLoan.Text = "Сохранить";
            buttonSaveLoan.UseVisualStyleBackColor = true;
            buttonSaveLoan.Click += ButtonSaveLoan_Click;
            // 
            // buttonWordLoan
            // 
            buttonWordLoan.FlatStyle = FlatStyle.Flat;
            buttonWordLoan.ForeColor = Color.WhiteSmoke;
            buttonWordLoan.Location = new Point(4, 301);
            buttonWordLoan.Margin = new Padding(4, 3, 4, 3);
            buttonWordLoan.Name = "buttonWordLoan";
            buttonWordLoan.Size = new Size(236, 67);
            buttonWordLoan.TabIndex = 4;
            buttonWordLoan.Text = "Вывод в Word";
            buttonWordLoan.UseVisualStyleBackColor = true;
            buttonWordLoan.Click += ButtonWordLoan_Click;
            // 
            // buttonExcelLoan
            // 
            buttonExcelLoan.FlatStyle = FlatStyle.Flat;
            buttonExcelLoan.ForeColor = Color.WhiteSmoke;
            buttonExcelLoan.Location = new Point(4, 375);
            buttonExcelLoan.Margin = new Padding(4, 3, 4, 3);
            buttonExcelLoan.Name = "buttonExcelLoan";
            buttonExcelLoan.Size = new Size(236, 67);
            buttonExcelLoan.TabIndex = 5;
            buttonExcelLoan.Text = "Вывод в Excel";
            buttonExcelLoan.UseVisualStyleBackColor = true;
            buttonExcelLoan.Click += ButtonExcelLoan_Click;
            // 
            // buttonTXTLoan
            // 
            buttonTXTLoan.FlatStyle = FlatStyle.Flat;
            buttonTXTLoan.ForeColor = Color.WhiteSmoke;
            buttonTXTLoan.Location = new Point(4, 449);
            buttonTXTLoan.Margin = new Padding(4, 3, 4, 3);
            buttonTXTLoan.Name = "buttonTXTLoan";
            buttonTXTLoan.Size = new Size(236, 67);
            buttonTXTLoan.TabIndex = 6;
            buttonTXTLoan.Text = "Вывод в TXT";
            buttonTXTLoan.UseVisualStyleBackColor = true;
            buttonTXTLoan.Click += ButtonTXTLoan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(895, 1033);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Учёт библиотеки";
            Load += Form1_Load;
            tabPageBooks.ResumeLayout(false);
            tabPageBooks.PerformLayout();
            panelTitleBooks.ResumeLayout(false);
            panelTitleBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            panelRecordBooks.ResumeLayout(false);
            panelRecordBooks.PerformLayout();
            panelControlBooks.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageLoans.ResumeLayout(false);
            tabPageLoans.PerformLayout();
            panelTitleLoans.ResumeLayout(false);
            panelTitleLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).EndInit();
            panelRecordLoans.ResumeLayout(false);
            panelRecordLoans.PerformLayout();
            panelControlLoans.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageBooks;
        private TextBox textBoxBookID;
        private Label labelBookID;
        private Panel panelControlBooks;
        private Button buttonTXTBook;
        private Button buttonSaveBook;
        private Button buttonExcelBook;
        private Button buttonChangeBook;
        private Button buttonWordBook;
        private Button buttonDeleteBook;
        private Button buttonNewBook;
        private Label labelControlBooks;
        private Panel panelRecordBooks;
        private Label labelISBNBooks;
        private TextBox textBoxISBNBooks;
        private Label labelGenreBooks;
        private Label labelPublishedYearBooks;
        private Label labelAuthorBooks;
        private TextBox textBoxAuthorBooks;
        private Label labelTitleBooks;
        private TextBox textBoxTitleBooks;
        private Label labelRecordBooks;
        private DataGridView dataGridViewBooks;
        private Panel panelTitleBooks;
        private Button buttonClearBooks;
        private Button buttonRefreshBooks;
        private TextBox textBoxSearchBooks;
        private Label labelTitle;
        private TabControl tabControl1;
        private Label labelCopiesAvailableBooks;
        private TabPage tabPageLoans;
        private Panel panelTitleLoans;
        private Label labelTitleLoans;
        private Button buttonClearLoans;
        private Button buttonRefreshLoans;
        private TextBox textBoxSearchLoans;
        private DataGridView dataGridViewLoans;
        private Panel panelRecordLoans;
        private Label labelRecordLoans;
        private Label labelLoanID;
        private TextBox textBoxLoanID;
        private Label labelRegistrationIDLoans;
        private TextBox textBoxRegistrationIDLoans;
        private Label labelBookIDLoans;
        private TextBox textBoxBookIDLoans;
        private Label labelLoanDateLoans;
        private Label labelReturnDateLoans;
        private Label labelIsReturnedLoans;
        private TextBox textBoxIsReturnedLoans;
        private Label labelControlLoans;
        private Panel panelControlLoans;
        private Button buttonNewLoan;
        private Button buttonDeleteLoan;
        private Button buttonChangeLoan;
        private Button buttonSaveLoan;
        private Button buttonWordLoan;
        private Button buttonExcelLoan;
        private Button buttonTXTLoan;
        private TextBox textBoxCopiesAvailableBooks;
        private TextBox textBoxPublishedYearBooks;
        private TextBox textBoxGenreBooks;
        private DateTimePicker dateTimePickerLoanDateLoans;
        private DateTimePicker dateTimePickerReturnDateLoans;
        private CheckBox checkBoxReturnDateLoans;
    }
}