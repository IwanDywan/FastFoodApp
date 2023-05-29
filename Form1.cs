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

            _database = new Database();
            _database.Connect();
            _database.test();
        }

        private readonly Database _database;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUC(UserControl uc)
        {
            panelCenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(uc);
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonHome);
            panelCenter.Controls.Clear();
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonFood);
            UCFood uCFood = new UCFood();
            addUC(uCFood);

        }
        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonDrinks);
            UCDrinks uCDrinks = new UCDrinks();
            addUC(uCDrinks);
        }

        private void buttonReserv_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonReserv);
            panelCenter.Controls.Clear();
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonContact);
            panelCenter.Controls.Clear();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonAbout);
            panelCenter.Controls.Clear();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
