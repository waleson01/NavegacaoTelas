using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNavegacaoTelas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            ImgOK.Source = ImageSource.FromResource("AppNavegacaoTelas2.img.ok.jpg");
        }

        private void btn_clicar(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}