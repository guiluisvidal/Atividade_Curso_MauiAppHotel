using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class CadastroCliente : ContentPage
{
    public CadastroCliente()
    {
        InitializeComponent();
    }

    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new Cliente
            {
                Nome = entryNome.Text,
                Idade = int.Parse(entryIdade.Text),
                Telefone = entryTelefone.Text,
                Rg = entryRg.Text
            };

            await Navigation.PushAsync(new ContratacaoHospedagem(cliente));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}
