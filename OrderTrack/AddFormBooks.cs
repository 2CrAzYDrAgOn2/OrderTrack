using System.Data.SqlClient;

namespace OrderTrack
{
    public partial class AddFormBooks : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormBooks()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var title = textBoxTitleBooks.Text;
                var author = textBoxAuthorBooks.Text;
                var genre = textBoxGenreBooks.Text;
                var publishedYear = textBoxPublishedYearBooks.Text;
                var iSBN = textBoxISBNBooks.Text;
                var copiesAvailable = textBoxCopiesAvailableBooks.Text;
                var addQuery = $"insert into Books (Title, Author, Genre, PublishedYear, ISBN, CopiesAvailable) values ('{title}', '{author}', '{genre}', '{publishedYear}', '{iSBN}', '{copiesAvailable}')";
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