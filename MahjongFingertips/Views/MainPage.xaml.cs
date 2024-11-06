using MahjongFingertips.ViewModels;

namespace MahjongFingertips.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(); // Vincula a MainPage ao ViewModel

        }
        

    }
}

