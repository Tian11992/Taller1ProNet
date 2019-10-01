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
    public partial class Llamadas : Form
    {

        CostoLlamada costo = new CostoLlamada();

        public Llamadas()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            costo.setdestino(cmbdestino.Text);
            costo.setduracion(double.Parse(txtduracion.Text));
            lbltotal.Text = "El costo de la llamada es: $"+costo.totalapagar().ToString();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
