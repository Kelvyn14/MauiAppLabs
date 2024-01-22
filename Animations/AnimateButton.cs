namespace MauiAppLabs.Animations;

public class AnimateButton
{
  /// <summary>
  /// Indica se existe um controle executando uma animação
  /// </summary>
  public static bool IsAnimate { get; set; }

  /// <summary>
  /// Executa animação do click do botão ou item da lista.
  /// </summary>
  /// <param name="visualElement"></param>
  public static async Task Execute(VisualElement visualElement)
  {
    visualElement.Opacity = 0.8;
    visualElement.AnchorX = 0.50;
    visualElement.AnchorY = 0.50;
    await visualElement.ScaleTo(0.95, 100, Easing.Linear);
    await Task.Delay(100);
    await visualElement.ScaleTo(1.0, 100, Easing.Linear);
    visualElement.Opacity = 1.0;
  }
}
