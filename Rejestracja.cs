using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }
        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //email
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //pwd
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegisterNewUser_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredEmail = txtEmail.Text;
            string enteredPwd = txtPwd.Text;

            if (!string.IsNullOrEmpty(enteredUsername) && !string.IsNullOrEmpty(enteredEmail) && !string.IsNullOrEmpty(enteredPwd))
            {
                if (CheckUserInfo(enteredUsername, enteredEmail, enteredPwd))
                {
                    this.Close();
                    OpenLoginPanel();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Użytkownik o podanej nazwie lub emailu już istnieje.", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUserInfo(string userName, string email, string pwd)
        {
            string query = "SELECT * FROM uzytkownicy WHERE username = @Username OR email = @Email";

            MySqlCommand command = new MySqlCommand(query, DataBaseManager.Instance.GetConnection());

            command.Parameters.AddWithValue("@Username", userName);
            command.Parameters.AddWithValue("@Email", email);

            try
            {
                DataBaseManager.Instance.GetConnection().Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {                  
                    return false;
                }
                else
                {
                    AddUserToDatabase(userName, email, pwd);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas sprawdzania użytkownika w bazie danych: " + ex.Message);
                return false;
            }
            finally
            {
                DataBaseManager.Instance.GetConnection().Close();
            }
        }

        private void AddUserToDatabase(string userName, string email, string pwd)
        {
            string insertQuery = "INSERT INTO uzytkownicy (username, email, pwd) VALUES (@Username, @Email, @Password)";

            MySqlCommand insertCommand = new MySqlCommand(insertQuery, DataBaseManager.Instance.GetConnection());

            insertCommand.Parameters.AddWithValue("@Username", userName);
            insertCommand.Parameters.AddWithValue("@Email", email);
            insertCommand.Parameters.AddWithValue("@Password", pwd);

            try
            {
                DataBaseManager.Instance.GetConnection().Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania użytkownika do bazy danych: " + ex.Message);
            }
            finally
            {
                DataBaseManager.Instance.GetConnection().Close();
            }
        }

        private void OpenLoginPanel()
        {
            Logowanie loginForm = new Logowanie();
            loginForm.Show();
            this.Hide();
        }

        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            Logowanie loginPanelForm = new Logowanie();
            loginPanelForm.ShowDialog();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
