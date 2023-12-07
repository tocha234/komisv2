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
    public partial class Logowanie : Form
    {
        private MySqlConnection connection; 
        private DataBaseManager databaseManager;


        public Logowanie()
        {
            InitializeComponent();
            databaseManager = DataBaseManager.Instance;
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            connection = databaseManager.GetConnection();
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //username textbox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //password textbox2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoginUser_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
           
            if (CheckUserCredentials(enteredUsername, enteredPassword))
            {
                this.Close();

                OpenMainMenu(); 
            }
            else
            {                
                MessageBox.Show("Nieprawidłowy użytkownik lub hasło. Spróbuj ponownie.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenMainMenu()
        {
            Main mainMenu = new Main();
            mainMenu.Show();
        }

        private bool CheckUserCredentials(string username, string password)
        {
            string query = "SELECT * FROM uzytkownicy WHERE username = @Username AND password = @Password";

            MySqlCommand command = new MySqlCommand(query, DataBaseManager.Instance.GetConnection());

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            DataBaseManager.Instance.GetConnection().Open();

            MySqlDataReader reader = command.ExecuteReader();

            bool userExists = reader.HasRows;

            reader.Close();
            DataBaseManager.Instance.GetConnection().Close();

            return userExists;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegisterPanel_Click(object sender, EventArgs e)
        {
            Rejestracja RegisterPanelForm = new Rejestracja();
            RegisterPanelForm.Show();
            this.Hide();
        }
    }
}
