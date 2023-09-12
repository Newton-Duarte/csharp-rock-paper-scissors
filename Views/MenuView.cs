

static class MenuView
{
  public static void Show()
  {
    Welcome();
    Menu();
  }

  private static void GetOption()
  {
    TextUtils.TextDivider();
    Console.Write("Option: ");
    try
    {
      int option = int.Parse(Console.ReadLine());
      HandleOption(option);
    }
    catch (Exception e)
    {
      TextUtils.Error($"{e.Message}");
      Menu();
    }
  }

  private static void HandleOption(int option)
  {
    switch (option)
    {
      case 1:
        PlayView.Play();
        break;
      case 2:
        TextUtils.Title("\tThank you");
        break;
      default:
        TextUtils.Error("Invalid Option");
        GetOption();
        break;
    }
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
  }

  private static void Welcome()
  {
    TextUtils.TextDivider();
    TextUtils.Title("Welcome to Rock, Paper, Scissors Game");
    TextUtils.TextDivider();
  }

  private static void Menu()
  {
    foreach(var option in MenuUtils.MenuOptions)
    {
      Console.WriteLine($"{option.Key} - {option.Value}");
    }

    GetOption();
  }
}