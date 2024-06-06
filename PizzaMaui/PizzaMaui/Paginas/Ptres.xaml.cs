namespace PizzaMaui.Paginas;

public partial class Ptres : ContentPage
{
	public Ptres()
	{
		InitializeComponent();
	}

    private void btnVoltarPtres_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cardapio());
    }
}