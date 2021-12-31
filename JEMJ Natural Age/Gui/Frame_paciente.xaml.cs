using JEMJ_Natural_Age.Models;
using Newtonsoft.Json;
using System;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace JEMJ_Natural_Age.Gui
{

    public sealed partial class Frame_paciente : Page
    {

        public static String url_paciente = "https://localhost:44372/Api/Pacientes";

        public Frame_paciente()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            var httpHandler = new HttpClientHandler();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(url_paciente);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient(httpHandler);
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Paciente>>(content);
                lista_persona.ItemsSource = resultado;

            }

        }

    }
}
