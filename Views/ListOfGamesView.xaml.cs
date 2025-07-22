using Microsoft.Maui.Controls;
using NetMauiGameLibary.ViewModels;

namespace NetMauiGameLibary.Views
{
    public partial class ListOfGamesView : ContentPage
    {
        public ListOfGamesView(ListOfGamesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
