using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        Image[] imgCPU = new Image[]
        {
           Properties.Resources.PedraC,
           Properties.Resources.PapelC,
           Properties.Resources.TesouraC
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            pictureBoxJogador.Image = botao.BackgroundImage;
            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(botao.Tag));
            Jogada jogadaCPU = RetornaJogadaDaCPU();
            Resultado resultado = RetornaGanhador(jogadaJogador, jogadaCPU);

            if (resultado == Resultado.VitoriaCPU)
            {
                labelPontuacaoCPU.Text = (int.Parse(labelPontuacaoCPU.Text) + 1). ToString();
            } else if (resultado == Resultado.VitoriaJogador)
            {
                labelPontuacaoJogador.Text = (int.Parse(labelPontuacaoJogador.Text) + 1).ToString();
            } 
        }

        private Resultado RetornaGanhador(Jogada Jogador, Jogada CPU)
        {
            if(Jogador == Jogada.Pedra)
            {   
                if(CPU == Jogada.Papel)
                {
                    return Resultado.VitoriaCPU;
                }else if (CPU == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }else if(Jogador == Jogada.Papel)
            {
                if(CPU == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }else if(CPU == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCPU;
                }
            }else
            {
                if(CPU == Jogada.Pedra)
                {
                    return Resultado.VitoriaCPU;
                }else if (CPU == Jogada.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empate;
        }

        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDaCPU()
        {
            Random random = new Random();
            int escolha = random.Next(3);
            pictureBoxCPU.Image = imgCPU[escolha];
            return (Jogada)escolha;
        }
    }

    enum Jogada
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    enum Resultado
    {
        VitoriaJogador,
        VitoriaCPU,
        Empate
    }
}
