using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1ProNet
{
    public class Segundos
    {
        private int Numeronac;
        public void setNumeronac(int numero)
        {
            this.Numeronac = numero;
        }
        public int getNumeronac()
        {
            return this.Numeronac;
        }

        public int calcular()
        {
            return ((2019) - (this.getNumeronac()));


        }


        public int segundos()

        {
            return (this.calcular()) * (3600) * (24) * (365) - 2019;
        }
    }
}
