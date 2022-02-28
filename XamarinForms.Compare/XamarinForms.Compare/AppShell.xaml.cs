using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinForms.Compare.ViewModels;
using XamarinForms.Compare.Views;

namespace XamarinForms.Compare
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
