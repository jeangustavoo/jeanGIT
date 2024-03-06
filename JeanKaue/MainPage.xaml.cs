namespace JeanKaue;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
	 private void ClicarParaComeçarOJogo(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new GamePage();
  }
  private void ClicarParaEntrarNoSobre(object sender, EventArgs args)
  {
    LinhaAberta.IsVisible = true;
  }
    private void QuandoClicarVoltar(object sender, EventArgs args)
  {
    LinhaAberta.IsVisible = false;
  }
}

