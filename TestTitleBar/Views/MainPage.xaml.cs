using Microsoft.UI.Xaml.Controls;

using TestTitleBar.ViewModels;

namespace TestTitleBar.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
