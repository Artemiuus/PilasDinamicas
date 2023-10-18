using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasDinamicas
{
    internal class Nodo
    {
        int dato;
        Nodo liga;

        public Nodo(int dt)
        {
            Dato = dt;
            Liga = null;
        }

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Liga { get => liga; set => liga = value; }
    }
}
