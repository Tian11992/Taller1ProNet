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
    public partial class VolumenCaja : Form
    {
        Volumen volumen = new Volumen();
        public VolumenCaja()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            volumen.setAltura(double.Parse(txtaltura.Text));
            volumen.setAncho(double.Parse(txtancho.Text));
            volumen.setLargo(double.Parse(txtlargo.Text));
            lbltotal.Text = "Total: "+volumen.calcular().ToString();
            lbltotal.Visible = true;
            txtaltura.Focus();
            txtaltura.Text = "";
            txtancho.Text = "";
            txtlargo.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
