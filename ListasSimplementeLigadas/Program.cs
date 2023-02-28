using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista lista = new Lista();
            Console.WriteLine(lista.Recorrer());
            lista.Agregar("Uno");
            lista.Agregar("Dos");
            Console.WriteLine(lista.Recorrer());
            lista.AgregarInicio("Cero");
            Console.WriteLine(lista.Recorrer());

            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Uno");
            if (NodoBusquedaAnterior != null)
            {
                Console.WriteLine(NodoBusquedaAnterior.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }


            Nodo NodoBusquedaSiguiente = lista.BuscarSiguiente("Uno");
            if (NodoBusquedaSiguiente != null)
            {
                Console.WriteLine(NodoBusquedaSiguiente.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }












            Console.Read();
        }
    }
}
