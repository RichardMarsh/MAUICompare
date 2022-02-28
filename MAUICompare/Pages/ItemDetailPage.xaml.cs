using MAUICompare.ViewModels;

namespace MAUICompare;

public partial class ItemDetailPage : ContentPage
{
	public ItemDetailPage()
	{
		InitializeComponent();
		BindingContext = new ItemDetailViewModel();
	}
}