using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiAppLabs
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
      var builder = MauiApp.CreateBuilder();
      builder
        .UseMauiApp<App>()
        .UseMauiCompatibility()        
        .ConfigureFonts(fonts =>
        {
          fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
          fonts.AddFont("SFProDisplay-Bold.ttf", "SFProDisplay-Bold");
          fonts.AddFont("SFProDisplay-Regular.ttf", "SFProDisplay-Regular");
          fonts.AddFont("SFProDisplay-Semibold.ttf", "SFProDisplay-Semibold");
        });

#if DEBUG
  		builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}
