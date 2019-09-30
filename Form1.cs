using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoFelipe
{
    public partial class Form1 : Form
    {
        Random R1,R2;
        int numRandon1, numRandon2;
        int[] contadorImg1 = { 0, 0, 0, 0 };
        //int[] contadorImg2 = { 0, 0, 0, 0 };
        int verificaContador = 0;
        public Form1()
        {
            InitializeComponent();
            btnImagem1.Text = "";
            btnImagem2.Text = "";
            R1 = new Random();
            R2 = new Random();
            numRandon1 = R1.Next(1, 5);
            numRandon2 = R2.Next(1, 5);
            while (numRandon2 == numRandon1)
            {
                numRandon2 = R2.Next(1, 5);
            }
            switch (numRandon1)
            {
                case 1:
                    this.btnImagem1.BackgroundImage = Properties.Resources.xratao;
                    break;
                case 2:
                    this.btnImagem1.BackgroundImage = Properties.Resources.saladafrutas;
                    break;
                case 3:
                    this.btnImagem1.BackgroundImage = Properties.Resources.macarrao;
                    break;
                case 4:
                    this.btnImagem1.BackgroundImage = Properties.Resources.lasanha;
                    break;
                default:
                    MessageBox.Show("Algo deu errado!");
                    break;
            }

            switch (numRandon2)
            {
                case 1:
                    this.btnImagem2.BackgroundImage = Properties.Resources.xratao;
                    break;
                case 2:
                    this.btnImagem2.BackgroundImage = Properties.Resources.saladafrutas;
                    break;
                case 3:
                    this.btnImagem2.BackgroundImage = Properties.Resources.macarrao;
                    break;
                case 4:
                    this.btnImagem2.BackgroundImage = Properties.Resources.lasanha;
                    break;
                default:
                    MessageBox.Show("Algo deu errado!");
                    break;
            }
        }

        private void btnImagem1_Click(object sender, EventArgs e)
        {
            numRandon1 = R1.Next(1, 5);
            while (numRandon1 == numRandon2)
            {
                numRandon1 = R1.Next(1, 5);
            }
            switch (numRandon1)
            {
                case 1:
                    this.btnImagem1.BackgroundImage = Properties.Resources.xratao;
                    contadorImg1[0]++;
                    break;
                case 2:
                    this.btnImagem1.BackgroundImage = Properties.Resources.saladafrutas;
                    contadorImg1[1]++;
                    break;
                case 3:
                    this.btnImagem1.BackgroundImage = Properties.Resources.macarrao;
                    contadorImg1[2]++;
                    break;
                case 4:
                    this.btnImagem1.BackgroundImage = Properties.Resources.lasanha;
                    contadorImg1[3]++;
                    break;
                default:
                    MessageBox.Show("Algo deu errado!");
                    break;
            }
            verificaContador++;
            if (verificaContador == 10)
            {
                MessageBox.Show("Resultado\n\n" +
                    "X-Ratão : " + contadorImg1[0] + "\n" +
                    "Salada De Fruta : " + contadorImg1[1] + "\n" +
                    "XMacarrão : " + contadorImg1[2] + "\n" +
                    "Lasanha : " + contadorImg1[3] + "\n", "Sistema Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificaContador = 0;
            }
        }

        private void btnImagem2_Click(object sender, EventArgs e)
        {
            numRandon2 = R2.Next(1, 5);
            while (numRandon2 == numRandon1)
            {
                numRandon2 = R2.Next(1, 5);
            }
            switch (numRandon2)
            {
                case 1:
                    this.btnImagem2.BackgroundImage = Properties.Resources.xratao;
                    contadorImg1[0]++;
                    break;
                case 2:
                    this.btnImagem2.BackgroundImage = Properties.Resources.saladafrutas;
                    contadorImg1[1]++;
                    break;
                case 3:
                    this.btnImagem2.BackgroundImage = Properties.Resources.macarrao;
                    contadorImg1[2]++;
                    break;
                case 4:
                    this.btnImagem2.BackgroundImage = Properties.Resources.lasanha;
                    contadorImg1[3]++;
                    break;
                default:
                    MessageBox.Show("Algo deu errado!");
                    break;
            }
            verificaContador++;
            if (verificaContador == 10)
            {
                MessageBox.Show("Resultado\n\n" +
                    "X-Ratão : " + contadorImg1[0] + "\n" +
                    "Salada De Fruta : " + contadorImg1[1] + "\n" +
                    "XMacarrão : " + contadorImg1[2] + "\n" +
                    "Lasanha : " + contadorImg1[3] + "\n","Sistema Informa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                verificaContador = 0;
                //For para zerar vetor contador
                for(int i = 0; i <= 3; i++)
                {
                    contadorImg1[i] = 0;
                }
            }
        }
    }
}
