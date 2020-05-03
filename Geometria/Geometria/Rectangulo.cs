using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.area = 0;
            this.perimetro = 0;
        }

        public float Area()
        {
            if (this.area == 0)
            {
                float altura = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                float baseR = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.area = altura * baseR;
            }

            return this.area;
        }


        public float Perimetro()
        {
            if (this.perimetro == 0)
            {
                float altura = Math.Abs(this.vertice2.GetX() - this.vertice4.GetX());
                float baseR = Math.Abs(this.vertice2.GetY() - this.vertice4.GetY());
                this.perimetro = (altura + baseR) * 2;
            }

            return this.perimetro;
        }

        public static string Mostrar(Rectangulo data)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Vertice 1: {0},{1}", data.vertice1.GetX(), data.vertice1.GetY()));
            sb.AppendLine(string.Format("Vertice 2: {0},{1}", data.vertice2.GetX(), data.vertice2.GetY()));
            sb.AppendLine(string.Format("Vertice 3: {0},{1}", data.vertice3.GetX(), data.vertice3.GetY()));
            sb.AppendLine(string.Format("Vertice 4: {0},{1}", data.vertice4.GetX(), data.vertice4.GetY()));
            sb.AppendLine(string.Format("Area del Rectangulo: {0}", data.Area()));
            sb.AppendLine(string.Format("Perimetro del Rectangulo: {0}", data.Perimetro()));

            return sb.ToString();
        }

    }
}