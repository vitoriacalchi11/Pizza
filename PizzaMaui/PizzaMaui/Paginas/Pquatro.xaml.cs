namespace PizzaMaui.Paginas;

public partial class Pquatro : ContentPage
{
	public Pquatro()
	{
		InitializeComponent();
	}

    private void btnVoltarPquatro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cardapio());
    }
}