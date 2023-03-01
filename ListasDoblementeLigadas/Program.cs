using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista doble= new Lista();

            Console.WriteLine(doble.Recorrer());
            doble.AgregarFinal("Uno");
            doble.AgregarFinal("Dos");
            Console.WriteLine(doble.Recorrer());
            doble.AgregarInicio("Cero");
            doble.AgregarFinal("Tres");
            Console.WriteLine(doble.Recorrer());
            Console.WriteLine(doble.Buscar("Tres").Valor);
            Console.WriteLine();
            doble.BorrarNodo("Dos");
            Console.WriteLine(doble.Recorrer());


            Console.ReadLine();

        }
    }
}
