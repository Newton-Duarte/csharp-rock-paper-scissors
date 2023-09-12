static class PlayUtils
{
  public static Dictionary<int, string> PlayOptions = new()
  {
    { 1, "Rock" },
    { 2, "Paper" },
    { 3, "Scissors" }
  };

  public static string GetRandomOption()
  {
    string[] options = new string[3];

    for(int i = 0; i < PlayOptions.Count; i++)
    {
      options[i] = PlayOptions.ElementAt(i).Value;
    }

    var rand = new Random();
    return options[rand.Next(PlayOptions.Count)];
  }
}