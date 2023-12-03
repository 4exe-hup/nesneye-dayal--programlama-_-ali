using alison;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace alison
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
        public void UpdateListView(string buildingName)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.Text = buildingName;

            listView1.Items.Add(newItem);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili öðenin bina ismini al
                string selectedBuilding = listView1.SelectedItems[0].Text;

                // Yeni bir form oluþtur ve seçili binanýn adýný ileterek aç
                Form3 form3 = new Form3(selectedBuilding);
                form3.Show();
                this.Hide();
            }
        }
    }
}