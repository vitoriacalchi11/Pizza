namespace PizzaMaui.Paginas;

public partial class Cardapio : ContentPage
{
	public Cardapio()
	{
		InitializeComponent();
	}

    private void btnPagUm_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PagUm());
    }

    private void btnPdois_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pdois());

    }

    private void btnPtres_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ptres());

    }

    private void btnPquatro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pquatro());

    }

    private void btnPcinco_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pcinco());

    }

    private void btnPseis_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pseis());

    }
}