using System;
using System.Collections;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_14ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haciendo uso de observableCollection");
            string info = string.Format("Es una colección especial que permite " +
                "adicionar un handler y podemos tener codigo que se ejecute cada que " +
                "ocurra un cambio");
            ObservableCollection<CPunto> puntos = new ObservableCollection<CPunto>()
            {
                new CPunto(4,55),
                new CPunto(17,22)
            };

            foreach (CPunto item in puntos) 
                Console.WriteLine(item);
            Console.WriteLine("----");
            //Adicionamos el handler
            puntos.CollectionChanged += puntos_CollectionChanded;
           
            CPunto puntoUno  = new CPunto(33, 22);
            CPunto puntoPrueba = new CPunto(34, 45);
            puntos.Add(puntoUno);
            puntos.Add(puntoPrueba);
           
            Console.WriteLine("-lista actual-");
            MuestaElementosColeccion(puntos);

            Console.WriteLine("--Removiendo--");
            puntos.Remove(puntoPrueba);

            Console.WriteLine("--Lista final--"); 
             MuestaElementosColeccion(puntos);



            Console.ReadLine();
        }

        public static void MuestaElementosColeccion(ObservableCollection<CPunto> puntos)
        {
            for (int i = 0; i < puntos.Count(); i++)
            {
                Console.WriteLine("[{0}]=({1},{2})", i, puntos[i].X, puntos[i].Y);
            }
            Console.WriteLine("----");
        }


        //Este es el handler que se invoca cuando cambia la colección
        public static void puntos_CollectionChanded(Object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Vemos el tipo de evento que ocurrio
            Console.WriteLine("El evento es {0}",e.Action);

            //si la accion es adicionar
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Se agregaron elementos nuevos");
                foreach(CPunto item in e.NewItems) Console.WriteLine(item.ToString());
                
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos removidos por el cambio");
                foreach (CPunto item in e.OldItems) Console.WriteLine(item.ToString());
                
            }
           
        }
       
    }
}
