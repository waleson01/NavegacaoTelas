using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppNavegacaoTelas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            imgUsuario.Source = ImageSource.FromResource("AppNavegacaoTelas.img.usuario.jpg");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if ((etysenha.Text.Equals("1234a")) && (etyusuario.Text.Equals("Waleson")))
                {
                    var dados = new Dados
                    {
                        Senha = etysenha.Text,
                        Usuario = etyusuario.Text
                    };

                    etysenha = "";
                    etyusuario = "";

                    var parametros = new Pagina2();
                    parametros.BindingContext = dados;
                    await Navigation.PushAsync(parametros);

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", "Usuario ou senhas incorreto", "OK!");
                etysenha = " ";
                etyusuario = " ";
            }
        }
    }
}
