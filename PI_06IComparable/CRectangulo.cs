using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_06IComparable
{
    class CRectangulo :IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public CRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            CalcularArea();
        }

        private void CalcularArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("ancho {0}, alto {1}= {2}", ancho, alto, area);
        }

        //Implementación de IComparable
        public int CompareTo(object obj)
        {
            CRectangulo tempRectangulo = (CRectangulo)obj;
            if (area > tempRectangulo.area) return 1;
            else if (area < tempRectangulo.area) return -1;
            else return 0;
        }
    }
}
