using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1ProNet
{
    public class Iva
    {
        private double Numerocompra;
        public void setNumerocompra(double compra)
        {
            this.Numerocompra = compra;
        }
        public double getNumerocompra()
        {
            return this.Numerocompra;
        }
        public double descuento()
        {

            return this.getNumerocompra() - (0.20 * this.getNumerocompra());
        }
        public double total()
        {
            return (this.descuento() * 1.19);
        }
    }
}
