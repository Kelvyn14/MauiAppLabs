using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppLabs.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
  [ObservableProperty]
  private string _name;

  [ObservableProperty]
  private bool _isLoading;


  public void SwitchLoading()
  {
    IsLoading = !IsLoading;
  }


  public void SetName(string name)
  {
    Name = name + new Random().Next(1000);
  }

}