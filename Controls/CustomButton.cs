using MauiAppLabs.Animations;

namespace MauiAppLabs.Controls;

public class CustomButton : Button
{

  /// <summary>
  /// Evento disparado quando o botão é clickado
  /// </summary>
  new public event EventHandler Clicked
  {
    add { _Clicked += value; }
    remove { _Clicked -= value; }
  }

  private event EventHandler _Clicked;

  public CustomButton() : base()
  {
    base.Clicked += CustomButton_Clicked;

  }

  private async void CustomButton_Clicked(object? sender, EventArgs e)
  {
    if (_Clicked != null)
    {
      // Verifica se já existe um botão em animação
      if (!AnimateButton.IsAnimate)
      {
        AnimateButton.IsAnimate = true;

        try
        {
          // Executa animação do clique do botão
          await AnimateButton.Execute(this);

          // Dispara evento do botão
          _Clicked(this, e);
        }
        finally
        {
          AnimateButton.IsAnimate = false;
        }
      }
    }
  }
}
