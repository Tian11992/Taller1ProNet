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
    public partial class Raiz : Form
    {
        RaizCuadrada raiz = new RaizCuadrada();
        public Raiz()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            raiz.setNumero1(double.Parse(txtraiz.Text));
            lblresultado.Text = "La raiz cuadrada de "+txtraiz.Text+" es: " + raiz.calcular().ToString();
            lblresultado.Visible = true;
            txtraiz.Text = "";
            txtraiz.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
