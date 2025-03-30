﻿using System.Data.SqlClient;

namespace OrderTrack
{
    public partial class AddFormEmployees : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormEmployees()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
                var fullNameEmployees = textBoxFullNameEmployees.Text;
                var phoneEmployees = maskedTextBoxPhoneEmployees.Text;
                var emailEmployees = textBoxEmailEmployees.Text;
                var gender = comboBoxGenderID.Text;
                string queryGender = $"SELECT GenderID FROM Genders WHERE Gender = '{gender}'";
                SqlCommand commandGender = new(queryGender, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultGender = commandGender.ExecuteScalar();
                var genderID = resultGender.ToString();
                var post = comboBoxPostID.Text;
                string queryPost = $"SELECT PostID FROM Posts WHERE Post = '{post}'";
                SqlCommand commandPost = new(queryPost, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultPost = commandPost.ExecuteScalar();
                var postID = resultPost.ToString();
                var addQuery = $"insert into Employees (FullName, Phone, Email, GenderID, PostID) values ('{fullNameEmployees}', '{phoneEmployees}', '{emailEmployees}', '{genderID}', '{postID}')";
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