#if DEBUG
using System.Diagnostics;
#endif

namespace MauiAppLabs.Pages;

public partial class ListPage1 : ContentPage
{
  public List<MyList> Lista { get; set; }
  public ListPage1()
  {
    InitializeComponent();

    Lista = new List<MyList>
    {
      new MyList { Title="Teste Item 1", Description = "Teste Item 1 Description", Index = 0},
      new MyList { Title="Teste Item 2", Description = "Teste Item 2 Description", Index = 1},
      new MyList { Title="Teste Item 3", Description = "Teste Item 3 Description", Index = 2},
      new MyList { Title="Teste Item 4", Description = "Teste Item 4 Description", Index = 3},
      new MyList { Title="Teste Item 5", Description = "Teste Item 5 Description", Index = 4},
      new MyList { Title="Teste Item 6", Description = "Teste Item 6 Description", Index = 5},
      new MyList { Title="Teste Item 7", Description = "Teste Item 7 Description", Index = 6},
      new MyList { Title="Teste Item 8", Description = "Teste Item 8 Description", Index = 7},
      new MyList { Title="Teste Item 9", Description = "Teste Item 9 Description", Index = 8},
      new MyList { Title="Teste Item 10", Description = "Teste Item 10 Description", Index = 9},
      new MyList { Title="Teste Item 11", Description = "Teste Item 11 Description", Index = 10},
    };

    BindingContext = this;
    stepList.ItemsSource = Lista;
  }

  private void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
  {

  }

  private void OnRefresh(object sender, EventArgs e)
  {

  }

  private void stepList_ItemAppearing(object sender, ItemVisibilityEventArgs e)
  {
    MainThread.BeginInvokeOnMainThread(new Action(() =>
    {
      Debug.WriteLine($"Index do item no 'Appearing': {e.ItemIndex}");
    }));
  }
}

public class MyList
{
  public string Title { get; set; }
  public string Description { get; set; }
  public int Index { get; set; }
}