
static class PlayView
{
  public static void Play()
  {
    TextUtils.Title("\tLet's Play");

    foreach(var option in PlayUtils.PlayOptions)
    {
      Console.WriteLine($"{option.Key} - {option.Value}");
    }
    GetOption();
  }

  private static void GetOption()
  {
    TextUtils.TextDivider();
    Console.Write("Option: ");
    try
    {
      int option = int.Parse(Console.ReadLine());
      HandleOption(option);
      MenuView.Show();
    }
    catch (Exception e)
    {
      TextUtils.Error($"{e.Message}");
      Play();
    }
  }

  private static void HandleOption(int option)
  {
    switch (option)
    {
      case 1:
        string machineOption = PlayUtils.GetRandomOption();
        string result = GetResult("Rock", machineOption);
        ResultMessage("Rock", machineOption, result);
        break;
      case 2:
        string machineOption2 = PlayUtils.GetRandomOption();
        string result2 = GetResult("Paper", machineOption2);
        ResultMessage("Paper", machineOption2, result2);
        break;
      case 3:
        string machineOption3 = PlayUtils.GetRandomOption();
        string result3 = GetResult("Scissors", machineOption3);
        ResultMessage("Scissors", machineOption3, result3);
        break;
      default:
        TextUtils.Error("Invalid option");
        GetOption();
        break;
    }
  }

  private static string GetResult(string userOption, string machineOption)
  {
    if (userOption == "Rock" && machineOption == "Rock")
    {
      return "it's a draw";
    }
    else if (userOption == "Rock" && machineOption == "Paper")
    {
      return "you lose";
    }
    else if (userOption == "Rock" && machineOption == "Scissors")
    {
      return "you win";
    }
    else if (userOption == "Paper" && machineOption == "Paper")
    {
      return "it's a draw";
    }
    else if (userOption == "Paper" && machineOption == "Rock")
    {
      return "you win";
    }
    else if (userOption == "Paper" && machineOption == "Scissors")
    {
      return "you lose";
    }
    else if (userOption == "Scissors" && machineOption == "Scissors")
    {
      return "it's a draw";
    }
    else if (userOption == "Scissors" && machineOption == "Paper")
    {
      return "you win";
    }
    else if (userOption == "Scissors" && machineOption == "Rock")
    {
      return "you lose";
    }
    else {
      return "";
    }
  }

  private static void ResultMessage(string userOption, string machineOption, string result)
  {
    if (result.Contains("win"))
    {
      TextUtils.Success($"Your chose: {userOption} x {machineOption} - {result}");
    } else if (result.Contains("lose"))
    {
      TextUtils.Error($"Your chose: {userOption} x {machineOption} - {result}");
    }
    else {
      TextUtils.Warning($"Your chose: {userOption} x {machineOption} - {result}");
    }
  }
}