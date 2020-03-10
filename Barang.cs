using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Barang : UserControl
    {
        public Barang()
        {
            InitializeComponent();
        }

        public string judul { get; set; }
        public string harga { get; set; }
        public Image foto { get; set; }
        public string bbeli { get; set; }

        [Category("Custom Props")]
        public Barang(string judul, string harga, Image foto, string bbeli)
        {
            this.judul = judul;
            this.harga = harga;
            this.foto = foto;
            this.bbeli = bbeli;
        }

        private void btBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
