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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.username = Convert.ToString(tbUsername.Text);
            u.password = Convert.ToString(tbPassword.Text);

            if(tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Login gagal! Username/Password salah. Silahkan coba lagi.");
            }
            else
            {
                if(tbPassword.Text == "pbo123")
                {
                    this.Hide();
                    FormHome home = new FormHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Login gagal! Username/Password salah. Silahkan coba lagi.");
                }
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
