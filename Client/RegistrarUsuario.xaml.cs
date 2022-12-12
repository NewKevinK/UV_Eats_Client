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
    /// Lógica de interacción para RegistrarEstudiante.xaml
    /// </summary>
    public partial class RegistrarUsuario: Window
    {
        public RegistrarUsuario()
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

        private void btnNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            string usuario="USER_PRUEBA";
            MessageBox.Show("Usuario Registrado con exito: "+usuario+"\n Ingresado a la base de datos");
            //PantallaInicial pantallaInicial = new PantallaInicial();
            //pantallaInicial.Show();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            //PantallaInicial pantallaInicial = new PantallaInicial();
            //pantallaInicial.Show();
        }
    }
}
