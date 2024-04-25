using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosOrdenacao.Classes
{
    public static class Arquivo
    {
        public static void GravarVetor(int[] numeros)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                var caminhoSelecionado = fbd.SelectedPath;

                if (result == DialogResult.Cancel || string.IsNullOrWhiteSpace(caminhoSelecionado))
                    return;

                var quantidadeArquivos = Directory.GetFiles(caminhoSelecionado).Length;

                string arquivo = $"{caminhoSelecionado}\\teste_{quantidadeArquivos + 1}_{numeros.Length}.txt";

                var streamRider = File.CreateText(arquivo);

                for (int i = 0; i < numeros.Length; i++)
                {
                    streamRider.WriteLine(numeros[i]);
                }

                streamRider.Close();


                MessageBox.Show($"Arquivo criado: {arquivo}");
            }

        }

        public static void LerVetor()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Localizar Arquivos";
            var result = openFile.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            var arquivo = openFile.FileName;


            string[] lines = File.ReadAllLines(arquivo);
            var vetor = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                vetor[i] = int.Parse(lines[i]);
            }

            var bubbleSort = new BubbleSort(vetor);
            var insertionSort = new InsertionSort(vetor);
            var mergeSort = new MergeSort(vetor);
            var selectionSort = new SelectionSort(vetor);
            var quickSort = new QuickSort(vetor);

            bubbleSort.Ordenar();
            insertionSort.Ordenar();
            mergeSort.Ordenar();
            selectionSort.Ordenar();
            quickSort.Ordenar();

            Ordernacao.MostrarResultado();
        }
    }
}
