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
    /// Lógica de interacción para TarjetaPlatilloFavorito.xaml
    /// </summary>
    public partial class TarjetaPlatilloFavorito : UserControl
    {
        public TarjetaPlatilloFavorito()
        {
            InitializeComponent();
        }
        public TarjetaPlatilloFavorito(Producto productoFav)
        {
            InitializeComponent();
            nombreProducto.Content = productoFav.nombre;
            descripcionProducto.Content = productoFav.descripcion;
            precioProducto.Content = productoFav.precio;
            Uri fileUri = new Uri(productoFav.imagenProducto);
            imagenProducto.Source = new BitmapImage(fileUri);
        }

        private void agregarCarrito(object sender, RoutedEventArgs e)
        {

        }

        private void ordenarYa(object sender, RoutedEventArgs e)
        {

        }

        private void elimiarProducto(object sender, RoutedEventArgs e)
        {

        }
    }
}
