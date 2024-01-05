namespace MauiAppLabs.Pages;

public partial class CarouselView3 : ContentPage
{
  public List<Monkey> Monkeys { get; set; } = new();
  public CarouselView3()
	{
		InitializeComponent();
    BindingContext = this;
    FillMonkeys();
  }

  private void FillMonkeys()
  {
    Monkeys.Clear();
    Monkeys.AddRange(new List<Monkey>
    {
      new Monkey{ Name="José",Location="",Details="", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Bonnet_macaque_%28Macaca_radiata%29_Photograph_By_Shantanu_Kuveskar.jpg"},
      new Monkey{ Name="Tobias",Location="",Details="", ImageUrl = "https://cdn.britannica.com/06/150806-050-6AE99C98/Proboscis-monkey.jpg"},
      new Monkey{ Name="Nerço",Location="",Details="", ImageUrl = "https://cff2.earth.com/uploads/2023/04/24134721/Smart-monkey-960x640.jpg"},
      new Monkey{ Name="Juaum",Location="",Details="", ImageUrl = "https://www.science.org/do/10.1126/science.adk0579/full/_20230731_nid_macaques-1691006593867.jpg"},
    });
  }
}