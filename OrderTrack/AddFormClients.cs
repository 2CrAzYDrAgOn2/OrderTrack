using System.Data.SqlClient;

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
                var fullName = textBoxFullNameClients.Text;
                var clientType = comboBoxClientTypeID.Text;
                string query = $"SELECT ClientTypeID FROM ClientTypes WHERE ClientType = '{clientType}'";
                SqlCommand command = new(query, dataBase.GetConnection());
                dataBase.OpenConnection();
                object result = command.ExecuteScalar();
                var clientTypeID = result.ToString();
                var email = textBoxEmailClients.Text;
                var phone = maskedTextBoxPhoneClients.Text;
                var address = textBoxAddress.Text;
                var iNN = textBoxINN.Text;
                var addQuery = $"insert into Clients (FullName, ClientTypeID, Email, Phone, Address, INN) values ('{fullName}', '{clientTypeID}', '{email}', '{phone}', '{address}', '{iNN}')";
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