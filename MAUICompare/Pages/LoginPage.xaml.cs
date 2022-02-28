using MAUICompare.ViewModels;

namespace MAUICompare;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel();
	}
}