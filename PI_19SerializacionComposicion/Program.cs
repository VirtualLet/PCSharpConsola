using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace PI_19SerializacionComposicion
{
    class Program
    {
        static void Main(string[] args)
        {
           // ComposicionBinaria();
            ComposicionXML();
            Console.ReadLine();
        }
        public static void ComposicionXML()
        {
            //Tomar el estado del objeto y guardarlo es lo que se llama serialización
            //Deserialización cuando se lee el objeto que guardado y se reconstruye el objeto con esa información
            //               para que quede exactamente con el mismo estado.
            //No confundir con archivos
            int opcion = 0;            
            Console.WriteLine("1.-Para crear y serializar auto \n2.-Para leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {// se crea el objeto auto
                CAutoXML autoXML = new CAutoXML();
                CMotorXML motorXML = new CMotorXML();

                Console.WriteLine("Escribre el modelo");
                autoXML.Modelo = Console.ReadLine();

                Console.WriteLine("Escribe el costo");
                autoXML.Costo = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Escribe sus cilindros?");
                motorXML.Cilindros = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escribe los caballos de fuerza");
                motorXML.HP = Convert.ToInt32(Console.ReadLine());

                autoXML.Motor = motorXML;

                Console.WriteLine("Auto a serializar");
                autoXML.MuestraInformacion();


                //Se inicia la serialización
                Console.WriteLine("---Serializando----");

                //Se selecciona el formateador
                //si hubiera mas clases contenidas se pondrian  de este  modo
                // XmlSerializer formateador = new XmlSerializer(typeof(CAutoXML),new Type[] { typeof(CMotorXML),typeof(CMotor)});
                XmlSerializer formateador = new XmlSerializer(typeof(CAutoXML),new Type[] { typeof(CMotorXML)});
                //Se crea el stream
                Stream stream = new FileStream(@"..\..\Archivos\AutosXML.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formateador.Serialize(stream,autoXML);

                //Se cierra el stream
                stream.Close();
            }
            if (opcion == 2)
            {
                //Deserealizar el objeto
                Console.WriteLine("-----------Deserializamos-----");

                //Seleccionamos el formateador
                XmlSerializer formateador = new XmlSerializer(typeof(CAutoXML), new Type[] { typeof(CMotorXML) });

                //Se crea el stream
                Stream stream = new FileStream(@"..\..\Archivos\AutosXML.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserealizar
                CAutoXML autoXML = (CAutoXML)formateador.Deserialize(stream);

                //Se cierra stream
                stream.Close();

                //Usar el objeto
                Console.WriteLine("El auto deserializado es");
                autoXML.MuestraInformacion();
            }
        }
        public static void ComposicionBinaria()
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
                CAuto auto = new CAuto();
                CMotor motor = new CMotor();

                Console.WriteLine("Escribre el modelo");
                auto.Modelo = Console.ReadLine();

                Console.WriteLine("Escribe el costo");
                auto.Costo = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Escribe sus cilindros?");
                motor.Cilindros = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escribe los caballos de fuerza");
                motor.HP = Convert.ToInt32(Console.ReadLine());

                auto.Motor = motor;

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
            if (opcion == 2)
            {
                //Deserealizar el objeto
                Console.WriteLine("-----------Deserializamos-----");

                //Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                //Se crea el stream
                Stream stream = new FileStream(@"..\..\Archivos\Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserealizar
                CAuto auto = (CAuto)formateador.Deserialize(stream);

                //Se cierra stream
                stream.Close();

                //Usar el objeto
                Console.WriteLine("El auto deserializado es");
                auto.MuestraInformacion();
            }
        }
    }
}
