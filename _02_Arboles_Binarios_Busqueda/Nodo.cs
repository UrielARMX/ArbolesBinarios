using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arboles_Binarios_Busqueda
{
    class Nodo
    {
        private int dato;
        private Nodo izq;
        private Nodo der;

        public int Dato { get => dato; set => dato = value; }
        public Nodo Izq { get => izq; set => izq = value; }
        public Nodo Der { get => der; set => der = value; }

        public Nodo()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }
}
