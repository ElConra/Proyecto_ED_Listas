using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista circular = new Lista();

            Console.WriteLine(circular.Recorrer());
            circular.Agregar("Uno");
            circular.Agregar("Dos");
            Console.WriteLine(circular.Recorrer());
            circular.AgregarInicio("Cero");
            circular.Agregar("Tres");
            Console.WriteLine(circular.Recorrer());
            Console.WriteLine();
            Console.WriteLine(circular.BuscarAnterior("Uno").Valor);
            Console.WriteLine();
            circular.BorrarNodo("Dos");
            Console.WriteLine(circular.Recorrer());






            Console.ReadKey();
        }
    }
}
