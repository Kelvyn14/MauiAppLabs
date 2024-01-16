using MauiAppLabs.Pages;
using MauiAppLabs.Pages.NoXamlPages.Carousel;

namespace MauiAppLabs;

public partial class App : Application
{
  public App()
  {
    InitializeComponent();

    MainPage = new AppShell();
    //MainPage = new MasterPage();
    //MainPage = new FlyoutMasterPage();
    //MainPage = new CarouselPage();
    //MainPage = new CarouselPage2();
    //MainPage = new CarouselView3();
    //MainPage = new NewPageContent1();
    //MainPage = new CarouselCodedView();
    //MainPage = new CarouselCodedView2();
    //MainPage = new FrameLayoutsPage();
    //MainPage = new ControlsPage();
    //MainPage = new ListPage1();
  }
}
