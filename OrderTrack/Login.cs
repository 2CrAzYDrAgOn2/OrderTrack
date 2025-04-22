using System.Data;
using System.Data.SqlClient;

namespace OrderTrack
{
    public partial class Login : Form
    {
        private readonly DataBase dataBase = new();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            var loginUser = textBoxLogin.Text;
            var passwordUser = textBoxPassword.Text;
            SqlDataAdapter sqlDataAdapter = new();
            DataTable dataTable = new();
            string querystring = $"select RegistrationID, UserLogin, UserPassword, IsAdmin from Registration where UserLogin = '{loginUser}' and UserPassword = '{passwordUser}'";
            SqlCommand sqlCommand = new(querystring, dataBase.GetConnection());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new(Convert.ToBoolean(dataTable.Rows[0]["IsAdmin"]));
                Hide();
                form1.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LabelAuth_Click(object sender, EventArgs e)
        {
            Signup formLogin = new();
            Hide();
            formLogin.ShowDialog();
            Show();
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