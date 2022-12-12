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
    public partial class TarjetaProductosPedidos : UserControl
    {
        public TarjetaProductosPedidos(CarroCompraProductos productoNew)
        {
            InitializeComponent();
            nombreProducto.Content = productoNew.producto;
            descripcionProducto.Content = productoNew.cantidad;
            precioProducto.Content = productoNew.precio;
           
            Uri fileUri = new Uri(productoNew.imagenProducto);
            imagenProducto.Source = new BitmapImage(fileUri);

        }
        public TarjetaProductosPedidos()
        {
            InitializeComponent();
        }
        public TarjetaProductosPedidos(Orden productonew)
        {
            InitializeComponent();
            nombreProducto.Content = productonew.fecha;
            descripcionProducto.Content = productonew.total;
            precioProducto.Content = productonew.idUsuario;
            estado.Content=productonew.estado;

        }
    }
}
