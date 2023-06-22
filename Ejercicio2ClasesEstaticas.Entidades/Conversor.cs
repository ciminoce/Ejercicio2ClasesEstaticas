using System;

namespace Ejercicio2ClasesEstaticas.Entidades
{
    public static class Conversor
    {
       /// <summary>
       /// Método estático para convertir un nro entero decimal a binario
       /// </summary>
       /// <param name="nro">Número entero a convertir</param>
       /// <returns>El valor en binario del nro ingresado</returns>
        public static int ConvertirDeDecimalABinario(int nro)
        {
            int x = 1;
            int binario = 0;
            while (nro >= 1)
            {
                if (nro % 2 == 1)
                {
                    binario = binario + x;
                }
                nro = Convert.ToInt32(Math.Truncate((double)nro / 2));
                x = x * 10;
            }
            return binario;
        }

        public static int ConvertirDeBinarioADecimal(int binario)
        {
            int e = 1;
            int nroDecimal = 0;
            int Y;
            if (binario ==0)
            {
                return nroDecimal;
            }
            while (binario>0)
            {
                Y = binario % 10;
                binario = binario / 10;
                nroDecimal = nroDecimal + (Y * e);
                e = 2 * e;
            }
            return nroDecimal;
        }
    }
}
