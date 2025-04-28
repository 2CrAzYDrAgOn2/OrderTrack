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
    public partial class AddFormOrderEstimateDetails : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormOrderEstimateDetails()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxOrderEstimateIDOrderEstimateDetails.Items.Clear();
            var orderEstimateIDsQuery = "SELECT OrderEstimateID FROM OrderEstimates ORDER BY OrderEstimateID";
            var orderEstimateIDsCommand = new SqlCommand(orderEstimateIDsQuery, dataBase.GetConnection());
            var orderEstimateIDsReader = orderEstimateIDsCommand.ExecuteReader();
            while (orderEstimateIDsReader.Read())
            {
                comboBoxOrderEstimateIDOrderEstimateDetails.Items.Add(orderEstimateIDsReader.GetInt32(0));
            }
            orderEstimateIDsReader.Close();

            comboBoxMaterialIDOrderEstimateDetails.Items.Clear();
            var materialsQuery = "SELECT Name FROM Materials ORDER BY Name";
            var materialsCommand = new SqlCommand(materialsQuery, dataBase.GetConnection());
            var materialsReader = materialsCommand.ExecuteReader();
            while (materialsReader.Read())
            {
                comboBoxMaterialIDOrderEstimateDetails.Items.Add(materialsReader.GetString(0));
            }
            materialsReader.Close();
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
                string queryMaterial = $"SELECT MaterialID FROM Materials WHERE Name = '{comboBoxMaterialIDOrderEstimateDetails.Text}'";
                SqlCommand commandMaterial = new SqlCommand(queryMaterial, dataBase.GetConnection());
                object resultMaterial = commandMaterial.ExecuteScalar();
                string materialID = resultMaterial.ToString();
                string estimateID = comboBoxOrderEstimateIDOrderEstimateDetails.Text;
                string quantity = textBoxQuantinityOrderEstimateDetails.Text;
                string addQuery = $@"INSERT INTO OrderEstimateDetails
            (OrderEstimateID, MaterialID, Quantity)
            VALUES
            ('{estimateID}', '{materialID}', '{quantity}')";

                SqlCommand sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Деталь сметы успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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