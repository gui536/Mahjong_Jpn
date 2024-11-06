using System.Collections.ObjectModel;
using System.Windows.Input;
using MahjongFingertips.Models;
using MahjongFingertips.Services;

namespace MahjongFingertips.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly ApiService _apiService;

        public ObservableCollection<Jogador> Jogadores { get; set; }
        public ICommand IniciarPartidaCommand { get; }

        public MainPageViewModel()
        {
            _apiService = new ApiService();
            Jogadores = new ObservableCollection<Jogador>();
            IniciarPartidaCommand = new Command(IniciarPartida);
            CarregarJogadores();
        }

        private async void CarregarJogadores()
        {
            var jogadores = await _apiService.ObterJogadoresAsync();
            foreach (var jogador in jogadores)
                Jogadores.Add(jogador);
        }

        private async void IniciarPartida()
        {
            await Shell.Current.GoToAsync("///GamePage");
        }
    }
}
