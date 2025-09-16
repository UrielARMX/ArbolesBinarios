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
    }
}
