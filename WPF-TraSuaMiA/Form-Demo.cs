using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_TraSuaMiA
{
    public partial class Form_Demo : Form
    {
        public Form_Demo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Warehouse f = new Form_Warehouse();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            Form_Menu f = new Form_Menu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Form_Sell f = new Form_Sell();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form_Admin f = new Form_Admin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
