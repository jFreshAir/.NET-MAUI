namespace RMR.naloga1_UV_.Freser;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var a = new NavigationPage(new MainPage());
		a.BarBackgroundColor = Colors.White;
		MainPage = a;
	}
}
