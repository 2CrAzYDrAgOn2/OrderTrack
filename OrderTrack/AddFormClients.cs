using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderTrack
{
    public partial class AddFormClients : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormClients()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var userLogin = textBoxRegistrationIDLoans.Text;
                string query = $"SELECT RegistrationID FROM Registration WHERE UserLogin = '{userLogin}'";
                SqlCommand command = new(query, dataBase.GetConnection());
                dataBase.OpenConnection();
                object result = command.ExecuteScalar();
                var registrationID = result.ToString();
                var bookID = textBoxBookIDLoans.Text;
                var loanDate = dateTimePickerLoanDateLoans.Value;
                DateTime? returnDate = checkBoxReturnDateLoans.Checked ? (DateTime?)null : dateTimePickerReturnDateLoans.Value;
                var isReturned = textBoxIsReturnedLoans.Text;
                if (isReturned == "0")
                {
                    string updateCopiesQuery = $"UPDATE Books SET CopiesAvailable = CopiesAvailable - 1 WHERE BookID = '{bookID}' AND CopiesAvailable > 0";
                    SqlCommand updateCopiesCommand = new(updateCopiesQuery, dataBase.GetConnection());
                    int rowsAffected = updateCopiesCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Недостаточно доступных копий книги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string returnDateValue = returnDate.HasValue ? $"'{returnDate.Value:yyyy-MM-dd}'" : "NULL";
                var addQuery = $"insert into Loans (RegistrationID, BookID, LoanDate, ReturnDate, IsReturned) values ('{registrationID}', '{bookID}', '{loanDate:yyyy-MM-dd}', {returnDateValue}, '{isReturned}')";
                var sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }

        private void CheckBoxReturnDateLoans_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReturnDateLoans.Checked)
            {
                dateTimePickerReturnDateLoans.Enabled = false;
                textBoxIsReturnedLoans.Text = "0";
            }
            else
            {
                dateTimePickerReturnDateLoans.Enabled = true;
                textBoxIsReturnedLoans.Text = "1";
            }
        }
    }
}