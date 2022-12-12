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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UV_Eats_Client.Client.VentanasFlotantes
{
    /// <summary>
    /// Lógica de interacción para OpcionesExtras.xaml
    /// </summary>
    public partial class OpcionesExtrasEmpleado : UserControl
    {
        public int elementoPrueba = 0;
        public OpcionesExtrasEmpleado()
        {
            InitializeComponent();
        }

        public void BotonPlatillosFavoritos(object sender, RoutedEventArgs e)
        {
            var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

            if(padre != null)
            {
                padre.tabControManager.SelectedIndex = 3;
                padre.gripOpciones.Children.Clear();
                padre.banOpcionExtra = 0;

            }
        }

        public void ProcederAlPedido(object sender, RoutedEventArgs e)
        {
            var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

            if (padre != null)
            {
                padre.tabControManager.SelectedIndex = 5;
                padre.gripOpciones.Children.Clear();
                padre.banOpcionExtra = 0;
            }
        }

        private void RegistrarMenu(object sender, RoutedEventArgs e)
        {

        }
        private void RegistrarCategoria(object sender, RoutedEventArgs e)
        {

        }

        private void RegistrarProdcuto(object sender, RoutedEventArgs e)
        {

        }

        private void RegistrarUsuario(object sender, RoutedEventArgs e)
        {

        }

        private void ConsultarProductos(object sender, RoutedEventArgs e)
        {

        }

        private void ConsultarCategorias(object sender, RoutedEventArgs e)
        {

        }

        private void ConsultarPedidosRealizados(object sender, RoutedEventArgs e)
        {

        }
    }
}
