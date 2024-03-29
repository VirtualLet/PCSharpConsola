﻿using System;
using System.Collections.Generic;

namespace Pildoras_64ColeccionesLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colecciones LinkedList (Listas enlazadas)!");
            LinkedList<int>  linkNumeros = new LinkedList<int>();            
            foreach(int item in new int[] { 10,8,6,4,2 })
            {
                linkNumeros.AddFirst(item);
            }
          
            for(LinkedListNode<int> nodo=linkNumeros.First; nodo!=null; nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value);
            }

            List<int> listNum = new List<int>() { 2, 3, 5, 1 };

            Console.WriteLine("Mostrando linkedList sin el elemento 6");
            linkNumeros.Remove(6);

            for (LinkedListNode<int> nodo = linkNumeros.First; nodo != null; nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value);
            }
            Console.WriteLine("----");
            LinkedListNode<int> listNode = new LinkedListNode<int>(15);
            linkNumeros.AddFirst(listNode);
            linkNumeros.AddFirst(new LinkedListNode<int>(40));

            for (LinkedListNode<int> nodo = linkNumeros.First; nodo != null; nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value);
            }

            //MostrarListaUsandoAddFirst()
            MostrarListaUsandoAddLast();
            MostrarListaAgregandoUnArrayAListaLinked();
            Console.ReadLine();
        }

        public static void MostrarListaUsandoAddFirst()
        {
            LinkedList<int> linkNumeros = new LinkedList<int>();

            Console.WriteLine("Muestra en order creciente por usar AddFirst");
            foreach (int item in new int[] { 10, 8, 6, 4, 2 })
            {
                linkNumeros.AddFirst(item);
            }
            MostrarLinkeList(linkNumeros);

        }

        public static void MostrarListaAgregandoUnArrayAListaLinked()
        {
            Console.WriteLine("Otra forma de añadir elementos de un array a un LinkedList");
            int[] arregloNumero = new int[] { 10, 8, 6, 4, 2 };
            LinkedList<int> linkPrueba = new LinkedList<int>(arregloNumero);
            MostrarLinkeList(linkPrueba);
        }

        public static void MostrarListaUsandoAddLast()
        {
            Console.WriteLine("Muestra lista en order decreciente");
            LinkedList<int> linkNumeros2 = new LinkedList<int>();
            int[] arregloNumero = new int[] { 10, 8, 6, 4, 2 };
            foreach (int item in arregloNumero)
            {
                linkNumeros2.AddLast(item);
            }

            MostrarLinkeList(linkNumeros2);
        }
        public static void MostrarLinkeList(LinkedList<int> listaEnlazada)
        {
            foreach (int item in listaEnlazada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
