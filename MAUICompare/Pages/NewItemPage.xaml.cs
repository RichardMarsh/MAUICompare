using MAUICompare.ViewModels;

namespace MAUICompare;

public partial class NewItemPage : ContentPage
{
	public NewItemPage()
	{
		InitializeComponent();
		BindingContext = new NewItemViewModel();
	}
}