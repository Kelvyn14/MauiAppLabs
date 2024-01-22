using MauiAppLabs.Pages.PopupPages;
using MauiAppLabs.Pages.QRCode;
using MauiAppLabs.ViewModels;

namespace MauiAppLabs;

public partial class MainPage : ContentPage
{
  MainPageViewModel ViewModel = new();
  public MainPage()
  {
    InitializeComponent();
    // Set the BindingContext of the page to the MyViewModel instance
    BindingContext = ViewModel;
  }

  private void BtnEntrar_Clicked_1(object sender, EventArgs e)
  {
    ViewModel.SwitchLoading();
    ViewModel.SetName("João e Maria - ");
  }

  private async void BtnPopupPage_Clicked(object sender, EventArgs e)
  {
    // Show popup page
    await Navigation.PushModalAsync(new MyPopupPage());
  }

  private async void BtnBarcodePage_Clicked(object sender, EventArgs e)
  {
    await Navigation.PushModalAsync(new QRCodeReaderPage());
  }
}
