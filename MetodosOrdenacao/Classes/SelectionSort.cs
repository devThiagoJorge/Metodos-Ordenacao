using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.Classes
{
    public class SelectionSort
    {
        public int[] Numeros { get; private set; }
        public static TimeSpan TempoProcessamento { get; private set; }

        public SelectionSort(int[] numeros)
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
            int indice, aux = 0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                indice = i;

                for (int k = i + 1; k < Numeros.Length; k++)
                {

                    if (Numeros[k] < Numeros[indice])
                    {
                        indice = k;
                    }
                }

                aux = Numeros[i];
                Numeros[i] = Numeros[indice];
                Numeros[indice] = aux;

            }

            stopwatch.Stop();
            TempoProcessamento = stopwatch.Elapsed;
        }

    }
}
