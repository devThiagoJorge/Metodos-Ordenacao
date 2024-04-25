using MetodosOrdenacao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosOrdenacao
{
    public partial class FormGerarDados : Form
    {
        public FormGerarDados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.Show();

            Close();
        }

        private void btnGerarDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Informe um valor para o campo.");
                return;
            }


            var quantidade = int.Parse(txtQuantidade.Text);

            if(quantidade % 10 != 0)
            {
                MessageBox.Show("A quantidade não é múltiplo de 10.");
                return;
            }

            var random = new Random();
            var vetor = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                vetor[i] = random.Next(quantidade); 
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
