using MahjongFingertips.Models;
using MahjongFingertips.ViewModels;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace MahjongFingertips.Views;

public partial class GamePage : ContentPage
{

    Peca pecaSorteada;
    int jogadorAtual;
    class Coluna
    {
        Jogador jogador;
        string tema;
        List<Peca> pecas;

        public Jogador Jogador { get => jogador; set => jogador = value; }
        public string Tema { get => tema; set => tema = value; }
        public List<Peca> Pecas { get => pecas; set => pecas = value; }
    }

    Coluna coluna1Azul = new Coluna();
    Coluna coluna2Azul = new Coluna();
    Coluna coluna3Azul = new Coluna();
    Coluna coluna4Azul = new Coluna();

    Coluna coluna1Vermelha = new Coluna();
    Coluna coluna2Vermelha = new Coluna();
    Coluna coluna3Vermelha = new Coluna();
    Coluna coluna4Vermelha = new Coluna();


    public GamePage()
    {
        InitializeComponent();
        CreateMahjongTiles(AzulGrid);
        CreateMahjongTiles(VermelhoGrid);
        jogadorAtual = new Random().Next(2);
        pecaSorteada = new Peca();
        pecaSorteada.Type = new Random().Next(0,3);
        

        ExitButton.Clicked += OnExitButtonClicked;
    }

    private void Rodada()
    {
       
    }    


    private void SelecionarColuna()
    {
        if (jogadorAtual == 0)
        {
            //Jogador Azul
            //Desabilitar o clique da coluna vermelha

            coluna1Azul.Tema == null 
            
        }
        else
        {
            //Jogador Vermelho
        }
    }

    private void CreateMahjongTiles(Grid PlayerGrid)
    {
        var tileImages = new List<string>
        {
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
            "peca.png",
        };
        int imageIndex = 0;
        //Logica do player 1
        for (int row = 0; row < 4; row++)
        {
            for(int col = 0; col < 4; col++)
            {
                var tile = new Image
                {
                    Source = tileImages[imageIndex],
                    WidthRequest = 50,
                    HeightRequest = 50,  
                };
                PlayerGrid.SetRow(tile, row);
                PlayerGrid.SetColumn(tile, col);
                PlayerGrid.Children.Add(tile);
                imageIndex = (imageIndex + 1) %  tileImages.Count;
            }
        }
    }



    private async void OnExitButtonClicked(Object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Confirmação", "Deseja sair?", "Sim", "Não");
        if (confirm)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}