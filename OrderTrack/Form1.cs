﻿using Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace OrderTrack
{
    internal enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        private readonly DataBase dataBase = new();
        private bool admin;
        private int selectedRow;
        private System.Windows.Forms.Timer timer;
        private NotifyIcon notifyIcon;

        public Form1(bool admin)
        {
            try
            {
                this.admin = admin;
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
                InitializeNotifyIcon();
                InitializeTimer();
                //ClearFields();
                ShowBalloonTip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateColumns()
        {
            try
            {
                dataGridViewClients.Columns.Add("ClientID", "Номер");
                dataGridViewClients.Columns.Add("FullName", "Наименование");
                dataGridViewClients.Columns.Add("ClientTypeID", "Тип клиента");
                dataGridViewClients.Columns.Add("Email", "Электронная почта");
                dataGridViewClients.Columns.Add("Phone", "Телефон");
                dataGridViewClients.Columns.Add("Address", "Адрес");
                dataGridViewClients.Columns.Add("INN", "ИНН");
                dataGridViewClients.Columns.Add("RegistrationDate", "Дата регистрации");
                dataGridViewClients.Columns.Add("IsNew", String.Empty);
                dataGridViewEmployees.Columns.Add("EmployeeID", "Номер");
                dataGridViewEmployees.Columns.Add("FullName", "ФИО");
                dataGridViewEmployees.Columns.Add("Phone", "Телефон");
                dataGridViewEmployees.Columns.Add("Email", "Почта");
                dataGridViewEmployees.Columns.Add("GenderID", "Пол");
                dataGridViewEmployees.Columns.Add("PostID", "Должность");
                dataGridViewEmployees.Columns.Add("IsNew", String.Empty);
                dataGridViewOrders.Columns.Add("OrderID", "Номер");
                dataGridViewOrders.Columns.Add("ClientID", "Наименование клиента");
                dataGridViewOrders.Columns.Add("EmployeeID", "ФИО сотрудника");
                dataGridViewOrders.Columns.Add("OrderDate", "Дата заказа");
                dataGridViewOrders.Columns.Add("TotalAmount", "Итого");
                dataGridViewOrders.Columns.Add("StatusID", "Статус");
                dataGridViewOrders.Columns.Add("IsNew", String.Empty);
                dataGridViewProducts.Columns.Add("ProductID", "Номер");
                dataGridViewProducts.Columns.Add("Name", "Наименование");
                dataGridViewProducts.Columns.Add("Description", "Описание");
                dataGridViewProducts.Columns.Add("Price", "Цена");
                dataGridViewProducts.Columns.Add("IsNew", String.Empty);
                dataGridViewOrderDetails.Columns.Add("OrderDetailID", "Номер");
                dataGridViewOrderDetails.Columns.Add("OrderID", "Номер заказа");
                dataGridViewOrderDetails.Columns.Add("ProductID", "Наименование продукта");
                dataGridViewOrderDetails.Columns.Add("Price", "Цена");
                dataGridViewOrderDetails.Columns.Add("IsNew", String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void ClearFields()
        //{
        //    try
        //    {
        //        textBoxBookID.Text = "";
        //        textBoxTitleBooks.Text = "";
        //        textBoxAuthorBooks.Text = "";
        //        textBoxGenreBooks.Text = "";
        //        textBoxPublishedYearBooks.Text = "";
        //        textBoxISBNBooks.Text = "";
        //        textBoxCopiesAvailableBooks.Text = "";
        //        textBoxLoanID.Text = "";
        //        textBoxRegistrationIDLoans.Text = "";
        //        textBoxBookIDLoans.Text = "";
        //        dateTimePickerLoanDateLoans.Text = "";
        //        dateTimePickerReturnDateLoans.Text = "";
        //        textBoxIsReturnedLoans.Text = "";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private static void ReadSingleRow(DataGridView dataGridView, IDataRecord iDataRecord)
        {
            try
            {
                switch (dataGridView.Name)
                {
                    case "dataGridViewClients":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetInt32(2), iDataRecord.GetString(3), iDataRecord.GetString(4), iDataRecord.GetString(5), iDataRecord.GetString(6), iDataRecord.GetDateTime(7).ToString("yyyy-MM-dd"), RowState.Modified);
                        break;

                    case "dataGridViewEmployees":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetString(2), iDataRecord.GetString(3), iDataRecord.GetInt32(4), iDataRecord.GetInt32(5), RowState.Modified);
                        break;

                    case "dataGridViewOrders":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetInt32(2), iDataRecord.GetDateTime(3).ToString("yyyy-MM-dd"), iDataRecord.GetDouble(4), iDataRecord.GetInt32(5), RowState.Modified);
                        break;

                    case "dataGridViewProducts":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetString(2), iDataRecord.GetDouble(3), RowState.Modified);
                        break;

                    case "dataGridViewOrderDetails":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetInt32(2), iDataRecord.GetDouble(3), RowState.Modified);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshDataGrid(DataGridView dataGridView, string tableName)
        {
            try
            {
                dataGridView.Rows.Clear();
                string queryString = $"select * from {tableName}";
                SqlCommand sqlCommand = new(queryString, dataBase.GetConnection());
                dataBase.OpenConnection();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ReadSingleRow(dataGridView, sqlDataReader);
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 3600000
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowBalloonTip();
        }

        private void ShowBalloonTip()
        {
            notifyIcon.BalloonTipTitle = "СитиСервисПлюс";
            notifyIcon.BalloonTipText = $"Все права защищены.";
            notifyIcon.ShowBalloonTip(3000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CreateColumns();
                RefreshDataGrid(dataGridViewClients, "Clients");
                RefreshDataGrid(dataGridViewEmployees, "Employees");
                RefreshDataGrid(dataGridViewOrders, "Orders");
                RefreshDataGrid(dataGridViewProducts, "Products");
                RefreshDataGrid(dataGridViewOrderDetails, "OrderDetails");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void DataGridView_CellClick(DataGridView dataGridView, int selectedRow)
        //{
        //    try
        //    {
        //        DataGridViewRow dataGridViewRow = dataGridView.Rows[selectedRow];
        //        switch (dataGridView.Name)
        //        {
        //            case "dataGridViewBooks":
        //                textBoxBookID.Text = dataGridViewRow.Cells[0].Value.ToString();
        //                textBoxTitleBooks.Text = dataGridViewRow.Cells[1].Value.ToString();
        //                textBoxAuthorBooks.Text = dataGridViewRow.Cells[2].Value.ToString();
        //                textBoxGenreBooks.Text = dataGridViewRow.Cells[3].Value.ToString();
        //                textBoxPublishedYearBooks.Text = dataGridViewRow.Cells[4].Value.ToString();
        //                textBoxISBNBooks.Text = dataGridViewRow.Cells[5].Value.ToString();
        //                textBoxCopiesAvailableBooks.Text = dataGridViewRow.Cells[6].Value.ToString();
        //                break;

        //            case "dataGridViewLoans":
        //                textBoxLoanID.Text = dataGridViewRow.Cells[0].Value.ToString();
        //                var registrationID = dataGridViewRow.Cells[1].Value.ToString();
        //                string query = $"SELECT UserLogin FROM Registration WHERE RegistrationID = {registrationID}";
        //                SqlCommand command = new(query, dataBase.GetConnection());
        //                dataBase.OpenConnection();
        //                object result = command.ExecuteScalar();
        //                textBoxRegistrationIDLoans.Text = result.ToString();
        //                textBoxBookIDLoans.Text = dataGridViewRow.Cells[2].Value.ToString();
        //                dateTimePickerLoanDateLoans.Text = dataGridViewRow.Cells[3].Value.ToString();
        //                dateTimePickerReturnDateLoans.Text = dataGridViewRow.Cells[4].Value?.ToString();
        //                if (dataGridViewRow.Cells[4].Value?.ToString() == "")
        //                {
        //                    checkBoxReturnDateLoans.Checked = true;
        //                }
        //                else
        //                {
        //                    checkBoxReturnDateLoans.Checked = false;
        //                }
        //                textBoxIsReturnedLoans.Text = dataGridViewRow.Cells[5].Value.ToString();
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void Search(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        dataGridView.Rows.Clear();
        //        switch (dataGridView.Name)
        //        {
        //            case "dataGridViewBooks":
        //                string searchStringEquipment = $"select * from Books where concat (BookID, Title, Author, Genre, PublishedYear, ISBN, CopiesAvailable) like '%" + textBoxSearchBooks.Text + "%'";
        //                SqlCommand sqlCommandEquipment = new(searchStringEquipment, dataBase.GetConnection());
        //                dataBase.OpenConnection();
        //                SqlDataReader sqlDataReaderEquipment = sqlCommandEquipment.ExecuteReader();
        //                while (sqlDataReaderEquipment.Read())
        //                {
        //                    ReadSingleRow(dataGridView, sqlDataReaderEquipment);
        //                }
        //                sqlDataReaderEquipment.Close();
        //                break;

        //            case "dataGridViewLoans":
        //                string searchStringSupplier = $"select * from Loans where concat (LoanID, RegistrationID, BookID, LoanDate, ReturnDate, IsReturned) like '%" + textBoxSearchClients.Text + "%'";
        //                SqlCommand sqlCommandSupplier = new(searchStringSupplier, dataBase.GetConnection());
        //                dataBase.OpenConnection();
        //                SqlDataReader sqlDataReaderSupplier = sqlCommandSupplier.ExecuteReader();
        //                while (sqlDataReaderSupplier.Read())
        //                {
        //                    ReadSingleRow(dataGridView, sqlDataReaderSupplier);
        //                }
        //                sqlDataReaderSupplier.Close();
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private static void DeleteRow(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        int index = dataGridView.CurrentCell.RowIndex;
        //        dataGridView.Rows[index].Visible = false;
        //        switch (dataGridView.Name)
        //        {
        //            case "dataGridViewBooks":
        //                if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
        //                {
        //                    dataGridView.Rows[index].Cells[7].Value = RowState.Deleted;
        //                    return;
        //                }
        //                dataGridView.Rows[index].Cells[7].Value = RowState.Deleted;
        //                break;

        //            case "dataGridViewLoans":
        //                if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
        //                {
        //                    dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
        //                    return;
        //                }
        //                dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void UpdateBase(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        dataBase.OpenConnection();
        //        for (int index = 0; index < dataGridView.Rows.Count; index++)
        //        {
        //            switch (dataGridView.Name)
        //            {
        //                case "dataGridViewBooks":
        //                    var rowStateBooks = (RowState)dataGridView.Rows[index].Cells[7].Value;
        //                    if (rowStateBooks == RowState.Existed)
        //                    {
        //                        continue;
        //                    }
        //                    if (rowStateBooks == RowState.Deleted)
        //                    {
        //                        var bookID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
        //                        var deleteQuery = $"delete from Books where BookID = '{bookID}'";
        //                        var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
        //                        sqlCommand.ExecuteNonQuery();
        //                    }
        //                    if (rowStateBooks == RowState.Modified)
        //                    {
        //                        var bookID = dataGridView.Rows[index].Cells[0].Value.ToString();
        //                        var title = dataGridView.Rows[index].Cells[1].Value.ToString();
        //                        var author = dataGridView.Rows[index].Cells[2].Value.ToString();
        //                        var genre = dataGridView.Rows[index].Cells[3].Value.ToString();
        //                        var publishedYear = dataGridView.Rows[index].Cells[4].Value.ToString();
        //                        var iSBN = dataGridView.Rows[index].Cells[5].Value.ToString();
        //                        var copiesAvailable = dataGridView.Rows[index].Cells[6].Value.ToString();
        //                        var changeQuery = $"update Books set Title = '{title}', Author = '{author}', Genre = '{genre}', PublishedYear = '{publishedYear}', ISBN = '{iSBN}', CopiesAvailable = '{copiesAvailable}' where BookID = '{bookID}'";
        //                        var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
        //                        sqlCommand.ExecuteNonQuery();
        //                    }
        //                    if (rowStateBooks == RowState.New)
        //                    {
        //                        var title = dataGridView.Rows[index].Cells[1].Value.ToString();
        //                        var author = dataGridView.Rows[index].Cells[2].Value.ToString();
        //                        var genre = dataGridView.Rows[index].Cells[3].Value.ToString();
        //                        var publishedYear = dataGridView.Rows[index].Cells[4].Value.ToString();
        //                        var iSBN = dataGridView.Rows[index].Cells[5].Value.ToString();
        //                        var copiesAvailable = dataGridView.Rows[index].Cells[6].Value.ToString();
        //                        var newQuery = $"insert into Books (Title, Author, Genre, PublishedYear, ISBN, CopiesAvailable) values ('{title}', '{author}', '{genre}', '{publishedYear}', '{iSBN}', '{copiesAvailable}')";
        //                        var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
        //                        sqlCommand.ExecuteNonQuery();
        //                    }
        //                    break;

        //                case "dataGridViewLoans":
        //                    var rowStateLoans = (RowState)dataGridView.Rows[index].Cells[6].Value;
        //                    if (rowStateLoans == RowState.Existed)
        //                    {
        //                        continue;
        //                    }
        //                    if (rowStateLoans == RowState.Deleted)
        //                    {
        //                        var loanID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
        //                        var bookID = dataGridView.Rows[index].Cells[2].Value.ToString();
        //                        var isReturned = dataGridView.Rows[index].Cells[5].Value.ToString();
        //                        if (isReturned == "False")
        //                        {
        //                            string updateCopiesQuery = $"UPDATE Books SET CopiesAvailable = CopiesAvailable + 1 WHERE BookID = '{bookID}'";
        //                            SqlCommand updateCopiesCommand = new(updateCopiesQuery, dataBase.GetConnection());
        //                            updateCopiesCommand.ExecuteNonQuery();
        //                        }
        //                        var deleteQuery = $"delete from Loans where LoanID = '{loanID}'";
        //                        var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
        //                        sqlCommand.ExecuteNonQuery();
        //                    }
        //                    if (rowStateLoans == RowState.Modified)
        //                    {
        //                        var loanID = dataGridView.Rows[index].Cells[0].Value.ToString();
        //                        var registrationID = dataGridView.Rows[index].Cells[1].Value.ToString();
        //                        var bookID = dataGridView.Rows[index].Cells[2].Value.ToString();
        //                        var loanDate = dataGridView.Rows[index].Cells[3].Value.ToString();
        //                        var returnDate = dataGridView.Rows[index].Cells[4].Value?.ToString();
        //                        var isReturned = dataGridView.Rows[index].Cells[5].Value.ToString();
        //                        var changeQuery = $"update Loans set RegistrationID = '{registrationID}', BookID = '{bookID}', LoanDate = '{loanDate}', ReturnDate = {(string.IsNullOrEmpty(returnDate) ? "NULL" : $"'{returnDate}'")}, IsReturned = '{isReturned}' where LoanID = '{loanID}'";
        //                        var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
        //                        sqlCommand.ExecuteNonQuery();
        //                    }
        //                    if (rowStateLoans == RowState.New)
        //                    {
        //                        var registrationID = dataGridView.Rows[index].Cells[1].Value.ToString();
        //                        var bookID = dataGridView.Rows[index].Cells[2].Value.ToString();
        //                        var loanDate = dataGridView.Rows[index].Cells[3].Value.ToString();
        //                        var returnDate = dataGridView.Rows[index].Cells[4].Value.ToString();
        //                        var isReturned = dataGridView.Rows[index].Cells[5].Value.ToString();
        //                        var newQuery = $"insert into Loans (RegistrationID, BookID, LoanDate, ReturnDate, ReturnDate, IsReturned) values ('{registrationID}', '{bookID}', '{loanDate}', '{returnDate}', '{isReturned}')";
        //                        var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
        //                        sqlCommand.ExecuteNonQuery();
        //                    }
        //                    break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        dataBase.CloseConnection();
        //    }
        //}

        //private void Change(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
        //        switch (dataGridView.Name)
        //        {
        //            case "dataGridViewBooks":
        //                var bookID = textBoxBookID.Text;
        //                var titleBooks = textBoxTitleBooks.Text;
        //                var authorBooks = textBoxAuthorBooks.Text;
        //                var genreBooks = textBoxGenreBooks.Text;
        //                var publishedYearBooks = textBoxPublishedYearBooks.Text;
        //                var iSBNBooks = textBoxISBNBooks.Text;
        //                var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
        //                dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
        //                dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
        //                break;

        //            case "dataGridViewLoans":
        //                var loanID = textBoxLoanID.Text;
        //                var userLogin = textBoxRegistrationIDLoans.Text;
        //                string query = $"SELECT RegistrationID FROM Registration WHERE UserLogin = '{userLogin}'";
        //                SqlCommand command = new(query, dataBase.GetConnection());
        //                dataBase.OpenConnection();
        //                object result = command.ExecuteScalar();
        //                var registrationIDLoans = result.ToString();
        //                var bookIDLoans = textBoxBookIDLoans.Text;
        //                var loanDateLoans = dateTimePickerLoanDateLoans.Value;
        //                DateTime? returnDateLoans = dateTimePickerReturnDateLoans.Value;
        //                if (checkBoxReturnDateLoans.Checked)
        //                {
        //                    returnDateLoans = null;
        //                }
        //                var isReturnedLoans = textBoxIsReturnedLoans.Text;
        //                dataGridView.Rows[selectedRowIndex].SetValues(loanID, registrationIDLoans, bookIDLoans, loanDateLoans, returnDateLoans, isReturnedLoans);
        //                dataGridView.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void ExportToWord(DataGridView dataGridView)
        {
            try
            {
                var wordApp = new Microsoft.Office.Interop.Word.Application
                {
                    Visible = true
                };
                Document doc = wordApp.Documents.Add();
                Paragraph title = doc.Paragraphs.Add();
                switch (dataGridView.Name)
                {
                    case "dataGridViewClients":
                        title.Range.Text = "Данные клиентов";
                        break;

                    case "dataGridViewEmployees":
                        title.Range.Text = "Данные сотрудников";
                        break;

                    case "dataGridViewOrders":
                        title.Range.Text = "Данные заказов";
                        break;

                    case "dataGridViewProducts":
                        title.Range.Text = "Данные продуктов";
                        break;

                    case "dataGridViewOrderDetails":
                        title.Range.Text = "Данные деталей заказов";
                        break;
                }
                title.Range.Font.Bold = 1;
                title.Range.Font.Size = 14;
                title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();
                Table table = doc.Tables.Add(title.Range, dataGridView.RowCount + 1, dataGridView.ColumnCount - 1);
                for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                {
                    table.Cell(1, col + 1).Range.Text = dataGridView.Columns[col].HeaderText;
                }
                for (int row = 0; row < dataGridView.RowCount; row++)
                {
                    for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                    {
                        table.Cell(row + 2, col + 1).Range.Text = dataGridView[col, row].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                Excel.Application excelApp = new()
                {
                    Visible = true
                };
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                string title = "";
                switch (dataGridView.Name)
                {
                    case "dataGridViewClients":
                        title = "Данные клиентов";
                        break;

                    case "dataGridViewEmployees":
                        title = "Данные сотрудников";
                        break;

                    case "dataGridViewOrders":
                        title = "Данные заказов";
                        break;

                    case "dataGridViewProducts":
                        title = "Данные продуктов";
                        break;

                    case "dataGridViewOrderDetails":
                        title = "Данные деталей заказов";
                        break;
                }
                Excel.Range titleRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dataGridView.ColumnCount - 1]];
                titleRange.Merge();
                titleRange.Value = title;
                titleRange.Font.Bold = true;
                titleRange.Font.Size = 14;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                for (int col = 0; col < dataGridView.ColumnCount; col++)
                {
                    worksheet.Cells[2, col + 1] = dataGridView.Columns[col].HeaderText;
                }
                for (int row = 0; row < dataGridView.RowCount; row++)
                {
                    for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                    {
                        worksheet.Cells[row + 3, col + 1] = dataGridView[col, row].Value.ToString();
                        Excel.Range dataRange = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[dataGridView.RowCount + 2, dataGridView.ColumnCount]];
                        dataRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        dataRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    }
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ExportToTXT(DataGridView dataGridView)
        {
            string text = "";
            switch (dataGridView.Name)
            {
                case "dataGridViewClients":
                    text += "Данные клиентов\n\n";
                    break;

                case "dataGridViewEmployees":
                    text += "Данные сотрудников\n\n";
                    break;

                case "dataGridViewOrders":
                    text += "Данные заказов\n\n";
                    break;

                case "dataGridViewProducts":
                    text += "Данные продуктов\n\n";
                    break;

                case "dataGridViewOrderDetails":
                    text += "Данные деталей заказов\n\n";
                    break;
            }
            for (int col = 0; col < dataGridView.ColumnCount; col++)
            {
                text += dataGridView.Columns[col].HeaderText + "\t";
            }
            text += "\n";
            for (int row = 0; row < dataGridView.RowCount; row++)
            {
                for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                {
                    text += dataGridView[col, row].Value?.ToString() + "\t";
                }
                text += "\n";
            }
            string filePath = "данные.txt";
            File.WriteAllText(filePath, text);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        //private void ButtonRefresh_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        RefreshDataGrid(dataGridViewBooks, "Books");
        //        RefreshDataGrid(dataGridViewClients, "Loans");
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonClear_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonNewBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddFormBooks addForm = new();
        //        addForm.Show();
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonNewLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddFormLoans addForm = new();
        //        addForm.Show();
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonDeleteBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DeleteRow(dataGridViewBooks);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonDeleteLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DeleteRow(dataGridViewClients);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonChangeBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Change(dataGridViewBooks);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonChangeLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Change(dataGridViewClients);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonSaveBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (admin)
        //        {
        //            UpdateBase(dataGridViewBooks);
        //        }
        //        else
        //        {
        //            MessageBox.Show("У вас недостаточно прав!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonSaveLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        UpdateBase(dataGridViewClients);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        /// <summary>
        /// ButtonWordClient_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Клиенты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordClient_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordEmployee_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordOrder_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Заказы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordProduct_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Продукты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordOrderDetails_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Детали заказов"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelClient_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Клиенты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelClient_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelEmployee_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelOrder_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Заказы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelProduct_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Продукты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelOrderDetails_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Детали заказов"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonTXTClient_Click() вызывается при нажатии на кнопку "Вывод в TXT" на вкладке "Клиенты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTXTClient_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToTXT(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonTXTEmployee_Click() вызывается при нажатии на кнопку "Вывод в TXT" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTXTEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToTXT(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonTXTOrder_Click() вызывается при нажатии на кнопку "Вывод в TXT" на вкладке "Заказы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTXTOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToTXT(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonTXTProduct_Click() вызывается при нажатии на кнопку "Вывод в TXT" на вкладке "Продукты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTXTProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToTXT(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonTXTOrderDetails_Click() вызывается при нажатии на кнопку "Вывод в TXT" на вкладке "Детали заказов"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTXTOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToTXT(dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void DataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        selectedRow = e.RowIndex;
        //        if (e.RowIndex >= 0)
        //        {
        //            DataGridView_CellClick(dataGridViewBooks, selectedRow);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void DataGridViewLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        selectedRow = e.RowIndex;
        //        if (e.RowIndex >= 0)
        //        {
        //            DataGridView_CellClick(dataGridViewClients, selectedRow);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void TextBoxSearchBooks_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Search(dataGridViewBooks);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void TextBoxSearchLoans_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Search(dataGridViewClients);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}