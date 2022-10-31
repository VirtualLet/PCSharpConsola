using System;
using System.IO;

namespace PI_20Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string modelo;
            double costo;
            Console.WriteLine("1- Crear archivo\n2- Leer archivo");
            opcion=Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();
                Console.WriteLine("Dame el costo");
                costo = Convert.ToDouble(Console.ReadLine());
                CAuto auto = new CAuto(modelo, costo);

                //variables extras
                int numero = 5;
                bool acceso = false;
                byte conteo = 120;

                //Se crea el stream
                FileStream fileStream = new FileStream("NuevoArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                //Se crea el escritor
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);

                //Se escriben los atributos del objeto, Ojo, no se esta serializando
                binaryWriter.Write(auto.Modelo);
                binaryWriter.Write(auto.Costo);

                //Se escriben las variables
                binaryWriter.Write(numero);
                binaryWriter.Write(acceso);
                binaryWriter.Write(conteo);

                //Se cierra el stream
                fileStream.Close();
            }
            if (opcion == 2)
            {
                Console.WriteLine("--Se lee el archivo--");
                FileStream fileStream = new FileStream("NuevoArchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                //Se crea lector
                BinaryReader lector = new BinaryReader(fileStream);
                //Se lee en el mismo orden que se escribio, tomando en cuenta el tipo
                modelo = "";
                costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = lector.ReadString();
                costo = lector.ReadDouble();
                CAuto auto = new CAuto(modelo, costo);
                numero = lector.ReadInt32();
                acceso = lector.ReadBoolean();
                conteo = lector.ReadByte();

                //Se cierra el stream
                fileStream.Close();

                //Se imprime
                auto.MuestraInformacion();
                Console.WriteLine("numero={0}, acceso={1}, conteo={2}",numero, acceso,conteo);
            
            }

            Console.ReadLine();
        }

        public void Informativo()
        {
            string.Format("Almacenamiento de archivo en disco");
        }
    }
}
