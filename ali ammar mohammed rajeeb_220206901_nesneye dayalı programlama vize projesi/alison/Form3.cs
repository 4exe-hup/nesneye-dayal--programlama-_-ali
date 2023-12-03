using alison;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace alison
{



    public partial class Form3 : Form
    {


        private string selectedBuilding;
        public Form3(string selectedBuilding)
        {
            InitializeComponent();
            comboBox1.Items.Add("Ödendi");
            comboBox1.Items.Add("Ödenmedi");
            this.selectedBuilding = selectedBuilding;



            // buildings listesindeki bina adlarını bir ComboBox'a ekle
            //foreach (Building building in buildings)
            //{
            //   comboBox1.Items.Add(building.BuildingName);
            //}

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Yeni bir ListViewItem oluştur
            ListViewItem newItem = new ListViewItem();

            // ListViewItem'a sırasıyla kapı numarası, son ödeme tarihi ve durum ekleniyor
            newItem.Text = numericUpDown1.Value.ToString(); // Kapı Numarası
            newItem.SubItems.Add(dateTimePicker1.Value.ToShortDateString()); // Son Ödeme Tarihi
            newItem.SubItems.Add(comboBox1.SelectedItem.ToString()); // Durum

            // ListViewItem'ı ListView'e ekle
            listView1.Items.Add(newItem);

            // Giriş alanlarını temizle
            numericUpDown1.Value = 1;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Seçili item'ı kontrol et
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili item'ı kaldır
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}