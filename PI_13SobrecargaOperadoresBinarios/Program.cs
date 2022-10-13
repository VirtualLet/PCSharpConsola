using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_13SobrecargaOperadoresBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);

            //Uso de operadore binarios
            Console.WriteLine("Uso de operadores Binarios + - * / \n");
            CImaginario imResult;
            imResult = im1 + im2;

            //Suma
            Console.WriteLine("SUMA: {0}+{1}={2}", im1, im2, imResult);
            //Resta
            Console.WriteLine("RESTA:  {0}-{1}={2}", im1, im2, im1 - im2);
            //Multiplicación
            Console.WriteLine("MULTIPLICACIÓN:  {0}*{1}={2}", im1, im2, im1 * im2);
            //División
            Console.WriteLine("DIVISIÖN: {0}/{1}={2}", im1, im2, im1 / im2);

            //Uso de operadores UNUARIOS
            Console.WriteLine("\nUso de operadores Unuarios ++ --\n");
            Console.WriteLine("Normal {0}", im1);
            im1++;
            Console.WriteLine("Con incremento im1++ {0}", im1);
            Console.WriteLine("Con incremento en el mismo momento ++im1 {0}", ++im1);

            Console.WriteLine("Normal {0}", im2);
            im2--;
            Console.WriteLine("Con decremento {0}", im2);

            Console.WriteLine("-------");
            Console.WriteLine("{0},{1}",im1,im2);
            //im1 += im2;
            Console.WriteLine(im1 += im2);
            im1 -= im2;
            Console.WriteLine(im1);

            Console.WriteLine("\nUso de operadores de igualdad y desigualdad == !=\n");
            CImaginario im3 = new CImaginario(1, 2);
            CImaginario im4 = new CImaginario(1, 2);
            CImaginario im5 = new CImaginario(5, 7);
            Console.WriteLine("{0},{1} son iguales? {2}",im3,im4,  im3.Equals(im4));
            Console.WriteLine("{0},{1} son diferentes? {2}", im3, im4, im3!=im4);

            Console.WriteLine("\nUso de operadores de comparación < >\n");
            Console.WriteLine("{0}>{1} ? {2}", im3, im5, im3 > im5);
            Console.WriteLine("{0}<{1} ? {2}", im3, im5, im3 < im5);
            Console.ReadLine();
        }
    }
}
