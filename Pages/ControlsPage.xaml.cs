namespace MauiAppLabs.Pages;

public partial class ControlsPage : ContentPage
{
	private List<string> MyPickerList;

  public ControlsPage()
	{
		InitializeComponent();
    MyPickerList = new List<string>
    {
      "Escolha um valor",
      "Valor teste 1",
      "Valor teste 2",
      "Valor teste 3",
      "Valor teste 4",
      "Valor teste 5",
      "Valor teste 6",
      "Valor teste 7",
      "Valor teste 8",
      "Valor teste 9",
      "Valor teste 10",
    };
    pickerTest.ItemsSource = MyPickerList;
    pickerTest.SelectedIndex = 0;
  }

  private void Robot_Tapped(object sender, EventArgs e)
  {
    pickerTest.Unfocus();
    pickerTest.Focus();
  }

}