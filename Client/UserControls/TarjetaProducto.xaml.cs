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
    public partial class TarjetaProducto : UserControl
    {
        public TarjetaProducto()
        {
            InitializeComponent();
            
        }
        public TarjetaProducto(Producto newproducto)
        {
            InitializeComponent();
            nombreProducto.Content = newproducto.nombre;
            descripcionProducto.Content = newproducto.descripcion;
            precioProducto.Content = newproducto.precio;
            numdislikes.Content = newproducto.numDislike;
            numlikes.Content = newproducto.numLike;
            Uri fileUri = new Uri(newproducto.imagenProducto);
            imagenProductotar.Source = new BitmapImage(fileUri);

        }
    }
}
