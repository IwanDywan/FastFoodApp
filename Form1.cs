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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonHome);
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonFood);
        }
        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonDrinks);
        }

        private void buttonReserv_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonReserv);
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonContact);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonAbout);
        }

        private void labelCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveSidePanel(Button btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }
    }
}
