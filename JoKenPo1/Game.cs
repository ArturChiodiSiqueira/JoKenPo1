using System;
using System.Drawing;

namespace JoKenPo1
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Preder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();
            ImgJogador = images[jogador];
            ImgPC = images[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Preder;
            }
        }

        private int JogadaPC()
        {
           int milissegundo = DateTime.Now.Millisecond;
            if (milissegundo < 333)
            {
                return 0;
            }
            else if (milissegundo >= 333 && milissegundo < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
}
