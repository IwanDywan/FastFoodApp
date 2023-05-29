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
    public partial class UCDrinks : UserControl
    {
        public UCDrinks()
        {
            InitializeComponent();
            comboBox1.Items.Add("Drink1");
            comboBox1.Items.Add("Drink2");
            comboBox1.Items.Add("Drink3");
        }
    }
}
