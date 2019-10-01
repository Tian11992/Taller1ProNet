using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1ProNet
{
    public class Volumen
    {
        private double Altura;
        private double Largo;
        private double Ancho;


        public void setAltura(double alto)
        {
            this.Altura = alto;
        }

        public double getAltura()
        {
            return this.Altura;
        }

        public void setLargo(double largo)
        {
            this.Largo = largo;
        }

        public double getLargo()
        {
            return this.Largo;
        }

        public void setAncho(double ancho)
        {
            this.Ancho = ancho;
        }

        public double getAncho()
        {
            return this.Ancho;
        }


        public double calcular()
        {
            return (this.getLargo() * this.getAncho() * this.getAltura());
        }
    }
}
