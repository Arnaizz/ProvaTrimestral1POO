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
    public partial class questao03 : Form
    {
        public questao03()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            int soma = 0;

            Random sorteados = new Random();

            for (int i = 1; i < 7; i++)
            {
                soma = sorteados.Next(1, 7);
            }

            if (soma < 5)
            {
                MessageBox.Show("Jogador á Direita.");
            }
            else if (soma == 5)
            {
                MessageBox.Show("Compre uma nova carta!");
            }
            else if (soma > 5)
            {
                MessageBox.Show("O jogador dois perdeu.");
            }
            else
            {
                MessageBox.Show("Acabou.");
            }
        }
    }
}
