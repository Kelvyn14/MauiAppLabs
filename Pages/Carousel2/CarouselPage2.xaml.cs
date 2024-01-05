
namespace MauiAppLabs.Pages;

public partial class CarouselPage2 : ContentPage
{
  public List<MyContent> MyViews { get; set; } = new();
  public List<string> MyWords { get; set; } = new();

  public CarouselPage2()
  {
    InitializeComponent();
    //BindingContext = this;
    //FillViews();
  }

  private void FillViews()
  {
    MyViews.Clear();
    MyViews.AddRange(new List<MyContent>
    {
      new MyContent{Title = "teste 1", Id=1, StepTitle="Solicitado"},
      new MyContent{Title = "teste 2", Id=2, StepTitle="A fazer"},
      new MyContent{Title = "teste 3", Id=3, StepTitle="Feito"},
      new MyContent{Title = "teste 4", Id=4, StepTitle="Arquivado"},
    });

    MyWords.Clear();
    MyWords.AddRange(new string[] { "teste 1", "teste 2", "teste 3", "teste 4" });
  }

  public class MyContent()
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string StepTitle { get; set; }
  }
}
