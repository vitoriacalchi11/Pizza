namespace PizzaMaui.Paginas;

public partial class Pdois : ContentPage
{
	public Pdois()
	{
		InitializeComponent();
	}

    private void btnVoltarPDois_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cardapio());
    }
}