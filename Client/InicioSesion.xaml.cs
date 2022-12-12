using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using UV_Eats_Client.Logic;
using UV_Eats_Client.Models;

namespace UV_Eats_Client.Client
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        API API = new API();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Windows_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario
            {
                email = EmailBox.Text,
                password = PasswordBox.Password
                
            };


            string objectU = JsonConvert.SerializeObject(usuario);
            string json = @"{ ""email"":""moncayok0@gmail.com"", " + "\n" +@"""password"":""kevin1""" + "\n" +@"}";
            try
            {
                dynamic respuesta = API.PostNoToken("https://uveatsapi-production.up.railway.app/api/auth", json);
                Auth auth = JsonConvert.DeserializeObject<Auth>(respuesta.Content);

                if (auth.message == "authenticated user")
               {
                    MessageBox.Show("CACA");
                    PantallaInicial pantallaInicial = new PantallaInicial(auth);
                    pantallaInicial.Show();
                    //Application.Current.Shutdown();
                    this.Hide();
                }
                //MessageBox.Show("El mensaje es: " + auth.message);
                //MssageBox.Show(respuesta.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRecuperar_Click(object sender, RoutedEventArgs e)
        {
            RecuperarContrasenia pantallaRecuperarContrasenia = new RecuperarContrasenia();
            pantallaRecuperarContrasenia.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

        
    }

   
