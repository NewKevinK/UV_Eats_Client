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
using UV_Eats_Client.Models;

namespace UV_Eats_Client.Client
{
    /// <summary>
    /// Lógica de interacción para RecuperarContrasenia.xaml
    /// </summary>
    public partial class RecuperarContrasenia : Window
    {
        public RecuperarContrasenia()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnEnviarCodigoRC(object sender, RoutedEventArgs e)
        {
            //Envio de codigo a travez de correo
        }

        private void BtActualizarContrasenia(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Contrasenia restaurada correctamente");
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            InicioSesion pantallaInicioSesion = new InicioSesion();
            pantallaInicioSesion.Show();
            this.Close();
        }
    }
}

