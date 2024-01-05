namespace MauiAppLabs.Pages;

public class NewPageContent1 : ContentPage
{
	public NewPageContent1()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to coded page with .NET MAUI!"
				}
			}
		};
	}
}