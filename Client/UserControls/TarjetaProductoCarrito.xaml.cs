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
using UV_Eats_Client.Models;

namespace UV_Eats_Client.Client.UserControls
{
    /// <summary>
    /// Lógica de interacción para TarjetaProductoCarrito.xaml
    /// </summary>
    public partial class TarjetaProductoCarrito : UserControl
    {
        public TarjetaProductoCarrito(CarroCompraProductos carroProductosI)
        {
            InitializeComponent();
            labelnombreProducto.Content = carroProductosI.producto;
            cantidadProducto.Content = carroProductosI.cantidad;
            precioProducto.Content = carroProductosI.precio;

            Uri fileUri = new Uri(carroProductosI.imagenProducto);
            imagenProducto.Source = new BitmapImage(fileUri);
        }
        public TarjetaProductoCarrito()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
