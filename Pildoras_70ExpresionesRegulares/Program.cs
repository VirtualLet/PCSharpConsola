using System;
using System.Text.RegularExpressions;

namespace Pildoras_70ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haciendo uso de exprescion regular");

            Console.WriteLine("Validando correo electronico");
            string texto = ".comcurs@opil@pcomasinformaticas.como";
            string re1 = ".*?";
            string re2 = "(@)";
            string re3 = "(\\.)";
            string patron = re1 + re2 + re1 + re3;
            Regex expresion = new Regex(patron, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            
            Regex expresionP = new Regex(@"(\W|^)[\w.\-]{0,25}@(yahoo|hotmail|gmail)\.com(\W|$)");

           

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Escribe el correo a validar");
                texto = Console.ReadLine();

                Match matches = expresionP.Match(texto);
                if (matches.Success)
                {
                    GroupCollection groups = matches.Groups;
                    string c1 = groups[1].ToString();
                    string c2 = groups[2].ToString();
                    Console.WriteLine("EXITO! en {2}: ({0} , {1})", c1, c2, groups[0].Value);
                }
                else Console.WriteLine("No se encontro en:{0}", texto);
            }

            Console.WriteLine("--");
            string patronEmail = @"^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$";
            Regex expresionEmail = new Regex(patronEmail);
            Match matchesEmail = expresionEmail.Match(texto);
            if (matchesEmail.Success)
            {
                Console.WriteLine("El email es valido");
            }
            else Console.WriteLine("Favor de introducir un email valido");
            




            Console.ReadLine();

        }


        public static void ExpresionRegularEjemUno()
        {
            string cadena = "Probar unA 123 , una67  f65f6 8 A ApruebaA";
            string patron = "A";
            string patron2 = @"\d{3}"; // /d numeros , {3} tres numeros

            Regex regex = new Regex(patron2);
            MatchCollection matches = regex.Matches(cadena);

            if (matches.Count > 0)
            {
                Console.WriteLine(cadena);
                Console.WriteLine("----");
                Console.WriteLine("Se ha encontrado {0} coincidencias de {1}", matches.Count, patron2);
            }
            else
                Console.WriteLine("No se ha encontrado patron");

            // Report on each matches.
            foreach (Match item in matches)
            {
                GroupCollection groups = item.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} ",
                                  groups[0].Value,
                                  groups[0].Index);
            }
            Console.WriteLine("---");

            //Despliegue de cadena para comprobación
            char[] caracteres = cadena.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine("[{0}]{1}", i, caracteres[i]);
            }
        }
        public void Informativo()
        {
            string.Format("Son secuencias de caracteres que funcionan como un patrón de busqueda" +
                "Buscan cadenas de caracteres:letras, números, otros caracteres." +
                "Se utilizan para validación de formularios, búsquedas en BBDD, comprobación" +
                "de entradas de usuario, etc." +
                "Funciones de expresiones regulares" +
                "Clases útiles:" +
                ".Regex" +
                ".Match" +
                ".MatchCollection" +
                ".GroupCollection" +
                "Métodos útiles:" +
                ".Matches" +
                "Propiedades útiles" +
                ".Groups");
        }
    }
}
