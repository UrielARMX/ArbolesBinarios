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

        public void TransversaPostO(Nodo nodo)
        {
            if (nodo == null) return;

            if (nodo.Hijo != null)
            {
                i++;
                TransversaPostO(nodo.Hijo);
                i--;
            }

            if (nodo.Hermano != null) TransversaPostO(nodo.Hermano);

            for (int n = 0; n < i; n++) Console.Write(" ");

            Console.WriteLine(nodo.Dato);
        }

        public Nodo Buscar(string dato, Nodo nodo)
        {
            Nodo Encotrado = null;

            if (nodo == null) return Encotrado;

            if (nodo.Dato.CompareTo(dato) == 0)
            {
                Encotrado = nodo;
                return Encotrado;
            }

            if (nodo.Hijo != null)
            {
                Encotrado = Buscar(dato, nodo.Hijo);
                
                if(Encotrado != null) return Encotrado;
            }

            if (nodo.Hermano != null)
            {
                Encotrado = Buscar(dato, nodo.Hermano);

                if (Encotrado != null) return Encotrado;
            }

            return Encotrado;
        }
    }
}
