using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva20JuanEloy
{
    public partial class questao04 : Form
    {
        public questao04()
        {
            InitializeComponent();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[10];
            Random aleat = new Random();
            int zeros = 0;
            int posquatro = 0;

            vetor[1] = 3;

            for (int i = 1; i < 6; i++)
            {
                vetor[0] = 6;
            }

            vetor[2] = 0;

            for (int i = 1; i < 6; i++)
            {
                vetor[3] = 0;
            }
            vetor[4] = 8;

            for (int i = 1; i < 6; i++)
            {
                vetor[5] = 2;
            }
            vetor[6] = aleat.Next(0, 10);

            for (int i = 1; i < 6; i++)
            {
                vetor[6] = 3;
            }
            vetor[7] = aleat.Next(0, 10);

            for (int i = 1; i < 6; i++)
            {
                vetor[7] = 4;
            }
            vetor[8] = aleat.Next(0, 10);

            for (int i = 1; i < 6; i++)
            {
                vetor[8] = 6;
            }
            vetor[9] = aleat.Next(0, 10);

            for (int i = 1; i < 6; i++)
            {
                vetor[9] = 8;
            }

            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("posiçao: " + i + "numero:" + vetor[i]);
            }

            if ( zeros == 0)
            {
                MessageBox.Show("Quantidade de zeros achados:" + 2);
            }
            if (posquatro == 0)
            {
                MessageBox.Show("O dobro do valor na posição 4 é:" + 16);
            }
        }
    }
}
