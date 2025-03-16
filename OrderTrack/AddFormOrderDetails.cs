using System.Data.SqlClient;

namespace OrderTrack
{
    public partial class AddFormOrderDetails : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormOrderDetails()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// ButtonSave_Click() вызывается при нажатии на кнопку "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var orderIDOrderDetails = textBoxProductIDOrderDetails.Text;
                var product = textBoxOrderIDOrderDetails.Text;
                string queryProduct = $"SELECT ProductID FROM Products WHERE Name = '{product}'";
                SqlCommand commandProduct = new(queryProduct, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultProduct = commandProduct.ExecuteScalar();
                var productIDOrderDetails = resultProduct.ToString();
                var addQuery = $"insert into OrderDetails (OrderID, ProductID) values ('{orderIDOrderDetails}', '{productIDOrderDetails}')";
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
    }
}