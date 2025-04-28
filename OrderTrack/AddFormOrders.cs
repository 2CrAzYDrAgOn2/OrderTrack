using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderTrack
{
    public partial class AddFormOrders : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormOrders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxClientIDOrders.Items.Clear();
            var clientsQuery = "SELECT FullName FROM Clients ORDER BY FullName";
            var clientsCommand = new SqlCommand(clientsQuery, dataBase.GetConnection());
            var clientsReader = clientsCommand.ExecuteReader();
            while (clientsReader.Read())
            {
                comboBoxClientIDOrders.Items.Add(clientsReader.GetString(0));
            }
            clientsReader.Close();
            comboBoxEmployeeIDOrders.Items.Clear();
            var employeesQuery = "SELECT FullName FROM Employees ORDER BY FullName";
            var employeesCommand = new SqlCommand(employeesQuery, dataBase.GetConnection());
            var employeesReader = employeesCommand.ExecuteReader();
            while (employeesReader.Read())
            {
                comboBoxEmployeeIDOrders.Items.Add(employeesReader.GetString(0));
            }
            employeesReader.Close();
            comboBoxStatusID.Items.Clear();
            var statusesQuery = "SELECT Status FROM Statuses ORDER BY Status";
            var statusesCommand = new SqlCommand(statusesQuery, dataBase.GetConnection());
            var statusesReader = statusesCommand.ExecuteReader();
            while (statusesReader.Read())
            {
                comboBoxStatusID.Items.Add(statusesReader.GetString(0));
            }
            statusesReader.Close();
            comboBoxProductIDOrders.Items.Clear();
            var productsForOrdersQuery = "SELECT Name FROM Products ORDER BY Name";
            var productsForOrdersCommand = new SqlCommand(productsForOrdersQuery, dataBase.GetConnection());
            var productsForOrdersReader = productsForOrdersCommand.ExecuteReader();
            while (productsForOrdersReader.Read())
            {
                comboBoxProductIDOrders.Items.Add(productsForOrdersReader.GetString(0));
            }
            productsForOrdersReader.Close();
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
                string queryClient = $"SELECT ClientID FROM Clients WHERE FullName = '{comboBoxClientIDOrders.Text}'";
                SqlCommand commandClient = new SqlCommand(queryClient, dataBase.GetConnection());
                object resultClient = commandClient.ExecuteScalar();
                string clientID = resultClient.ToString();
                string queryEmployee = $"SELECT EmployeeID FROM Employees WHERE FullName = '{comboBoxEmployeeIDOrders.Text}'";
                SqlCommand commandEmployee = new SqlCommand(queryEmployee, dataBase.GetConnection());
                object resultEmployee = commandEmployee.ExecuteScalar();
                string employeeID = resultEmployee.ToString();
                string queryStatus = $"SELECT StatusID FROM Statuses WHERE Status = '{comboBoxStatusID.Text}'";
                SqlCommand commandStatus = new SqlCommand(queryStatus, dataBase.GetConnection());
                object resultStatus = commandStatus.ExecuteScalar();
                string statusID = resultStatus.ToString();
                string queryProduct = $"SELECT ProductID FROM Products WHERE Name = '{comboBoxProductIDOrders.Text}'";
                SqlCommand commandProduct = new SqlCommand(queryProduct, dataBase.GetConnection());
                object resultProduct = commandProduct.ExecuteScalar();
                string productID = resultProduct.ToString();
                string oooShnick = textBoxOOOShnick.Text;
                string addQuery = $@"INSERT INTO Orders
            (ClientID, OOOShnick, EmployeeID, OrderDate, StatusID, ProductID)
            VALUES
            ('{clientID}', '{oooShnick}', '{employeeID}', GETDATE(), '{statusID}', '{productID}')";

                SqlCommand sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Заказ успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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