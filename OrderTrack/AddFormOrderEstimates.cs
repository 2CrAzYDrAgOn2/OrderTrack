using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTrack
{
    public partial class AddFormOrderEstimates : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormOrderEstimates()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxOrderIDOrderEstimates.Items.Clear();
            var orderEstimatesQuery = "SELECT OrderID FROM Orders ORDER BY OrderID";
            var orderEstimatesCommand = new SqlCommand(orderEstimatesQuery, dataBase.GetConnection());
            var orderEstimatesReader = orderEstimatesCommand.ExecuteReader();
            while (orderEstimatesReader.Read())
            {
                comboBoxOrderIDOrderEstimates.Items.Add(orderEstimatesReader.GetInt32(0));
            }
            orderEstimatesReader.Close();
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
                string orderID = comboBoxOrderIDOrderEstimates.Text;
                string addQuery = $@"INSERT INTO OrderEstimates
            (OrderID, OrderEstimateDate)
            VALUES
            ('{orderID}', GETDATE())";
                SqlCommand sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Смета успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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