using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestTitleBar.ViewModels.MainWindows;

public partial class MainPageViewModel : ObservableRecipient
{
	public MainPageViewModel()
	{
		NotImplementedClickedCommand = new(NotImplementedClicked);
	}

	#region 未実装
	public RelayCommand NotImplementedClickedCommand
	{
		get;
	}

	private async void NotImplementedClicked()
	{
		await App.MainWindow.ShowMessageDialogAsync("未実装");
	}
	#endregion
}
