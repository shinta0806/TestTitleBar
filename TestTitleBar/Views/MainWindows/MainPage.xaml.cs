using Microsoft.UI.Xaml.Controls;

using TestTitleBar.ViewModels;
using TestTitleBar.ViewModels.MainWindows;

namespace TestTitleBar.Views.MainWindows;

public sealed partial class MainPage : Page
{
	public MainPageViewModel ViewModel
	{
		get;
	}

	public MainPage()
	{
		ViewModel = new();
		InitializeComponent();
	}
}
