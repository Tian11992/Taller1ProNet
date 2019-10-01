using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1ProNet
{
    public class Masa
    {
        private double peso;
        private double estatura;

        public void setPeso(double valor)
        {
            this.peso = valor;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public void setEstatura(double valor)
        {
            this.estatura = valor;
        }

        public double getEstatura()
        {
            return this.estatura;
        }

        public double imc()
        {
            return (this.getPeso() / (this.getEstatura() * this.getEstatura()));
        }
    }
}
