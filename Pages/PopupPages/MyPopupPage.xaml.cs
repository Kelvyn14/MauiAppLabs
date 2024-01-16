namespace MauiAppLabs.Pages.PopupPages;

public partial class MyPopupPage : ContentPage
{
	public MyPopupPage()
	{
		InitializeComponent();
       
    this.Loaded += Page_Loaded;
  }

  void Page_Loaded(object sender, EventArgs e)
  {
    // We only need this to fire once, so clean things up!
    this.Loaded -= Page_Loaded;

    // Call the animation
    PoppingIn();
  }

  private async void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
  {
    await Close();
  }


  async Task Close()
  {
    // Wait for the animation to complete
    await PoppingOut();
    // Navigate away without the default animation
    await Navigation.PopModalAsync(animated: false);
  }


  // PopingIn Animation
  public void PoppingIn()
  {
    // Measure the actual content size
    var contentSize = this.Content.Measure(Window.Width, Window.Height, MeasureFlags.IncludeMargins);
    var contentHeight = contentSize.Request.Height;

    // Start by translating the content below / off screen
    this.Content.TranslationY = contentHeight;

    // Animate the translucent background, fading into view
    this.Animate("Background",
        callback: v => this.Background = new SolidColorBrush(Colors.Black.WithAlpha((float)v)),
        start: 0d,
        end: 0.7d,
        rate: 32,
        length: 350,
        easing: Easing.CubicOut,
        finished: (v, k) =>
            this.Background = new SolidColorBrush(Colors.Black.WithAlpha(0.7f)));

    // Also animate the content sliding up from below the screen
    this.Animate("Content",
        callback: v => this.Content.TranslationY = (int)(contentHeight - v),
        start: 0,
        end: contentHeight,
        length: 500,
        easing: Easing.CubicInOut,
        finished: (v, k) => this.Content.TranslationY = 0);
  }

  // PoppingOut Animation
  public Task PoppingOut()
  {
    var done = new TaskCompletionSource();

    // Measure the content size so we know how much to translate
    var contentSize = this.Content.Measure(Window.Width, Window.Height, MeasureFlags.IncludeMargins);
    var windowHeight = contentSize.Request.Height;

    // Start fading out the background
    this.Animate("Background",
        callback: v => this.Background = new SolidColorBrush(Colors.Black.WithAlpha((float)v)),
        start: 0.7d,
        end: 0d,
        rate: 32,
        length: 350,
        easing: Easing.CubicIn,
        finished: (v, k) => this.Background = new SolidColorBrush(Colors.Black.WithAlpha(0.0f)));

    // Start sliding the content down below the bottom of the screen
    this.Animate("Content",
        callback: v => this.Content.TranslationY = (int)(windowHeight - v),
        start: windowHeight,
        end: 0,
        length: 500,
        easing: Easing.CubicInOut,
        finished: (v, k) =>
        {
          this.Content.TranslationY = windowHeight;
          // Important: Set our completion source to done!
          done.TrySetResult();
        });

    // We return the task so we can wait for the animation to finish
    return done.Task;
  }

}