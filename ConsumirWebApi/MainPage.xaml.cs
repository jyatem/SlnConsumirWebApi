using ConsumirWebApi.Services;
using System.Threading.Tasks;

namespace ConsumirWebApi
{
    public partial class MainPage : ContentPage
    {
        private readonly IServicioWebApi _servicioWebApi;

        int count = 0;

        public MainPage(IServicioWebApi servicioWebApi)
        {
            InitializeComponent();
            _servicioWebApi = servicioWebApi;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _servicioWebApi.Obtener();
            lstViewPersonajes.ItemsSource = data;

            loading.IsVisible = false;
        }
    }

}
