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
                var client = comboBoxClientIDOrders.Text;
                string queryClient = $"SELECT ClientID FROM Clients WHERE FullName = '{client}'";
                SqlCommand commandClient = new(queryClient, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultClient = commandClient.ExecuteScalar();
                var clientIDOrders = resultClient.ToString();
                var employee = comboBoxEmployeeIDOrders.Text;
                string queryEmployee = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employee}'";
                SqlCommand commandEmployee = new(queryEmployee, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultEmployee = commandEmployee.ExecuteScalar();
                var employeeIDOrders = resultEmployee.ToString();
                var status = comboBoxStatusID.Text;
                string queryStatus = $"SELECT StatusID FROM Statuses WHERE Status = '{status}'";
                SqlCommand commandStatus = new(queryStatus, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultStatus = commandStatus.ExecuteScalar();
                var statusID = resultStatus.ToString();
                var addQuery = $"insert into Orders (ClientID, EmployeeID, StatusID) values ('{clientIDOrders}', '{employeeIDOrders}', '{statusID}')";
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