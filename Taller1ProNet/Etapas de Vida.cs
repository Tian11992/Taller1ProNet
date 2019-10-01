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
    public partial class EtapadeVida : Form
    {
        EtapasdeVida etapa = new EtapasdeVida();
        public EtapadeVida()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            etapa.setNumeroedad(int.Parse(txtedad.Text));
            txtedad.Focus();
            txtedad.Text = "";
            if (etapa.getNumeroedad() <= 10)
            {
                MessageBox.Show("Es un niño");
            }
            else
            {
                if (etapa.getNumeroedad() <= 14)
                {
                    MessageBox.Show("Es un pre-Adolescente");
                }
                else
                {
                    if (etapa.getNumeroedad() <= 18)
                    {
                        MessageBox.Show("Es un Adolescente");
                    }
                    else
                    {
                        if (etapa.getNumeroedad() <= 25)
                        {
                            MessageBox.Show("Es un Joven");
                        }
                        else
                        {
                            if (etapa.getNumeroedad() <= 65)
                            {
                                MessageBox.Show("es un Adulto");
                            }
                            else
                            {
                                if (etapa.getNumeroedad() > 65)
                                {
                                    MessageBox.Show("Es un Anciano");
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
