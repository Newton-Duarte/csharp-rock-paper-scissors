
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
        TextUtils.Success($"Your chose: Rock x {machineOption} - {result}");
        break;
      case 2:
        string machineOption2 = PlayUtils.GetRandomOption();
        string result2 = GetResult("Paper", machineOption2);
        TextUtils.Success($"Your chose: Paper x {machineOption2} - {result2}");
        break;
      case 3:
        string machineOption3 = PlayUtils.GetRandomOption();
        string result3 = GetResult("Scissors", machineOption3);
        TextUtils.Success($"Your chose: Scissors x {machineOption3} - {result3}");
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
}