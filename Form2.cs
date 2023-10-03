using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace appkonversi
{
    public partial class Form2 : Form
    {

        bool sidebarExpand;
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox2.Text);

            double hasil = 0;

            if (value1 == "Km")
            {
                if (value2 == "Km")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "Hm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "Dam")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 10000;
                }
            }

            if (value1 == "m")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 1000;
                }
            }

            if (value1 == "Dm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "Cm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 10;
                }
            }

            if (value1 == "Mm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "Dm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "Cm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "Mm")
                {
                    hasil = angka * 1;
                }
            }
            textBox5.Text = hasil.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
                string value1 = comboBox3.SelectedItem.ToString();
                string value2 = comboBox4.SelectedItem.ToString();
                double n_wk = double.Parse(textBox3.Text);
                double h_wk = 0;

                if (value1 == "milidetik")
                {
                    if (value2 == "milidetik")
                    {
                        h_wk = n_wk;
                    }

                    else
                    if (value2 == "detik")
                    {
                        h_wk = n_wk / 1000;
                    }

                    else
                    if (value2 == "menit")
                    {
                        h_wk = n_wk / (1000 * 60);
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk / (60000 * 60);
                    }
                    else
                    {
                        MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                    }


                }
                else
                if (value1 == "detik")
                {
                    if (value2 == "milidetik")
                    {
                        h_wk = n_wk * 1000;
                    }

                    else
                    if (value2 == "detik")
                    {
                        h_wk = n_wk;
                    }

                    else
                    if (value2 == "menit")
                    {
                        h_wk = n_wk / 60;
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk / (60 * 60);
                    }
                    else
                    if (value2 == "hari")
                    {
                        h_wk = n_wk / (3600 * 24);
                    }
                    if (value2 == "minggu")
                    {
                        h_wk = n_wk / (3600 * 24 * 7);
                    }
                    if (value2 == "bulan")
                    {
                        h_wk = n_wk / (3600 * 24 * 7 * 30);
                    }
                    if (value2 == "tahun")
                    {
                        h_wk = n_wk / (3600 * 24 * 7 * 30 * 12);
                    }
                }
                else
                if (value1 == "menit")
                {
                    if (value2 == "milidetik")
                    {
                        h_wk = n_wk * 60000;
                    }

                    else
                    if (value2 == "detik")
                    {
                        h_wk = n_wk * 60;
                    }

                    else
                    if (value2 == "menit")
                    {
                        h_wk = n_wk;
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk / 60;
                    }
                    else
                    if (value2 == "hari")
                    {   
                        h_wk = n_wk / (60 * 24);
                    }
                    if (value2 == "minggu")
                    {
                        h_wk = n_wk / (60 * 24 * 7);
                    }
                    if (value2 == "bulan")
                    {
                        h_wk = n_wk / (60 * 24 * 7 * 30);
                    }
                    if (value2 == "tahun")
                    {
                        h_wk = n_wk / (60 * 24 * 7 * 30 * 12);
                    }
                }
                else
                if (value1 == "jam")
                {
                    if (value2 == "milidetik")
                    {
                        h_wk = n_wk * (60000 * 60);
                    }

                    else
                    if (value2 == "detik")
                    {
                        h_wk = n_wk * (60 * 60);
                    }

                    else
                    if (value2 == "menit")
                    {
                        h_wk = n_wk * 60;
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk;
                    }
                    else
                    if (value2 == "hari")
                    {
                        h_wk = n_wk / 24;
                    }
                    if (value2 == "minggu")
                    {
                        h_wk = n_wk / (24 * 7);
                    }
                    if (value2 == "bulan")
                    {
                        h_wk = n_wk / (24 * 7 * 30);
                    }
                    if (value2 == "tahun")
                    {
                        h_wk = n_wk / (24 * 7 * 30 * 12);
                    }
                }
                else
                if (value1 == "hari")
                {
                    if (value2 == "detik")
                    {
                        h_wk = n_wk * (60 * 60 * 24);
                    }

                    else
                    if (value2 == "menit")
                    {
                        h_wk = n_wk * 1440;
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk * 24;
                    }
                    else
                    if (value2   == "hari")
                    {
                        h_wk = n_wk;
                    }
                    else
                    if (value2 == "minggu")
                    {
                        h_wk = n_wk / 7;
                    }
                    else
                    if (value2 == "bulan")
                    {
                        h_wk = n_wk / 30;
                    }
                    else
                    if (value2 == "tahun")
                    {
                        h_wk = n_wk / 365;
                    }
                    else
                    {
                        MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                    }
                }
                else
                if (value1 == "minggu")
                {
                    if (value2 == "detik")
                    {
                        h_wk = n_wk * 604800;
                    }

                    else
                    if (value2 == "menit")
                    {
                        h_wk = n_wk * 10080;
                    }

                    else
                    if (value2 == "jam")
                    {   
                        h_wk = n_wk * 168;
                    }
                    else
                    if (value2 == "hari")
                    {
                        h_wk = n_wk * 7;
                    }
                    else
                    if (value2 == "minggu")
                    {   
                        h_wk = n_wk;
                    }
                    else
                    if (value2 == "bulan")
                    {
                        h_wk = n_wk / 4.345;
                    }
                    else
                    if (value2 == "tahun")
                    {   
                        h_wk = n_wk / 52.143;
                    }
                    else
                    {
                        MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                    }
                }
                else
                if (value1 == "bulan")
                {
                    if (value2 == "menit")
                    {
                        h_wk = n_wk * 43800;
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk * 730;
                    }
                    else
                    if (value2 == "hari")
                    {
                        h_wk = n_wk * 30;
                    }
                    else
                    if (value2 == "minggu")
                    {
                        h_wk = n_wk * 4.345;
                    }
                    else
                    if (value2 == "bulan")
                    {   
                        h_wk = n_wk;
                    }
                    else
                    if (value2 == "tahun")
                    {
                        h_wk = n_wk / 12;
                    }
                    else
                    {
                        MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                    }
                }

                else
                if (value1 == "tahun")
                {
                    if (value2 == "menit")
                    {
                        h_wk = n_wk * 525600;
                    }

                    else
                    if (value2 == "jam")
                    {
                        h_wk = n_wk * 6760;
                    }
                    else
                    if (value2 == "hari")
                    {
                        h_wk = n_wk * 365;
                    }
                    else
                    if (value2 == "minggu")
                    {
                        h_wk = n_wk * 52.1429;
                    }
                    else
                    if (value2 == "bulan")
                    {
                        h_wk = n_wk * 12;
                    }
                    else
                    if (value2 == "tahun")
                    {
                        h_wk = n_wk;
                    }
                    else
                    {
                        MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                    }
                }

                textBox4.Text = FormatNumber(h_wk);
            
        }

        private string FormatNumber(double number)
        {
            // Format angka sebagai string dengan tanda titik untuk setiap tiga digit
            return number.ToString("#,0.########"); // Menggunakan format kustom
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage4);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton13_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panel1.Width -= 10;
                if (panel1.Width == panel1.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panel1.Width += 10;
                if (panel1.Width == panel1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click_3(object sender, EventArgs e)
        {

        }

        private void button6_Click_4(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string value1 = comboBox6.SelectedItem.ToString();
            string value2 = comboBox5.SelectedItem.ToString();
            double angka = double.Parse(textBox6.Text);
            double hasil = 0;

            if (value1 == "Kg")
            {
                if (value2 == "Kg")
                {
                    hasil = angka * 1;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka * 10;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka * 100;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka * 1000;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka * 10000;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka * 100000;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "Hg")
            {
                if (value2 == "Kg")
                {
                    hasil = angka / 10;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka * 1;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka * 10;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka * 100;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka * 1000;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka * 10000;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "Dag")
            {
                if (value2 == "Kg")
                {
                    hasil = angka / 100;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka / 10;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka * 1;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka * 10;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka * 100;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka * 1000;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 10000;
                }
            }

            if (value1 == "G")
            {
                if (value2 == "Kg")
                {
                    hasil = angka / 1000;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka / 100;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka / 10;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka * 1;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka * 10;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka * 100;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 1000;
                }
            }

            if (value1 == "Dg")
            {
                if (value2 == "Kg")
                {
                    hasil = angka / 10000;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka / 1000;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka / 100;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka / 10;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka * 1;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka * 10;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "Cg")
            {
                if (value2 == "Kg")
                {
                    hasil = angka / 100000;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka / 10000;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka / 1000;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka / 100;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka / 10;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka * 1;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 10;
                }
            }

            if (value1 == "Mg")
            {
                if (value2 == "Kg")
                {
                    hasil = angka / 1000000;
                }

                else
                if (value2 == "Hg")
                {
                    hasil = angka / 100000;
                }

                else
                if (value2 == "Dag")
                {
                    hasil = angka / 10000;
                }

                else
                if (value2 == "G")
                {
                    hasil = angka / 1000;
                }

                else
                if (value2 == "Dg")
                {
                    hasil = angka / 100;
                }

                else
                if (value2 == "Cg")
                {
                    hasil = angka / 10;
                }

                else
                if (value2 == "Mg")
                {
                    hasil = angka * 1;
                }
            }
            textBox1.Text = hasil.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_5(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox1.Text = "";
            comboBox6.Text = "";
            comboBox5.Text = "";
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string value1 = comboBox8.SelectedItem.ToString();
            string value2 = comboBox7.SelectedItem.ToString();

            double angka = double.Parse(textBox8.Text);

            double hasil = 0;

            if (value1 == "Celcius")
            {
                if (value2 == "Celcius")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Fahrenheit")
                {
                    hasil = angka * 9 / 5 + 32;
                }
                else if (value2 == "Reamur")
                {
                    hasil = angka * 4 / 5;
                }
                else if (value2 == "Kelvin")
                {
                    hasil = angka + 273;
                }
            }

            if (value1 == "Fahrenheit")
            {
                if (value2 == "Celcius")
                {
                    hasil = (angka - 32) * 5 / 9;
                }
                else if (value2 == "Fahrenheit")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Reamur")
                {
                    hasil = (angka - 32) * 4 / 9;
                }
                else if (value2 == "Kelvin")
                {
                    hasil = (angka - 32) * 5 /9 + 273;
                }
            }

            if (value1 == "Reamur")
            {
                if (value2 == "Celcius")
                {
                    hasil = angka * 5 / 4;
                }
                else if (value2 == "Fahrenheit")
                {
                    hasil = (angka + 32) * 9 / 4;
                }
                else if (value2 == "Reamur")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Kelvin")
                {
                    hasil = (angka + 273) * 5 / 4;
                }
            }

            if (value1 == "Kelvin")
            {
                if (value2 == "Celcius")
                {
                    hasil = angka - 273;
                }
                else if (value2 == "Fahrenheit")
                {
                    hasil = (angka - 273) * 9 / 5 + 32 ;
                }
                else if (value2 == "Reamur")
                {
                    hasil = (angka - 273) * 4 / 5;
                }
                else if (value2 == "Kelvin")
                {
                    hasil = angka * 1;
                }
            }
            textBox7.Text = hasil.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox7.Text = "";
            comboBox8.Text = "";
            comboBox7.Text = "";
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
