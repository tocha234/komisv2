using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Komis
{
    public partial class CarListing : Form
    {
        private MySqlConnection connection;
        private DataBaseManager databaseManager;

        public CarListing()
        {
            InitializeComponent();
            databaseManager = DataBaseManager.Instance;
            InitializeDatabaseConnection(); 
            LoadDataIntoDataGridView();
        }

        private void InitializeDatabaseConnection()
        {
            connection = databaseManager.GetConnection();
        }
        
        private void LoadDataIntoDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM samochody";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania danych: " + ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void BtnEditCar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {             
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                
                int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string TITLE = selectedRow.Cells["TITLE"].Value.ToString();
                string MAKE = selectedRow.Cells["MAKE"].Value.ToString();
                string MODEL = selectedRow.Cells["MODEL"].Value.ToString();
                string PROD_YEAR = selectedRow.Cells["PROD_YEAR"].Value.ToString();
                string MILEAGE = selectedRow.Cells["MILEAGE"].Value.ToString();
                string VIN_NUM = selectedRow.Cells["VIN_NUM"].Value.ToString();
                string COLOR = selectedRow.Cells["COLOR"].Value.ToString();
                string BODY_TYPE = selectedRow.Cells["BODY_TYPE"].Value.ToString();
                string Eng_Capacity = selectedRow.Cells["Eng_Capacity"].Value.ToString();
                string Eng_HP = selectedRow.Cells["Eng_HP"].Value.ToString();
                string TRANSMISSION = selectedRow.Cells["TRANS"].Value.ToString() ;
                string COUNTRY = selectedRow.Cells["COUNTRY"].Value.ToString();
                string PRICE = selectedRow.Cells["PRICE"].Value.ToString();
                
                AddCar formEdycji = new AddCar(ID,TITLE,MAKE,MODEL,PROD_YEAR,MILEAGE,VIN_NUM,COLOR,BODY_TYPE,Eng_Capacity,Eng_HP,TRANSMISSION,COUNTRY,PRICE);
                formEdycji.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego samochodu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarListing_Load(object sender, EventArgs e)
        {

        }
    }
}
