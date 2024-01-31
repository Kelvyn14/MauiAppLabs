namespace MauiAppLabs.Pages;

public partial class LoginPage : ContentPage
{
  public bool IsProcessing
  {
    get { return _isProcessing; }
    set
    {
      _isProcessing = value;
      OnPropertyChanged(nameof(IsProcessing));
    }
  }
  private bool _isProcessing = false;

  public LoginPage()
  {
    InitializeComponent();
    BindingContext = this;
  }

  private async void btnLogin_Clicked(object sender, EventArgs e)
  {
    IsProcessing = true;
    await Dispatcher.DispatchAsync(async () =>
    {
      Thread.Sleep(1000);
      IsProcessing = false;
      if (!string.IsNullOrWhiteSpace(entryUser.Text) && !string.IsNullOrWhiteSpace(entryPass.Text))
        await DisplayAlert("User logged!", "Login done successfully", "OK");
      else
        await DisplayAlert("User not found!", "Wrong user/password entered!", "OK");
    });

  }
}