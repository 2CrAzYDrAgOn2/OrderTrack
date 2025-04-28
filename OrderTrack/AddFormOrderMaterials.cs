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
    public partial class AddFormOrderMaterials : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormOrderMaterials()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxMaterialIDOrderMaterials.Items.Clear();
            var materialsForOrderQuery = "SELECT Name FROM Materials ORDER BY Name";
            var materialsForOrderCommand = new SqlCommand(materialsForOrderQuery, dataBase.GetConnection());
            var materialsForOrderReader = materialsForOrderCommand.ExecuteReader();
            while (materialsForOrderReader.Read())
            {
                comboBoxMaterialIDOrderMaterials.Items.Add(materialsForOrderReader.GetString(0));
            }
            materialsForOrderReader.Close();
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
                string queryMaterial = $"SELECT MaterialID FROM Materials WHERE Name = '{comboBoxMaterialIDOrderMaterials.Text}'";
                SqlCommand commandMaterial = new SqlCommand(queryMaterial, dataBase.GetConnection());
                object resultMaterial = commandMaterial.ExecuteScalar();
                string materialID = resultMaterial.ToString();
                string quantity = textBoxQuantinityOrderMaterials.Text;
                string addQuery = $@"INSERT INTO OrderMaterials
            (MaterialID, Quantity, RequestDate)
            VALUES
            ('{materialID}', '{quantity}', GETDATE())";

                SqlCommand sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Заказ материала успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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