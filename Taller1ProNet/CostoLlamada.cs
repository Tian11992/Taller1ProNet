using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1ProNet
{
    public class CostoLlamada
    {
        private string destino;
        private double duracion;

        public void setdestino(string destino)
        {
            this.destino = destino;
        }

        public string getdestino()
        {
            return destino;
        }

        public void setduracion(double duracion)
        {
            this.duracion = duracion;
        }

        public double getduracion()
        {
            return duracion;
        }

        public double totalapagar()
        {

            double totalLlamada;

            if (destino.Equals("Estados Unidos"))
            {
                totalLlamada = 900 * duracion;
            }
            else if (destino.Equals("Canadá"))
            {
                totalLlamada = 800 * duracion;
            }
            else if (destino.Equals("Europa"))
            {
                totalLlamada = 950 * duracion;
            }
            else
            {
                totalLlamada = 1250 * duracion;
            }

            if (duracion >= 15)
            {
                totalLlamada = totalLlamada - (totalLlamada * 0.2);
            }

            return totalLlamada;

        }
    }
}
