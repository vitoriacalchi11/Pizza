namespace PizzaMaui.Paginas;

public partial class Pseis : ContentPage
{
	public Pseis()
	{
		InitializeComponent();
	}

    private void btnVoltarPseis_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cardapio());
    }
}