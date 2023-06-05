using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restauracja_Fast_Food
{
    public partial class Form1 : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"server=db4free.net;database=fastfoodapp;uid=iwandywan;password=12345678;";
            //_database = new Database();
            //_database.Connect();
            //_database.test();
        }

        //private readonly Database _database;

        private void Form1_Load(object sender, EventArgs e)
        {
            //test podłączenia do bazy
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Połączono z bazą danych");
                con.Close();
            }
            else
            {
                MessageBox.Show("Nie połączono z bazą danych");
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void labelCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButtonFood_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFood.ForeColor = System.Drawing.Color.BlueViolet;
            radioButtonDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            comboBoxSelect.Items.Clear();
            comboBoxSelect.Items.Add("Food1");
            comboBoxSelect.Items.Add("Food2");
            comboBoxSelect.Items.Add("Food3");
        }

        private void radioButtonDrinks_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFood.ForeColor = System.Drawing.Color.RosyBrown;
            radioButtonDrinks.ForeColor = System.Drawing.Color.BlueViolet;
            comboBoxSelect.Items.Clear();
            comboBoxSelect.Items.Add("Drink1");
            comboBoxSelect.Items.Add("Drink2");
            comboBoxSelect.Items.Add("Drink3");
        }
        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelect.SelectedItem.ToString() == "Food1")
            {
                textBoxPrice.Text = "50";
            }
            else if (comboBoxSelect.SelectedItem.ToString() == "Food2")
            {
                textBoxPrice.Text = "100";
            }
            else if (comboBoxSelect.SelectedItem.ToString() == "Food3")
            {
                textBoxPrice.Text = "150";
            }
            else if (comboBoxSelect.SelectedItem.ToString() == "Drink1")
            {
                textBoxPrice.Text = "5";
            }
            else if (comboBoxSelect.SelectedItem.ToString() == "Drink2")
            {
                textBoxPrice.Text = "10";
            }
            else if (comboBoxSelect.SelectedItem.ToString() == "Drink3")
            {
                textBoxPrice.Text = "15";
            }
            else
            {
                textBoxPrice.Text = "0";
            }
            textBoxQuantity.Text = "";
            textBoxAmount.Text = "";
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if(textBoxQuantity.Text.Length > 0)
            {
                textBoxAmount.Text = (Convert.ToInt64(textBoxPrice.Text) * Convert.ToInt64(textBoxQuantity.Text)).ToString();
            }
        }
        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            //Dodanie danych do GridView
            dataGridView1.Rows.Add(comboBoxSelect.Text, textBoxPrice.Text, textBoxQuantity.Text, textBoxAmount.Text, dateTimePicker1.Text);
            //Sumowanie należności
            textBoxTotal.Text = (Convert.ToInt64(textBoxTotal.Text) + Convert.ToInt64(textBoxAmount.Text)).ToString();
            //Czyszczenie danych
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            textBoxAmount.Text = "";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Usuwanie danych z GridView
            if(dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        textBoxTotal.Text = (Convert.ToInt16(textBoxTotal.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void textBoxPay_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPay.Text.Length > 0)
            {
                textBoxRepay.Text = (Convert.ToInt16(textBoxTotal.Text) - Convert.ToInt16(textBoxPay.Text)).ToString();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Przesłanie danych do bazy 
            for(int i=0; i<dataGridView1.Rows.Count;i++)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO item_tbl Values('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie przesłano dane");
                con.Close();
            }
            dataGridView1.Rows.Clear();
            textBoxTotal.Text = "0";
            textBoxPay.Text = "";
            textBoxRepay.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBoxTotal.Text = "0";
            textBoxPay.Text = "";
            textBoxRepay.Text = "";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadData ldForm = new LoadData();
            ldForm.ShowDialog();
            ldForm = null;
            this.Show();
        }
    }
}
