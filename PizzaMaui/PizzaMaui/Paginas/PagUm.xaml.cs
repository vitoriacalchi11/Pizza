namespace PizzaMaui.Paginas;

public partial class PagUm : ContentPage
{
	public PagUm()
	{
		InitializeComponent();
	}

    private void btnVoltarPagUm_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cardapio());
    }

}