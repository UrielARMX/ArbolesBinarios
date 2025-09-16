using System;

namespace _01_Arboles_Binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

            Nodo raiz = arbol.InsertarNodo("a", null);

            arbol.InsertarNodo("b", raiz);

            arbol.InsertarNodo("c", raiz);

            Nodo nuevo = arbol.InsertarNodo("d", raiz);
            arbol.InsertarNodo("h", nuevo);

            nuevo = arbol.InsertarNodo("e", raiz);
            arbol.InsertarNodo("i", nuevo);
            nuevo = arbol.InsertarNodo("j", nuevo);
            arbol.InsertarNodo("p", nuevo);
            arbol.InsertarNodo("q", nuevo);

            nuevo = arbol.InsertarNodo("f", raiz);
            arbol.InsertarNodo("k", nuevo);
            arbol.InsertarNodo("l", nuevo);
            arbol.InsertarNodo("m", nuevo);
            nuevo = arbol.InsertarNodo("g", raiz);
            arbol.InsertarNodo("n", nuevo);

            arbol.TransversaPreO(raiz);

            Console.WriteLine("========");

            arbol.TransversaPostO(raiz);

            Console.Write("Ingrese el dato del nodo a buscar: ");
            string dato = Console.ReadLine();

            Nodo Encontrado = arbol.Buscar(dato, raiz);

            if (Encontrado != null) Console.WriteLine("El dato a buscar SI se encuentra en el Arbol!");
            else Console.WriteLine("El dato a buscar NO se encuentra en el Arbol!");


            Console.Write("Ingrese el nodo donde se insertara el dato: ");
            string datoBuscar = Console.ReadLine();

            Encontrado = arbol.Buscar(datoBuscar, raiz);

            if (Encontrado != null)
            {
                Console.Write("Ingrese un dato a insertar: ");
                dato = Console.ReadLine();

                nuevo = arbol.InsertarNodo(dato, Encontrado);
            }
            else Console.WriteLine("El nodo NO se encuentra en el arbol");

            arbol.TransversaPreO(raiz);
        }
    }
}