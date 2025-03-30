using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using TestTitleBar.ViewModels.MainWindows;

namespace TestTitleBar.Views.MainWindows;

public sealed partial class MainPage : Page
{
	public MainPageViewModel ViewModel
	{
		get;
	}

	public MainPage(MainWindow mainWindow)
	{
		ViewModel = new();
		InitializeComponent();

		// カスタムタイトルバー：Loading() / Loaded() でやると一瞬レイアウト変更してるのが見えるのでコンストラクターでやるのがよさそう
		mainWindow.ExtendsContentIntoTitleBar = true;
		FrameworkElement? customTitleBar = FindName("TitleLine") as FrameworkElement;
		if (customTitleBar != null)
		{
			mainWindow.SetTitleBar(customTitleBar);
		}
	}
}
