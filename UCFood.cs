using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja_Fast_Food
{
    public partial class UCFood : UserControl
    {
        public UCFood()
        {
            InitializeComponent();
            comboBox1.Items.Add("Food1");
            comboBox1.Items.Add("Food2");
            comboBox1.Items.Add("Food3");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Food1")
            {
                textBox1.Text = "50";
            }else if (comboBox1.SelectedItem.ToString() == "Food2")
            {
                textBox1.Text = "100";
            }
            else if (comboBox1.SelectedItem.ToString() == "Food3")
            {
                textBox1.Text = "150";
            }
            else
            {
                textBox1.Text = "0";
            }

            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0)
            {
                textBox3.Text = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
