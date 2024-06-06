namespace PizzaMaui.Paginas;

public partial class Pcinco : ContentPage
{
	public Pcinco()
	{
		InitializeComponent();
	}

    private void btnVoltarPcinco_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cardapio());
    }
}