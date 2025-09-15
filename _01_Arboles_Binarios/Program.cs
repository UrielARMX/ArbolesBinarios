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
        }
    }
}