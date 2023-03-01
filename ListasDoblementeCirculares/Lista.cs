using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeCirculares
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Lista()
        {
            nodoInicial = new Nodo(anterior: nodoInicial, siguiente: nodoInicial);
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
            {
                Console.WriteLine("Esta Vacio");
                return true;

            }
            return false;


        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = nodoInicial;
            nodoInicial.Anterior = nodoInicial;
        }
        public string Recorrer()
        {
            string datos = string.Empty;
            if (ValidaVacio() == true)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
   
                nodoActual = nodoInicial;
                while (nodoActual.Siguiente != nodoInicial)
                {
                    nodoActual = nodoActual.Siguiente;
                    datos += nodoActual.Valor + "\n";
                }
                
            }
            return datos;
        }


        public void AgregarFinal(string valor)
        {
            if (ValidaVacio() == true)
            {
                AgregarInicio(valor);
                return;
            }

            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor, nodoActual, nodoInicial);
            nodoActual.Siguiente = nodoNuevo;
            nodoInicial.Anterior = nodoNuevo;
        }

        public void AgregarInicio(string valor)
        {
            if (ValidaVacio() == true)
            {
                Nodo nuevoNodo = new Nodo(valor, nodoInicial, nodoInicial);
                nodoInicial.Siguiente = nuevoNodo;
                nodoInicial.Anterior = nuevoNodo;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(valor, nodoInicial, nodoInicial.Siguiente);
                nodoInicial.Siguiente.Anterior = nuevoNodo;
                nodoInicial.Siguiente = nuevoNodo;
            }

        }
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio())
            {
                return null;
            }
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
                if (nodoActual.Valor == valor)
                {
                    return nodoActual;
                }

            }
            return null;
        }

        public void BorrarNodo(string valor)
        {

            nodoActual = Buscar(valor);

            if (nodoActual != null)
            {
                nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                nodoActual.Siguiente = null;
                nodoActual.Anterior = null;
            }

        }
    }
}
