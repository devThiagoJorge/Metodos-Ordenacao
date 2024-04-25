using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.Classes
{
    public class MergeSort
    {
        public int[] Numeros { get; private set; }
        public static TimeSpan TempoProcessamento { get; private set; }

        public MergeSort(int[] numeros)
        {
            Numeros = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                Numeros[i] = numeros[i];
            }
        }

        public void Ordenar()
        {
            var tamanho = Numeros.Length;
            var vaux = new int[tamanho];
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Ordenar(Numeros, vaux, 0, tamanho - 1);

            stopwatch.Stop();
            TempoProcessamento = stopwatch.Elapsed;
        }

        private void Ordenar(int[] vet, int[] aux, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                Ordenar(vet, aux, inicio, meio);
                Ordenar(vet, aux, meio + 1, fim);
                MontarVetor(vet, aux, inicio, meio, fim);
            }
        }

        private void MontarVetor(int[] vet, int[] aux, int ini, int meio, int fim)
        {
            for (int c = ini; c <= fim; c++) { aux[c] = vet[c]; }

            int a = ini;
            int b = meio + 1;

            for (int n = ini; n <= fim; n++)
            {

                if (a > meio)
                {
                    vet[n] = aux[b];
                    b++;
                }
                else if (b > fim)
                {
                    vet[n] = aux[a];
                    a++;
                }
                else if (aux[a] < aux[b])
                {
                    vet[n] = aux[a];
                    a++;
                }
                else
                {
                    vet[n] = aux[b];
                    b++;
                }
            }

        }
    }
}
