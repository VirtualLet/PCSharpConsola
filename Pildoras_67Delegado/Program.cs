using System;

namespace Pildoras_67Delegado
{
    class Program
    {
        //Definiendo al objeto delegado
        delegate void ObjDelegado();
        delegate void ObjDelString(string pMensaje);
        delegate string stringDel();
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando uso de delegados!\n");
            //Creacion del objeto delegado apuntando a la clase CMensajeBienvenida
            ObjDelegado delegadoVoid = new ObjDelegado(CMensajeBienvenida.SaludoBienvenida);
            //Utilizando el delegado para llamar al método saludoBienvenida
            delegadoVoid();
            
            delegadoVoid = new ObjDelegado(CMensajeDespedida.SaludoDespedida);
            delegadoVoid();

            Console.WriteLine("---");
            CMensajeBienvenida mensajeBienvenida = new CMensajeBienvenida("Leticia");
            delegadoVoid = new ObjDelegado(mensajeBienvenida.SaludoSinSerStatic);
            delegadoVoid();

            Console.WriteLine("\n------Usando Delegado con parametro----\n");
            ObjDelString delString = new ObjDelString(mensajeBienvenida.SaludoPersonalizado);
            delString("Hola bienvenido al uso de mensaje personalizado usando un delegado con parametro");

            delString = new ObjDelString(CMensajeDespedida.SaludoDespedidaPersonalizado);
            delString("Despidiendo al mensaje en su método personalizado adios!");
            Console.WriteLine("---");

            stringDel delegadoNombre = new stringDel(mensajeBienvenida.MonstrandoNombre);
            Console.WriteLine(delegadoNombre());

            Console.ReadLine();
        }

        public void Informativo()
        {
           string Info= string.Format("Funciones que delegan tareas en otras funciones \n" +
                "Un delegado es una referencia a un método" +
                "Utilizados para llamar a eventos" +
                "Código muy reutilizable" +
                "Se reduce significativamente el código al manejar diferentes escenarios" +
                "delegate [tipo] [NombreDelegado](argumentos)" +
                "[NombreDelegado] [NombreVariableDelegado]= new [NombreDelegado](Método a invocar);" +
                "tipo NombreVariableDelegado(argumentos");

            Console.WriteLine(Info);

        }
    }
}
