using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLabs.Pages.Flyout;

public class MasterPage : FlyoutPage
{
  public MasterPage()
  {
    this.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;

    Flyout = new MenuPage
    {
      IsVisible = true,
      Title = "☰­"
    };


    Detail = new NavigationPage(new ContentPage1());


  }
}
