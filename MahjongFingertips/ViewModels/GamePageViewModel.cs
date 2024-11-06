using MahjongFingertips.Models;
using MahjongFingertips.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MahjongFingertips.ViewModels
{
    //Nessa classe ficará toda a lógica do "jogo".
    public class GamePageViewModel
    {
        //Essa APIService é a classe de serviço implementada
        private readonly ApiService _apiService;

        //Esses Colunas representam o seu tabuleiro e azul e vermelho os jogadores
        public List<Peca> Coluna1Azul;
        public List<Peca> Coluna2Azul;
        public List<Peca> Coluna3Azul;
        public List<Peca> Coluna4Azul;

        public List<Peca> Coluna1Vermelho;
        public List<Peca> Coluna2Vermelho;
        public List<Peca> Coluna3Vermelho;
        public List<Peca> Coluna4Vermelho;

        public int jogadorAtual;

        public Peca PecaSorteada;

        public ObservableCollection<Jogador> Jogadores { get; set; }
        public ICommand IniciarPartidaCommand { get; }

        GamePageViewModel()
        {
            _apiService = new ApiService();
            Jogadores = new ObservableCollection<Jogador>();
        }

        public void Jogar()
        {
            //Essa é a lógica de uma jogada
            
            //Primeiro descobrir quem começa sorteando a peça inicial
            PecaSorteada = new Peca();
            //Se ela é do jogador 1 ou 2
            PecaSorteada.Type = new Random().Next(2);
            //Qual a coluna inicial
            PecaSorteada.Column = new Random().Next(4);
        }

        public void SortearPeca() {
            //Se ela é do jogador 1 ou 2
            PecaSorteada.Type = new Random().Next(2);
            //Qual a coluna inicial
            PecaSorteada.Column = new Random().Next(4);
        }

        public void SelecionarPeca()
        {
            //Essa é a lógica quando o jogador seleciona uma peça no tabuleiro
            if (PecaSorteada.Type == 1)
            {
                //Ele verifica qual é a coluna da peça sorteada e a adiciona lá
                switch (PecaSorteada.Column)
                {
                    case 0:
                        Coluna1Azul.Add(PecaSorteada);
                        break;
                    case 1:
                        Coluna2Azul.Add(PecaSorteada);
                        break;
                    case 2:
                        Coluna3Azul.Add(PecaSorteada);
                        break;
                    case 3:
                        Coluna4Azul.Add(PecaSorteada);
                        break;
                    default:
                        SortearPeca();
                        break;
                }
            }
            else
            {
                jogadorAtual = 2;
                switch (PecaSorteada.Column)
                {
                    case 0:
                        Coluna1Vermelho.Add(PecaSorteada);
                        break;
                    case 1:
                        Coluna2Vermelho.Add(PecaSorteada);
                        break;
                    case 2:
                        Coluna3Vermelho.Add(PecaSorteada);
                        break;
                    case 3:
                        Coluna4Vermelho.Add(PecaSorteada);
                        break;
                    default:
                        SortearPeca();
                        break;
                }
            }
            //Depois da jogada é sorteada uma nova peça e o ciclo recomeça;
            SortearPeca();
        }

    }
}
