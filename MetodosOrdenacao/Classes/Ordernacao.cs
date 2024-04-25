using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.Classes
{
    public abstract class Ordernacao
    {
        public static int[] VetorOrdenado { get; set; }

        public static void MostrarResultado()
        {
            MessageBox.Show(@$"
                Quantidade de números ordenados: {VetorOrdenado.Length}
                Método BubbleSort: {BubbleSort.TempoProcessamento}
                Método QuickSort: {QuickSort.TempoProcessamento}
                Método MergeSort: {MergeSort.TempoProcessamento}
                Método InsertionSort: {InsertionSort.TempoProcessamento}
                Método SelectionSort: {SelectionSort.TempoProcessamento}
            ");

            string message = "Deseja salvar o vetor em um arquivo?";
            string caption = "Fechar";

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Arquivo.GravarVetor(VetorOrdenado);
            }
        }
    }
}
