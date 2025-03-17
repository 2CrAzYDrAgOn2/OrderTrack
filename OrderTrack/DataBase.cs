using System.Data.SqlClient;

namespace OrderTrack
{
    public class DataBase
    {
        private readonly SqlConnection sqlConnection = new(@"Data Source=DESKTOP-GQG9PFI\SQLEXPRESS;Initial Catalog=OrderTrack;Integrated Security=True");

        /// <summary>
        /// OpenConnection() вызывается при открытии соединения с базой данных
        /// </summary>
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        /// <summary>
        /// CloseConnection() вызывается при закрытии соединения с базой данных
        /// </summary>
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// GetConnection() вызывается при получении соединения с базой данных
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}