using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cola_EESA
{
    internal class Cola
    {
        private NODO inicio;
        private int count = 0;
        private int MAX;
        public Cola(int max)
        {
            MAX = max;
            inicio = null;
        }
        private bool UnderFlow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        private bool OverFlow()
        {
            if (count == MAX)
                return true;
            else
                return false;
        }
        public void Print()
        {

        }
        public int Count()
        {
            return count;
        }
        public bool Insert()
        {
            //Regresa true al insertar y si no inserta regresa false por estar llena o otro pedo
            return false;
        }
        public int Extract()
        {
            //Regresa valor extraido, si está vacia o no pudo extraer regresa -1
            return -1;
        }
    }
}
