using System.Data;
using System.Data.SqlClient;

namespace OrderTrack
{
    public partial class Signup : Form
    {
        private readonly DataBase dataBase = new();

        public Signup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            buttonShow.BackgroundImage = Properties.Resources.ShowPassword0;
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            SqlDataAdapter sqlDataAdapter = new();
            DataTable dataTable = new();
            string querystringUsers = $"SELECT UserLogin FROM Registration WHERE UserLogin = '{login}'";
            SqlCommand sqlCommandUsers = new(querystringUsers, dataBase.GetConnection());
            sqlDataAdapter.SelectCommand = sqlCommandUsers;
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует!", "Ошибка!");
            }
            else
            {
                string querystring = $"INSERT INTO Registration(UserLogin, UserPassword) VALUES('{login}', '{password}')";
                SqlCommand sqlCommand = new(querystring, dataBase.GetConnection());
                dataBase.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1 && textBoxLogin.Text != "")
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                    Login formLogin = new();
                    Close();
                    formLogin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!");
                }
                dataBase.CloseConnection();
            }
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '•')
            {
                buttonShow.BackgroundImage = Properties.Resources.ShowPassword0;
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                buttonShow.BackgroundImage = Properties.Resources.ShowPassword1;
                textBoxPassword.PasswordChar = '•';
            }
        }
    }
}