using JEMJ_Natural_Age.Gui;
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

namespace JEMJ_Natural_Age
{

    public sealed partial class MainPage : Page
    {

        Frame_persona frame_persona = new Frame_persona();
        Frame_paciente frame_paciente = new Frame_paciente();
        Frame_especialista frame_especialista = new Frame_especialista();
        Frame_tratamiento frame_tratamiento = new Frame_tratamiento();
        Frame_cita frame_cita = new Frame_cita();


        public MainPage()
        {

            this.InitializeComponent();
            
        }

        private void Click_persona(object sender, RoutedEventArgs e)
        {

            main_frame.Navigate(typeof(Frame_persona));
            
        }

        private void Click_paciente(object sender, RoutedEventArgs e)
        {

            main_frame.Navigate(typeof(Frame_paciente));

        }

        private void Click_especialista(object sender, RoutedEventArgs e)
        {

            main_frame.Navigate(typeof(Frame_especialista));

        }

        private void Click_tratamiento(object sender, RoutedEventArgs e)
        {

            main_frame.Navigate(typeof(Frame_tratamiento));

        }

        private void Click_cita(object sender, RoutedEventArgs e)
        {

            main_frame.Navigate(typeof(Frame_cita));

        }


        

    }
}
