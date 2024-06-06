using PizzaMaui.Model;

namespace PizzaMaui.Paginas;

public partial class Cadastro : ContentPage
{
    Usuario _usuario;
    public Cadastro()
    {
        _usuario = new Usuario();

        this.BindingContext = _usuario;

        InitializeComponent();
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Senha) && string.IsNullOrEmpty(_usuario.Nome))
        {
            await DisplayAlert("Erro", "Preencha todas as informa��es", "Fechar");
            return;
        }
        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usu�rio cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}