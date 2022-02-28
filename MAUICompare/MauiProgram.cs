namespace MAUICompare;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("icomoon.ttf", "FA");
			});

		Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
		Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

		return builder.Build();
	}
}