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
    public partial class IMC : Form
    {
        Masa masa = new Masa();
        public IMC()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            masa.setEstatura(double.Parse(txtestatura.Text));
            masa.setPeso(double.Parse(txtpeso.Text));
            lblresultado.Text = masa.imc().ToString();
            lblresultado.Visible = true;

            if (masa.imc() < 18.5)
            {
                MessageBox.Show("Peso bajo");
            }
            else
            {
                if (masa.imc() < 24.9)
                {
                    MessageBox.Show("Peso normal");
                }
                else
                {
                    if (masa.imc() < 29.9)
                    {
                        MessageBox.Show("Sobrepeso");
                    }
                    else
                    {
                        if (masa.imc() < 34.9)
                        {
                            MessageBox.Show("Obesidad tipo 1");
                        }
                        else
                        {
                            if (masa.imc() < 39.9)
                            {
                                MessageBox.Show("Obesidad tipo 2");
                            }
                            else
                            {
                                if (masa.imc() >= 40)
                                {
                                    MessageBox.Show("Obesidad tipo 3");
                                }

                            }

                        }
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
