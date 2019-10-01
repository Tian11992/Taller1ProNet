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
    public partial class PromedioNotas : Form
    {
        Promedio promedio = new Promedio();
        public PromedioNotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            promedio.setNota1(double.Parse(txtnota1.Text));
            promedio.setNota2(double.Parse(txtnota2.Text));
            promedio.setNota3(double.Parse(txtnota3.Text));
            promedio.setNota4(double.Parse(txtnota4.Text));

            lblpromedio.Text = "El promedio es: "+promedio.resultado().ToString();
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";

            txtnota1.Focus();

            if (promedio.resultado() < 2.99)
            {

                MessageBox.Show("Deficiente");
            }
            else
            {

                if (promedio.resultado() < 3.99)
                {

                    MessageBox.Show("Bien");
                }
                else
                {

                    if (promedio.resultado() > 4 && (promedio.resultado() <= 5))
                    {

                        MessageBox.Show("Excelente!");
                    }

                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
