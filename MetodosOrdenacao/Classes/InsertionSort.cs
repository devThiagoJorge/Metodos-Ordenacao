using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.Classes
{
    public class InsertionSort : Ordernacao
    {
        public int[] Numeros { get; private set; }
        public static TimeSpan TempoProcessamento { get; private set; }

        public InsertionSort(int[] numeros)
        {
            Numeros = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                Numeros[i] = numeros[i];
            }
        }

        public void Ordenar()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < Numeros.Length; i++)
            {

                int aux = Numeros[i];
                int j = i;

                while ((j > 0) && (Numeros[j - 1] > aux))
                {
                    Numeros[j] = Numeros[j - 1];
                    j -= 1;
                }
                Numeros[j] = aux;
            }

            stopwatch.Stop();
            TempoProcessamento = stopwatch.Elapsed;
        }
    }
}
