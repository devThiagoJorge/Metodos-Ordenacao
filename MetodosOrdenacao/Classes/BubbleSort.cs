using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.Classes
{
    public class BubbleSort : Ordernacao
    {
        public int[] Numeros { get; private set; }
        public static TimeSpan TempoProcessamento { get; private set; }

        public BubbleSort(int[] numeros)
        {
            Numeros = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                Numeros[i] = numeros[i];
            }
        }

        public void Ordenar()
        {
            bool troca;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            do
            {
                troca = false;

                for (int i = 0; i < Numeros.Length - 1; i++)
                {

                    if (Numeros[i] > Numeros[i + 1])
                    {
                        int auxiliar = Numeros[i];
                        Numeros[i] = Numeros[i + 1];
                        Numeros[i + 1] = auxiliar;
                        troca = true;
                    }
                }

            } while (troca);

            stopwatch.Stop();
            TempoProcessamento = stopwatch.Elapsed;
            VetorOrdenado = Numeros;
        }
    }
}
