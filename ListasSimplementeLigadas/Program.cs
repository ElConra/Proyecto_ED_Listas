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
            Console.WriteLine(lista.BuscarAnterior("Uno").Valor);
            lista.BorrarNodo("Uno");
            Console.WriteLine(lista.Recorrer());





            Console.Read();
        }
    }
}
