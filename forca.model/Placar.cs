using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca.Model
{
    public class Placar
    {
        private int idJogador;
        public string nomeJogador;
        public int scoreJogador;
        public DateTime dataScoreJogador;

        public Placar()
        {
        }

        public Placar(int idJogador, string nomeJogador, int scoreJogador, DateTime dataScoreJogador)
        {
            IdJogador = idJogador;
            NomeJogador = nomeJogador;
            ScoreJogador = scoreJogador;
            DataScoreJogador = dataScoreJogador;
        }

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public int ScoreJogador { get => scoreJogador; set => scoreJogador = value; }
        public DateTime DataScoreJogador { get => dataScoreJogador; set => dataScoreJogador = value; }
    }
}
