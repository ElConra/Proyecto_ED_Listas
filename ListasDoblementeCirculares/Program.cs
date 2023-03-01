using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista dobleCircular = new Lista();
            dobleCircular.ValidaVacio();

            dobleCircular.AgregarFinal("Uno");
            Console.WriteLine(dobleCircular.Recorrer());
            dobleCircular.AgregarFinal("Dos");
            Console.WriteLine(dobleCircular.Recorrer());
            dobleCircular.AgregarInicio("Cero");
            Console.WriteLine(dobleCircular.Recorrer());
            dobleCircular.BorrarNodo("Cero");
            Console.WriteLine(dobleCircular.Recorrer());
            dobleCircular.VaciarLista();
            Console.WriteLine(dobleCircular.Recorrer());





            Console.ReadKey();




        }
    }
}
