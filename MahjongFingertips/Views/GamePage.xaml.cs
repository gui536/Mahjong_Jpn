using MahjongFingertips.Models;
using MahjongFingertips.ViewModels;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace MahjongFingertips.Views;

public partial class GamePage : ContentPage
{

    Peca peca;

	public GamePage()
    {
        InitializeComponent();
        CreateMahjongTiles(AzulGrid);
        CreateMahjongTiles(VermelhoGrid);

       

        ExitButton.Clicked += OnExitButtonClicked;
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