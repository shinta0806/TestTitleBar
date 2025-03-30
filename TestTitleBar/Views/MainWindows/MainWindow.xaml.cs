namespace TestTitleBar.Views.MainWindows;

public sealed partial class MainWindow : WindowEx
{
	public MainWindow()
	{
		InitializeComponent();

		// タスクバーに反映される
		AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
		Title = "TestTitleBar";

		Content = new MainPage(this);
	}
}
