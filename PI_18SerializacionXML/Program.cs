using System;
using System.IO;
using System.Xml.Serialization;

namespace PI_18SerializacionXML
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tomar el estado del objeto y guardarlo es lo que se llama serialización
            //Deserialización cuando se lee el objeto que guardado y se reconstruye el objeto con esa información
            //               para que quede exactamente con el mismo estado.
            //Soap es util para intercambiar en diferentes  sistemas operativos
            //Deventaja el peso del archivo será más grande en comparación al binario
            int opcion = 0;
            string valor = "";
            Console.WriteLine("1.-Para crear y serializar auto \n2.-Para leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {// se crea el objeto auto
                CAuto auto = new CAuto();
              
                Console.WriteLine("Dame le modelo");
                auto.Modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                auto.Costo = Convert.ToDouble(Console.ReadLine());

               
                Console.WriteLine("Auto a serializar");
                auto.MuestraInformacion();

                //Se inicia la serialización
                Console.WriteLine("---Serializando----");

                //Se selecciona el formateador
                XmlSerializer formateador = new XmlSerializer(typeof(CAuto));
                //string ruta = @"H:\GitProyectos\PCsharpConsola\PI_17SerializacionBinaria\Archivos\Autos.aut";
                //Se crea el stream
                Stream stream = new FileStream(@"..\..\Archivos\AutoXML.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formateador.Serialize(stream, auto);

                //Se cierra el stream
                stream.Close();
            }
            if (opcion == 2)
            {
                //Deserealizar el objeto
                Console.WriteLine("-----------Deserializamos-----");

                //Seleccionamos el formateador
                XmlSerializer formateador = new XmlSerializer(typeof(CAuto));

                //Se crea el stream
                Stream stream = new FileStream(@"..\..\Archivos\AutoXML.aut", FileMode.Open, FileAccess.Read, FileShare.None);

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
