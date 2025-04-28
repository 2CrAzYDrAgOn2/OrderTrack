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
    public partial class AddFormMaterials : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormMaterials()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
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
                string name = textBoxNameMaterials.Text;
                string description = textBoxDescriptionMaterials.Text;
                string unit = textBoxUnit.Text;
                string quantity = textBoxCurrentQuantity.Text;
                string addQuery = $@"INSERT INTO Materials
            (Name, Description, Unit, CurrentQuantity)
            VALUES
            ('{name}', '{description}', '{unit}', '{quantity}')";
                SqlCommand sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Материал успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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