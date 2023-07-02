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
        }

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
            radioButtonFood.Checked = true;
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
            loadMenu();
        }

        private void radioButtonDrinks_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFood.ForeColor = System.Drawing.Color.RosyBrown;
            radioButtonDrinks.ForeColor = System.Drawing.Color.BlueViolet;
            comboBoxSelect.Items.Clear();
            loadMenu();
        }
        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            short id = 0;
            if(radioButtonFood.Checked){
                if (comboBoxSelect.SelectedItem.ToString() == "Frytki")
                {
                    id = showName("food", comboBoxSelect.SelectedItem.ToString());
                }
                else if (comboBoxSelect.SelectedItem.ToString() == "Hamburger")
                {
                    id = showName("food", comboBoxSelect.SelectedItem.ToString());
                }
                else if (comboBoxSelect.SelectedItem.ToString() == "Pizza")
                {
                    id = showName("food", comboBoxSelect.SelectedItem.ToString());
                }
                else
                {
                    textBoxPrice.Text = "0";
                }
                showPrice("food", id);
            }
            else if(radioButtonDrinks.Checked)
            {
                if (comboBoxSelect.SelectedItem.ToString() == "Woda")
                {
                    id = showName("drinks", comboBoxSelect.SelectedItem.ToString()); 
                }
                else if (comboBoxSelect.SelectedItem.ToString() == "Cola")
                {
                    id = showName("drinks", comboBoxSelect.SelectedItem.ToString()); 
                }
                else if (comboBoxSelect.SelectedItem.ToString() == "Sok")
                {
                    id = showName("drinks", comboBoxSelect.SelectedItem.ToString()); 
                }
                else
                {
                    textBoxPrice.Text = "0";
                }
                showPrice("drinks", id);
            }
            else
            {
                textBoxPrice.Text = "---";
            }
            textBoxQuantity.Text = "";
            textBoxAmount.Text = "";
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if(textBoxQuantity.Text.Length > 0)
            {
                try
                {
                    textBoxAmount.Text = (Convert.ToInt64(textBoxPrice.Text) * Convert.ToInt64(textBoxQuantity.Text)).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            if(textBoxQuantity.Text.ToString() != "0")
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
            else
            {
                MessageBox.Show("Nie można kupić 0 produtków");
            }
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
                con.Close();
            }
            MessageBox.Show("Pomyślnie przesłano dane");
            clearGridView();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearGridView();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadData ldForm = new LoadData();
            ldForm.ShowDialog();
            ldForm = null;
            this.Show();
        }

        void loadMenu()
        {
            if(radioButtonFood.Checked) 
            {
                string cmdFoodQuery = "SELECT name FROM fastfoodapp.food_menu";
                MySqlCommand cmd = new MySqlCommand(cmdFoodQuery, con);
                MySqlDataReader mySqlDataReader;
                try
                {
                    con.Open();
                    mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        string item = mySqlDataReader.GetString("name");
                        comboBoxSelect.Items.Add(item);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(radioButtonDrinks.Checked)
            {
                string cmdFoodQuery = "SELECT name FROM fastfoodapp.drinks_menu";
                MySqlCommand cmd = new MySqlCommand(cmdFoodQuery, con);
                MySqlDataReader mySqlDataReader;
                try
                {
                    con.Open();
                    mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        string item = mySqlDataReader.GetString("name");
                        comboBoxSelect.Items.Add(item);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                comboBoxSelect.Items.Add("---");
            }           
        }
        void clearGridView()
        {
            dataGridView1.Rows.Clear();
            textBoxTotal.Text = "0";
            textBoxPay.Text = "";
            textBoxRepay.Text = "";
        }

        void showPrice(String menu, short id)
        {
            string cmdFoodQuery = "SELECT price FROM fastfoodapp."+menu+"_menu WHERE id=" + id.ToString();
            MySqlCommand cmd = new MySqlCommand(cmdFoodQuery, con);
            MySqlDataReader mySqlDataReader;
            try
            {
                con.Open();
                mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string price = mySqlDataReader.GetString("price");
                    textBoxPrice.Text = price;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        short showName(String menu, String name)
        {
            short id = 0;
            string cmdFoodQuery = "SELECT id FROM "+menu+"_menu WHERE name=\""+name+"\"";
            MySqlCommand cmd = new MySqlCommand(cmdFoodQuery, con);
            MySqlDataReader mySqlDataReader;
            try
            {
                con.Open();
                mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    id = Convert.ToInt16(mySqlDataReader.GetString("id"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }
    }
}
