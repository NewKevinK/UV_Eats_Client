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
using UV_Eats_Client.Client.VentanasFlotantes;

namespace UV_Eats_Client.Client.UserControls
{
    /// <summary>
    /// Lógica de interacción para TarjetaPlatilloFavorito.xaml
    /// </summary>
    public partial class TarjetaProductosRealizados : UserControl
    {
        CalificarProducto CalificarP = new CalificarProducto();
        public TarjetaProductosRealizados()
        {
            InitializeComponent();
            
        }

        private void CalificarProductoNuevo(object sender, RoutedEventArgs e)
        {
            var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

            if (padre != null)
            {
                padre.gridCalificar.Children.Add(CalificarP);
                padre.gridCalificar.Visibility = Visibility.Visible;
            }
        }
    }
}
