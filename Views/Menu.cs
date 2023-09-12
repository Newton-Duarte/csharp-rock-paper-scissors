

static class Menu
{
  public static void Show()
  {
    Welcome();
    MainMenu();
    GetOption();
  }

  private static void GetOption()
  {
    TextUtils.TextDivider();
    Console.Write("Option: ");
    int option = int.Parse(Console.ReadLine());
    HandleOption(option);
  }

  private static void HandleOption(int option)
  {
    switch (option)
    {
      case 1:
        TextUtils.Title("\tLet's play");
        break;
      case 2:
        TextUtils.Title("\tThank you");
        break;
      default:
        TextUtils.Error("Invalid Option");
        GetOption();
        break;
    }
  }

  private static void Welcome()
  {
    TextUtils.TextDivider();
    TextUtils.Title("Welcome to Rock, Paper, Scissors Game");
    TextUtils.TextDivider();
  }

  private static void MainMenu()
  {
    foreach(var option in MenuUtils.MenuOptions)
    {
      Console.WriteLine($"{option.Key}. {option.Value}");
    }
  }
}