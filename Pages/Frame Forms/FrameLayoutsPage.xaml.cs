using System.Text;

namespace MauiAppLabs.Pages;

public partial class FrameLayoutsPage : ContentPage
{
  /// <summary>
  /// Últimos usuários da discussão
  /// </summary>
  public Grid LastUsersDiscussion { get; private set; } = [];
  public StackLayout PilhaDeFrames { get; private set; } = [];

  /// <summary>
  /// Nomes dos últimos usuários
  /// </summary>
  public Label LastUsersDiscussionDescription { get; private set; }


  public FrameLayoutsPage()
  {
    InitializeComponent();
    SetLayout();
    CreateFrames("Kelvyn", 0, 0);
    CreateFrames("Julio", 0, -8);
    CreateFrames("Alexandre", 0, -8);
    SetLabelUsuarios(10, "Voce, Adriana teste qualquer coisa");
    LastUsersDiscussion.Add(PilhaDeFrames, 0);

    Content = new Grid
    {
      BackgroundColor = Colors.RosyBrown,
      VerticalOptions = LayoutOptions.Center,
      HorizontalOptions = LayoutOptions.Fill,
      Children = { LastUsersDiscussion }
    };
  }

  private void SetLabelUsuarios(int xPos, string textLabel)
  {
    LastUsersDiscussionDescription = new Label()
    {
      Text = textLabel,
      Style = (Style)Application.Current.Resources["LabelGeralRegular"],
      TextColor = Colors.White,
      LineBreakMode = LineBreakMode.WordWrap,
      WidthRequest = 200,
      Margin = new Thickness(xPos, 0, 0, 0)
    };
    LastUsersDiscussion.Add(LastUsersDiscussionDescription, 1);
  }

  private void CreateFrames(string nameUser, int idxUser, int xPos)
  {
    if (string.IsNullOrEmpty(nameUser)) return;

    Color frameColor = GetFrameColor(nameUser);
    Frame frm = GetFrame(frameColor);

    var stackUser = new StackLayout()
    {
      HorizontalOptions = LayoutOptions.Center,
      VerticalOptions = LayoutOptions.Center,
      BackgroundColor = Colors.Transparent
    };
    stackUser.Children.Add(new Label()
    {
      Text = nameUser.Trim().Substring(0, 1).ToUpper(),
      BackgroundColor = Colors.Transparent,
      Style = (Style)Application.Current.Resources["LabelGeralBold"]
    });
    frm.Content = stackUser;
    frm.Margin = new Thickness(xPos, 0, 0, 0);
    PilhaDeFrames.Add(frm);
    //LastUsersDiscussion.Children.Add(frm, Microsoft.Maui.Controls.Compatibility.Constraint.RelativeToParent((parent) => { return parent.X + xPos; }));
  }

  /// <summary>
  /// GetColor
  /// </summary>
  /// <param name="idxUser"></param>
  /// <returns></returns>
  public static Color GetFrameColor(string userIdUnique)
  {
    Color color = Colors.Black;
    try
    {
      var md5 = System.Security.Cryptography.MD5.Create();
      var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(userIdUnique.Trim()));

      color = Color.FromRgb(hash[0], hash[1], hash[2]);
    }
    catch
    {
      return color;
    }
    return color;
  }

  private Frame GetFrame(Color color)
  {
    return new Frame()
    {
      Padding = new Thickness(0, 0, 0, 0),
      BorderColor = color,
      BackgroundColor = color,
      WidthRequest = 28,
      HeightRequest = 28,
      HasShadow = false,
      CornerRadius = 14
    };
  }

  private void SetLayout()
  {
    LastUsersDiscussion = new Grid()
    {
      Padding = new Thickness(0),
      HorizontalOptions = LayoutOptions.Start,
      VerticalOptions = LayoutOptions.Center,
      BackgroundColor = Colors.Transparent,
      Margin = new Thickness(0)
    };

    PilhaDeFrames.Orientation = StackOrientation.Horizontal;
  }

}
