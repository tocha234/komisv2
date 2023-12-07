using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Komis
{
    public partial class AddCar : Form
    {
        public AddCar(int id, string title, string make, string model, string prodYear, string mileage, string vinNum, string color, string bodyType, string engCapacity, string engHP, string transmission, string country, string price)

        {
            InitializeComponent();

            
            txtTitle.Text = title;
            boxMake.Text = make;
            boxModel.Text = model;
            boxYear.Text = prodYear;
            txtMil.Text = mileage;
            txtVin.Text = vinNum;
            txtColor.Text = color;
            boxBody.SelectedItem = bodyType;
            txtEngC.Text = engCapacity;
            txtEngHP.Text = engHP;
            boxTrans.SelectedItem = transmission;
            boxCountry.SelectedItem = country;
            txtPrice.Text = price;
        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelectImages_Click(object sender, EventArgs e)
        {
            
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.Multiselect = true;
          openFileDialog.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    string[] sciezkiDoZdjec = openFileDialog.FileNames;

                    // Przypisz wybrane zdjęcia do PictureBox-ów
                    for (int i = 0; i < sciezkiDoZdjec.Length && i < 6; i++)
                    {
                        // Utwórz obiekt Image na podstawie ścieżki do pliku
                        Image obraz = new Bitmap(sciezkiDoZdjec[i]);

                        // Przypisz obraz do odpowiedniego PictureBox-a
                        if (i == 0) pictureBox1.Image = obraz;
                        else if (i == 1) pictureBox2.Image = obraz;
                        else if (i == 2) pictureBox3.Image = obraz;
                        else if (i == 3) pictureBox4.Image = obraz;
                        else if (i == 4) pictureBox5.Image = obraz;
                        else if (i == 5) pictureBox6.Image = obraz;
                    }
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newTitle = txtTitle.Text;
            string newMake = boxMake.Text;
            string newModel = boxModel.Text;
            string newYear = boxYear.Text;
            string newMil = txtMil.Text;
            string newVin = txtVin.Text;
            string newColor = txtColor.Text;
            string newBody = boxBody.SelectedItem?.ToString();
            string newEngC = txtEngC.Text;
            string newEngHp = txtEngHP.Text;
            string newTrans = boxTrans.SelectedItem?.ToString();
            string newCountry = boxCountry.SelectedItem?.ToString();
            string newPrice = txtPrice.Text;
            
            if (newTitle != txtTitle.Text || newMake != boxMake.Text || newModel != boxModel.Text || newYear != boxYear.Text || newMil != txtMil.Text || newVin != txtVin.Text || newColor != txtColor.Text || newBody != boxBody.Text ||
                newEngC != txtEngC.Text || newEngHp != txtEngHP.Text || newTrans != boxTrans.Text || newCountry != boxCountry.Text || newPrice != txtPrice.Text)
            {
                // Wykryto zmiany w danych, więc wykonaj aktualizację
               // UpdateCarInDatabase(nowaMarka, nowyModel, /* pozostałe nowe dane */);

                MessageBox.Show("Zaktualizowano dane samochodu.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Brak zmian w danych samochodu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
