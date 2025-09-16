using System;

namespace _02_Arboles_Binarios_Busqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

            Nodo raiz = arbol.InsertarNodo(6, null);
            arbol.InsertarNodo(2, raiz);
            arbol.InsertarNodo(8, raiz);
            arbol.InsertarNodo(1, raiz);
            arbol.InsertarNodo(4, raiz);
            arbol.InsertarNodo(3, raiz);
            arbol.InsertarNodo(5, raiz);
            arbol.InsertarNodo(7, raiz);
            arbol.InsertarNodo(11, raiz);
            arbol.InsertarNodo(9, raiz);
            arbol.InsertarNodo(0, raiz);
            arbol.InsertarNodo(-1, raiz);
            arbol.InsertarNodo(10, raiz);
            arbol.InsertarNodo(12, raiz);
            arbol.InsertarNodo(14, raiz);

            arbol.TransversaPreO(raiz);

            Console.WriteLine("======");

            arbol.TransversaInO(raiz);
        }
    }
}