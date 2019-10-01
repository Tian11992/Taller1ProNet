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
    public partial class OpcionEdadEnSegundos : Form
    {
        Segundos segundos = new Segundos();
        public OpcionEdadEnSegundos()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            segundos.setNumeronac(int.Parse(txtaño.Text));
            lbledad.Text = "Su edad es: "+segundos.calcular().ToString();
            lblsegundos.Text = "Su edad en segundos es: "+segundos.segundos().ToString();

            txtaño.Focus();
            txtaño.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
