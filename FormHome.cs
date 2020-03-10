using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormHome : Form
    {
        public Barang[] barang = new Barang[6];

        public FormHome()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin li = new FormLogin();
            li.Show();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btBeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void btKatalog_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://shopee.co.id/kpop.sale");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void pbBeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void pbKatalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCari_Click(object sender, EventArgs e)
        {

        }

        private void pbKatalog_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://shopee.co.id/kpop.sale");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

   
    }
}
