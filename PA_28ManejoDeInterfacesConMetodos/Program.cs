using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_28ManejoDeInterfacesConMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronico[] arrayElectronicos = {new CTelevisor("Sony"),
                                                new CRadio("philips"),
                                                new CTelevisor("Dell")};
            IElectronico aparatoCreado = null;

            for(int i=0; i< arrayElectronicos.Length; i++)
            {
                Console.WriteLine(arrayElectronicos[i]);
            }
            Console.WriteLine("---");

            //Uso de interfaces con métodos
            CTelevisor televisor = new CTelevisor("Charp TV");
            CRadio radio = new CRadio("RBC");
            MuestraElectronico(televisor);
            MuestraElectronico(radio);
            Console.WriteLine("----");

            //El método CrearElectronico puede regresar cualquier objeto que implemente a IElectronico
            aparatoCreado = CrearElectronico();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);

            Console.WriteLine("----");
            //Hice una prueba, cree un lista de IElectronico
            //esto permite añadir todas las clases que implementen IElectronico
            //De esta manera se pueden almacenar clases distintas
            List<IElectronico> listElectronico = new List<IElectronico>(arrayElectronicos);
            listElectronico.Add(aparatoCreado);
            listElectronico.ForEach(item => Console.WriteLine(item));

            Console.ReadLine();
        }

        //Este método puede recibir a cualquier objeto que implemente IElectronico
        static void MuestraElectronico(IElectronico electronico)
        {
            if (electronico is CTelevisor)
                Console.WriteLine("El televisor es {0}",electronico);

            if(electronico is CRadio)
                Console.WriteLine("EL radio es {0}",electronico);
        }

        //Este método puede regresar cualquier objeto que implemente a IElectronico
        static IElectronico CrearElectronico()
        {
            IElectronico electronico = null;
            int opcion = 0;
            string valor = string.Empty;
            Console.WriteLine("Que desea hacer? 1-Tele, 2-Radio");
            opcion = Int32.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingresar la marca de la Television");
                valor = Console.ReadLine();
                electronico = new CTelevisor(valor);
            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingresar la marca del Radio");
                valor = Console.ReadLine();
                electronico = new CRadio(valor);
            }
            return electronico;
        }



    }
}
