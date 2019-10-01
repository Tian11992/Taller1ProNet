using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1ProNet
{
    public class Promedio
    {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;


        public void setNota1(double nota1)
        {

            this.nota1 = nota1;
        }


        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota2(double nota2)
        {

            this.nota2 = nota2;
        }


        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota3(double nota3)
        {

            this.nota3 = nota3;
        }


        public double getNota3()
        {
            return this.nota3;
        }
        public void setNota4(double nota4)
        {

            this.nota4 = nota4;
        }


        public double getNota4()
        {
            return this.nota4;
        }

        public double resultado()
        {
            return ((this.getNota1() + this.getNota2() + this.getNota3() + this.getNota4()) / 4);

        }
    }
}
