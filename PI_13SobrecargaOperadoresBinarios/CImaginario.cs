using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_13SobrecargaOperadoresBinarios
{
    class CImaginario:IComparable
    {
        private double entero;
        private double imaginario;

        public CImaginario(double pEntero, double pImaginario)
        {
            entero = pEntero;
            imaginario = pImaginario;
        }

        public double Entero { get => entero; set => entero = value; }
        public double Imaginario { get => imaginario; set => imaginario = value; }

        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double entero = i1.entero + i2.entero;
            double imaginario = i1.imaginario + i2.imaginario;
            return new CImaginario(entero, imaginario);
        }
        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double entero = i1.entero - i2.entero;
            double imaginario = i1.imaginario - i2.imaginario;
            return new CImaginario(entero, imaginario);
        }

        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double entero = (i1.entero * i2.entero) - (i1.imaginario * i2.imaginario);
            double imaginario = (i1.entero * i2.imaginario) + (i1.imaginario * i2.entero);
            return new CImaginario(entero, imaginario);
        }
        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double entero = ((i1.entero * i2.entero) + (i1.imaginario * i2.imaginario))
                            / ((i2.entero * i2.entero) + (i2.imaginario * i2.imaginario));

            double imaginario = ((i1.imaginario * i2.entero) - (i1.entero * i2.imaginario))
                            / ((i2.entero * i2.entero) + (i2.imaginario * i2.imaginario));
            CImaginario temp = new CImaginario(entero, imaginario);
            return temp;
        }
        public override string ToString()
        {
            return string.Format("({0} {1}i)", entero, imaginario);
        }

        //Sobrecarga de operadores unuarios
        public static CImaginario operator ++(CImaginario img)
        {
            return new CImaginario(img.entero + 1, img.imaginario + 1);
        }
        public static CImaginario operator --(CImaginario img)
        {
            return new CImaginario(img.entero - 1, img.imaginario - 1);
        }

        //Operador del operador de igualdad y desigualdad
        public override bool Equals(object obj)
        {
            //Se verifica que sea del tipo correcto
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;
                //Se compara por igualdad
                if (imaginario == temp.imaginario && entero == temp.entero)
                    return true;
            }
            return false;
        }       

        public static bool operator ==(CImaginario i1, CImaginario i2)
        {
            return i1.Equals(i2);
        }
        public static bool operator!=(CImaginario i1, CImaginario i2)
        {
            return !(i1.Equals(i2));
        }

        //Sobrecarga de < y > se requiere IComparable
        public double Magnitud()
        {           
           return Math.Sqrt((entero * entero) + (imaginario * imaginario));
        }
        public int CompareTo(object obj)
        {
            if(obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;
                if (Magnitud() > temp.Magnitud())               
                    return 1;
                if (Magnitud() < temp.Magnitud())
                    return -1;
            }
            return 0;
        }

        public static bool operator <(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) < 0)
                return true;
            else
                return false;
        }

        public static bool operator >(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) > 0)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
