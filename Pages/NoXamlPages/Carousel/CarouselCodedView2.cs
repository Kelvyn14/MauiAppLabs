namespace MauiAppLabs.Pages.NoXamlPages.Carousel;

public class CarouselCodedView2 : ContentPage
{
  public List<Monkey> Monkeys { get; set; } = new();
  public string CurrentLabel { get; set; }

  public CarouselCodedView2()
  {
    var newLabel = new Label
    {
      Text = "Test dynamic carousel content",
      HorizontalTextAlignment = TextAlignment.Center,
      VerticalTextAlignment = TextAlignment.Center,
      FontSize = 24,
      TextColor = Colors.Black,
      FontAttributes = FontAttributes.Bold
    };

    // Criação de uma lista de itens para o CarouselView
    var items = new[]
               {
                new ItemModel { ItemName = "Item 1" },
                new ItemModel { ItemName = "Item 2" },
                new ItemModel { ItemName = "Item 3" }
            };

    // Criando o CarouselView
    var carouselView = new CarouselView
    {
      ItemsSource = items,
      ItemTemplate = new DataTemplate(() =>
      {
        return new ContentViewWithListView();
      }),
      VerticalOptions = LayoutOptions.FillAndExpand,
      HorizontalOptions = LayoutOptions.FillAndExpand
    };

    // Adicionando o CarouselView à página
    Content = new StackLayout
    {
      BackgroundColor = Colors.LightBlue,
      Children = { newLabel, carouselView }
    };
  }

  public class ContentViewWithListView : ContentView
  {
    public ContentViewWithListView()
    {
      var label = new Label
      {
        FontSize = 20,
        TextColor = Colors.Black
      };

      label.SetBinding(Label.TextProperty, "ItemName");

      var listView = new ListView
      {
        ItemsSource = new[] { "Subitem 1", "Subitem 2", "Subitem 3" },
        VerticalOptions = LayoutOptions.FillAndExpand,
        HorizontalOptions = LayoutOptions.FillAndExpand
      };

      var frame = new Frame
      {
        CornerRadius = 10,
        Padding = 20,
        BackgroundColor = Colors.White,
        BorderColor = Colors.WhiteSmoke,
        VerticalOptions = LayoutOptions.FillAndExpand,
        HorizontalOptions = LayoutOptions.FillAndExpand
      };

      frame.Content = listView;

      Content = new StackLayout { Children = { label, frame } };
    }
  }

  // Classe auxiliar para atribuir a propriedade 'ItemName'
  public class ItemModel
  {
    public string ItemName { get; set; }
  }
}
