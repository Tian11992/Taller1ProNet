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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnedadsegundos_Click(object sender, EventArgs e)
        {
            OpcionEdadEnSegundos opcionEdadEnSegundos = new OpcionEdadEnSegundos();
            opcionEdadEnSegundos.Show();
            this.Hide();
        }

        private void btnimc_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();
            imc.Show();
            this.Hide();
        }

        private void btnllamadas_Click(object sender, EventArgs e)
        {
            Llamadas llamada = new Llamadas();
            llamada.Show();
            this.Hide();
        }

        private void btnetapas_Click(object sender, EventArgs e)
        {
            EtapadeVida etapadevida = new EtapadeVida();
            etapadevida.Show();
            this.Hide();
        }

        private void btnpromedio_Click(object sender, EventArgs e)
        {
            PromedioNotas promedio = new PromedioNotas();
            promedio.Show();
            this.Hide();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            Raiz raiz = new Raiz();
            raiz.Show();
            this.Hide();
        }

        private void btnvolumen_Click(object sender, EventArgs e)
        {
            VolumenCaja volumen = new VolumenCaja();
            volumen.Show();
            this.Hide();
        }

        private void btndescuento_Click(object sender, EventArgs e)
        {
            Descuento descuento = new Descuento();
            descuento.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
