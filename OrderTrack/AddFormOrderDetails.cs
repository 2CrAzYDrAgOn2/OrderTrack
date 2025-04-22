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
            dataBase.OpenConnection();
            comboBoxOrderIDOrderDetails.Items.Clear();
            var ordersQuery = "SELECT OrderID FROM Orders ORDER BY OrderID";
            var ordersCommand = new SqlCommand(ordersQuery, dataBase.GetConnection());
            var ordersReader = ordersCommand.ExecuteReader();
            while (ordersReader.Read())
            {
                comboBoxOrderIDOrderDetails.Items.Add(ordersReader.GetInt32(0));
            }
            ordersReader.Close();
            comboBoxProductIDOrderDetails.Items.Clear();
            var productsQuery = "SELECT Name FROM Products ORDER BY Name";
            var productsCommand = new SqlCommand(productsQuery, dataBase.GetConnection());
            var productsReader = productsCommand.ExecuteReader();
            while (productsReader.Read())
            {
                comboBoxProductIDOrderDetails.Items.Add(productsReader.GetString(0));
            }
            productsReader.Close();
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
                var orderIDOrderDetails = comboBoxOrderIDOrderDetails.Text;
                var product = comboBoxProductIDOrderDetails.Text;
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