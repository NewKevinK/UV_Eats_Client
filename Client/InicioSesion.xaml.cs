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

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBase_OnClickAce(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario
            {
                email = EmailBox.Text,
                password = PasswordBox.Password
                
            };



            
            string objectU = JsonConvert.SerializeObject(usuario);
            string json = @"{ ""email"":""moncayok0@gmail.com"", 
" + "\n" +
@"""password"":""kevin1""
" + "\n" +
@"}";
            try
            {
                dynamic respuesta = API.PostNoToken("http://localhost:1999/api/auth/", json);
                Auth auth = JsonConvert.DeserializeObject<Auth>(respuesta.Content);

                if (auth.message == "authenticated user")
                {
                    PantallaInicial pantallaInicial = new PantallaInicial(auth);
                    pantallaInicial.Show();
                    //Application.Current.Shutdown();
                    this.Hide();
                }
                //MessageBox.Show("El mensaje es: " + auth.message);
                //MessageBox.Show(respuesta.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {

        }
    }

        
    }

   
