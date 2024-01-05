namespace MauiAppLabs.Pages.NoXamlPages.Carousel;

public class CarouselCodedView : ContentPage
{
  public List<Monkey> Monkeys { get; set; } = new();
  public CarouselCodedView()
  {
    var newLabel = new Label
    {
      Text = "Teste carousel content",
      HorizontalTextAlignment = TextAlignment.Center,
      VerticalTextAlignment = TextAlignment.Center,
      FontSize = 24,
      TextColor = Colors.LightGoldenrodYellow
    };

    // Criação de uma lista de itens para o CarouselView
    var items = new[]
    {
                "Item 1",
                "Item 2",
                "Item 3"
            };

    // Criando o CarouselView
    var carouselView = new CarouselView
    {
      ItemsSource = items,
      ItemTemplate = new DataTemplate(() =>
      {
        var frame = new Frame
        {
          CornerRadius = 10,
          Padding = 20,
          BackgroundColor = Colors.LightBlue
        };

        var label = new Label();
        label.FontSize = 24;
        label.TextColor = Colors.DarkBlue;
        label.VerticalOptions = LayoutOptions.FillAndExpand;
        label.HorizontalOptions = LayoutOptions.FillAndExpand;
        label.SetBinding(Label.TextProperty, ".");

        frame.Content = label;

        return frame;
      }),
      VerticalOptions = LayoutOptions.FillAndExpand,
      HorizontalOptions = LayoutOptions.FillAndExpand
    };

    // Adicionando o CarouselView à página
    Content = new StackLayout
    {
      BackgroundColor = Colors.LightCoral,
      Children = { newLabel, carouselView }
    };

  }
}
