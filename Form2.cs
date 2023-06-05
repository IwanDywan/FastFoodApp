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

namespace Restauracja_Fast_Food
{
    public partial class LoadData : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public LoadData()
        {
            InitializeComponent();
            con.ConnectionString = @"server=db4free.net;database=fastfoodapp;uid=iwandywan;password=12345678;";
        }

        private void LoadData_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                string query = "SELECT * FROM item_tbl";
                command.CommandText = query;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd!");
            }
            
        }
    }
}
