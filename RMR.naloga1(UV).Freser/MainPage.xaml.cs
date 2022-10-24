//using Org.Apache.Http.Conn;

namespace RMR.naloga1_UV_.Freser;

public partial class MainPage : ContentPage
{
	//int count = 0;
	private string usrName = "admin";
	private string password = "admin";

	public MainPage()
	{
		InitializeComponent();
	}

	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		string inputName = txtUsername.Text;
		string inputPassword = txtPassword.Text;

		if (txtUsername.Text == String.Empty || txtPassword.Text == String.Empty)
			return;

		if (string.Compare(inputName, usrName) == 0 && string.Compare(inputPassword, password) == 0)
		{
			var a =	new NavigationPage(new SyllabusPage());
			a.BarBackgroundColor = Colors.WhiteSmoke;
			a.BarTextColor = Colors.Gray;
			Navigation.PushAsync(a);
			
		}
		else
			lblError.TextColor = Colors.Red;
	}

	private void btnAbout_Clicked(object sender, EventArgs e)
	{
		var a = new NavigationPage(new AboutPage());
		a.BarBackgroundColor = Colors.WhiteSmoke;
		a.BarTextColor = Colors.Gray;	
		Navigation.PushAsync(a);
	}

	private void txtUsername_Focused(object sender, FocusEventArgs e)
	{
		if (lblError.TextColor == Colors.Red)
			lblError.TextColor = Colors.White;
	}

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}
}

