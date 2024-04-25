using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.Classes
{
    public class QuickSort
    {
        public int[] Numeros { get; private set; }
        public static TimeSpan TempoProcessamento { get; private set; }

        public QuickSort(int[] numeros)
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
            Ordenar(Numeros, 0, Numeros.Length - 1);
            stopwatch.Stop();

            TempoProcessamento = stopwatch.Elapsed;
        }

        public void Ordenar(int[] vetor, int left, int right)
        {
            int i, j, x;
           
            i = left;
            j = right;
            x = vetor[(left + right) / 2];

            while (true)
            {
                while (vetor[i] < x)
                    i++;
                while (x < vetor[j])
                    j--;
                if (i <= j)
                {
                    TrocarValores(vetor, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (left < j)
                Ordenar(vetor, left, j);

            if (i < right)
                Ordenar(vetor, i, right);
        }

        public static int[] TrocarValores(int[] arrayDados, int m, int n)
        {
            int temp = arrayDados[m];
            arrayDados[m] = arrayDados[n];
            arrayDados[n] = temp;
            return arrayDados;
        }

    }
}
