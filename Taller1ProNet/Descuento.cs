using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1ProNet
{
    public partial class Descuento : Form
    {
        Iva descuento = new Iva();
        public Descuento()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            descuento.setNumerocompra(double.Parse(txtprecio.Text));
            lbldescuento.Text = "Descuento: "+descuento.descuento().ToString();
            lbliva.Text = "Total + Iva: "+descuento.total().ToString();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
