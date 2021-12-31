using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using JEMJ_Natural_Age.Models;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace JEMJ_Natural_Age.Gui
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Frame_cita : Page
    {
        public static String url_cita = "https://localhost:44372/Api/Citas";

        public Frame_cita()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            var httpHandler = new HttpClientHandler();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(url_cita);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient(httpHandler);
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Especialista>>(content);
                lista_persona.ItemsSource = resultado;

            }

        }

    }

}

