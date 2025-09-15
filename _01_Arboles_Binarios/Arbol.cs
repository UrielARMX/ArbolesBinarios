using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Arboles_Binarios
{
    class Arbol
    {
        private Nodo Raiz;
        private Nodo Actual;
        private int i = 0;

        public Arbol() => Raiz = null;

        public Nodo InsertarNodo(string dato, Nodo nodo)
        {
            if (nodo == null)
            {
                Raiz = new Nodo();
                Raiz.Dato = dato;

                Raiz.Hijo = null;
                Raiz.Hermano = null;

                return Raiz;
            }
            else if (nodo.Hijo == null)
            {
                Nodo temporal = new Nodo();
                temporal.Dato = dato;

                nodo.Hijo = temporal;

                return temporal;
            }
            else
            {
                Actual = nodo.Hijo;

                while (Actual.Hermano != null) Actual = Actual.Hermano;

                Nodo temporal = new Nodo();
                temporal.Dato = dato;

                Actual.Hermano = temporal;

                return temporal;
            }
        }

        public void TransversaPreO(Nodo nodo)
        {
            if (nodo == null) return;

            for (int n = 0; n < i; n++) Console.Write(" ");

            Console.WriteLine(nodo.Dato);

            if (nodo.Hijo != null)
            {
                i++;
                TransversaPreO(nodo.Hijo);
                i--;
            }

            if (nodo.Hermano != null) TransversaPreO(nodo.Hermano);
        }
    }
}
