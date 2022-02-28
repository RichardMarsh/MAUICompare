using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Compare.Services;
using XamarinForms.Compare.Views;

namespace XamarinForms.Compare
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
