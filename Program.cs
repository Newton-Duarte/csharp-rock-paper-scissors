try
{
  MenuView.Show();
}
catch (Exception e)
{
  TextUtils.Error($"{e.GetType()}: {e.Message}");
}