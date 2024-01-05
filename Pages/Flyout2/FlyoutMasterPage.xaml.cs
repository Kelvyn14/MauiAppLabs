namespace MauiAppLabs.Pages.Flyout2;

public partial class FlyoutMasterPage : FlyoutPage
{
	public FlyoutMasterPage()
	{
		InitializeComponent();

    menuPage2.collectionView.SelectionChanged += OnSelectionChanged;

  }

  private void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
  {
    var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
    if (item != null)
    {
      Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
      IsPresented = false;
    }
  }
}