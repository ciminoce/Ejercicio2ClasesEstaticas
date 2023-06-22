using Ejercicio2ClasesEstaticas.Entidades;
using System;

namespace Ejercicio2ClasesEstaticas.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un nro entero:");
            var nro=int.Parse(Console.ReadLine());
            Console.WriteLine($"El equivalente en binario de {nro} es {Conversor.ConvertirDeDecimalABinario(nro)}");

           
            Console.Write("Ingrese un nro binario:");
            var nroBinario=int.Parse(Console.ReadLine());
            Console.WriteLine($"El equivalente en decimal de {nroBinario} es {Conversor.ConvertirDeBinarioADecimal(nroBinario)}");
            Console.ReadLine();
        }
    }
}
