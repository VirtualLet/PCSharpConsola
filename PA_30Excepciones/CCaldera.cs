using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_30Excepciones
{
    class CCaldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public int TempActual { get => tempActual; set => tempActual = value; }
        public string Marca { get => marca; set => marca = value; }
        public bool Funciona { get => funciona; set => funciona = value; }

        public CCaldera(string pMarca, int pTempActual)
        {
            tempActual = pTempActual;
            marca = pMarca;
        }

        //Ejemplo sin usar excepxiones
        public void TrabajarSinExcepciones(int pTemperatura)
        {
            if(funciona==false)
                Console.WriteLine("La caldera {0} esta descompuesta",marca);
            else
            {
                tempActual += pTemperatura;
                Console.WriteLine("La temperatura actual es de {0}",tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}",marca,tempActual);
                    tempActual = tempMax;
                    funciona = false;
                }
            }
        }

        public void TrabajarConExcepciones(int pTemperatura)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pTemperatura;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    throw new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                }
            }
        }

        //InformacionEnExcepcion
        public void TrabajarInformacionExcepcionV3(int pTemperatura)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pTemperatura;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    //Información en la excepción
                    Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                    ex.HelpLink = "http://www.nicosio.com";
                
                    throw ex;
                }
            }
        }

        public void TrabajarInformacionExcepcionV4(int pTemperatura)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pTemperatura;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                    ex.HelpLink = "http://www.nicosio.com";

                    //Se adiciona datos propios a la excepción
                    ex.Data.Add("Momento:", string.Format("Ocurrio en {0}", DateTime.Now));
                    ex.Data.Add("Temperatur actual:", string.Format("{0} grados", tempActual));
                    ex.Data.Add("Incremento dado:", string.Format("{0} grados", pTemperatura));
                    throw ex;
                }
            }
        }

        public void TrabajarConExcepcionesPropias(int pTemperatura)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pTemperatura;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    //Primera versión de la excepción propia
                    //Se crea una instancia de la clase propia de excepción
                    Exception ex = new CCalderaExcepcion(string.Format("La caldera {0} se ha sobrecalentado", marca),
                                            "Ha trabajado demasiado tiempo", DateTime.Now);
                    ex.HelpLink = "http://www.nicosio.com";
                    //Se lanza la excepción
                    throw ex;
                }
                else if (tempActual == tempMax)
                {
                    Exception ex = new Exception(string.Format("Se ha igualdado la tamperatura Actual a la maxima permitia {0}",tempActual));
                    throw ex;
                }
            }
        }

        public void TrabajarConMultiplesExcepciones(int pTemperatura)
        {
            if (pTemperatura < 0)
            { //Aqui  se coloca una excepción para argumento invalio
                throw new
                    ArgumentOutOfRangeException(string.Format("Temperatura {0}", pTemperatura), "El aumento no puede ser negativo");
            }

            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pTemperatura;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    //Primera versión de la excepción propia
                    //Se crea una instancia de la clase propia de excepción
                    Exception ex = new CCalderaExcepcion(string.Format("La caldera {0} se ha sobrecalentado", marca),
                                            "Ha trabajado demasiado tiempo", DateTime.Now);
                    ex.HelpLink = "http://www.nicosio.com";
                    //Se lanza la excepción
                    throw ex;
                }
                else if (tempActual == tempMax)
                {
                    Exception ex = new Exception(string.Format("Se ha igualdado la tamperatura Actual a la maxima permitia {0}", tempActual));
                    throw ex;
                }
            }
        }

    }
}
