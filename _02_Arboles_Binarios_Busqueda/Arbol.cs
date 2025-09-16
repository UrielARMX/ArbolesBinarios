using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arboles_Binarios_Busqueda
{
    class Arbol
    {
        private Nodo raiz;
        private Nodo Actual;
        private int i = 0;

        public Arbol() => raiz = null;

        internal Nodo Raiz { get => raiz; set => raiz = value; }

        public Nodo InsertarNodo(int dato, Nodo nodo)
        {
            if (nodo == null)
            {
                Raiz = new Nodo();
                Raiz.Dato = dato;

                Raiz.Izq = null;
                Raiz.Der = null;

                return Raiz;
            }
            else if (dato < nodo.Dato) nodo.Izq = InsertarNodo(dato, nodo.Izq);
            else if (dato > nodo.Dato) nodo.Der = InsertarNodo(dato, nodo.Der);

            return nodo;
        }

        public void TransversaPreO(Nodo nodo)
        {
            if (nodo == null) return;

            for (int n = 0; n < i; n++) Console.Write(" ");

            Console.WriteLine(nodo.Dato);

            if (nodo.Izq != null)
            {
                i++;
                Console.Write("I: ");
                TransversaPreO(nodo.Izq);
                i--;
            }

            if (nodo.Der != null)
            {
                i++;
                Console.Write("D: ");
                TransversaPreO(nodo.Der);
                i--;
            }
        }

        public void TransversaInO(Nodo nodo)
        {
            if (nodo == null) return;

            if (nodo.Izq != null)
            {
                //i++;
                TransversaInO(nodo.Izq);
                //i--;
            }

            for (int n = 0; n < i; n++) Console.Write(" ");

            Console.Write(nodo.Dato + " ");

            if (nodo.Der != null)
            {
               // i++;
                TransversaInO(nodo.Der);
               // i--;
            }
        }

        public void TransversaPostO(Nodo nodo)
        {
            if (nodo == null) return;

            if (nodo.Izq != null)
            {
                //i++;
                TransversaPostO(nodo.Izq);
                //i--;
            }

            if (nodo.Der != null)
            {
                // i++;
                TransversaPostO(nodo.Der);
                // i--;
            }

            for (int n = 0; n < i; n++) Console.Write(" ");

            Console.Write(nodo.Dato + " ");
        }
    }
}
