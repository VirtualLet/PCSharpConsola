using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PI_17SerializacionBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tomar el estado del objeto y guardarlo es lo que se llama serialización
            //Deserialización cuando se lee el objeto que guardado y se reconstruye el objeto con esa información
            //               para que quede exactamente con el mismo estado.
            //No confundir con archivos
            int opcion = 0;
            string valor = "";
            Console.WriteLine("1.-Para crear y serializar auto \n2.-Para leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {// se crea el objeto auto
                string modelo = "";
                double costo = 0;
                Console.WriteLine("Dame le modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                costo =Convert.ToDouble( Console.ReadLine());

                CAuto auto = new CAuto(modelo, costo);
                Console.WriteLine("Auto a serializar");
                auto.MuestraInformacion();

                //Se inicia la serialización
                Console.WriteLine("---Serializando----");

                //Se selecciona el formateador
                BinaryFormatter formateador = new BinaryFormatter();
                //string ruta = @"H:\GitProyectos\PCsharpConsola\PI_17SerializacionBinaria\Archivos\Autos.aut";
                //Se crea el stream
                Stream stream = new FileStream(@"..\..\Archivos\Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formateador.Serialize(stream, auto);

                //Se cierra el stream
                stream.Close();
            }
            if(opcion == 2)
            {
                //Deserealizar el objeto
                Console.WriteLine("-----------Deserializamos-----");

                //Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                //Se crea el stream
                Stream stream= new FileStream(@"..\..\Archivos\Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserealizar
                CAuto auto = (CAuto)formateador.Deserialize(stream);

                //Se cierra stream
                stream.Close();

                //Usar el objeto
                Console.WriteLine("El auto deserializado es");
                auto.MuestraInformacion();
            }

            Console.ReadLine();
        }
    }
}
