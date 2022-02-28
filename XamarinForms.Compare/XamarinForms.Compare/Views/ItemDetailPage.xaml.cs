using System.ComponentModel;
using Xamarin.Forms;
using XamarinForms.Compare.ViewModels;

namespace XamarinForms.Compare.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}