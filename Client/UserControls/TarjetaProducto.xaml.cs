using Newtonsoft.Json.Linq;
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
using UV_Eats_Client.Logic;
using UV_Eats_Client.Models;

namespace UV_Eats_Client.Client.UserControls
{
    /// <summary>
    /// Lógica de interacción para TarjetaPlatilloFavorito.xaml
    /// </summary>
    public partial class TarjetaProducto : UserControl
    {
        int idproducto;
        public TarjetaProducto()
        {
            InitializeComponent();
            
        }
        public TarjetaProducto(Producto newproducto)
        {
            idproducto=newproducto.idProducto;
            InitializeComponent();
            nombreProducto.Content = newproducto.nombre;
            descripcionProducto.Content = newproducto.descripcion;
            precioProducto.Content = newproducto.precio;
            numdislikes.Content = newproducto.numDislike;
            numlikes.Content = newproducto.numLike;
            Uri fileUri = new Uri(newproducto.imagenProducto);
            imagenProductotar.Source = new BitmapImage(fileUri);

        }

        private void agregarCarrito(object sender, RoutedEventArgs e)
        {
            
            var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

            if (padre != null)
            {
                padre.agregarALCARRO(idproducto);

            }
        }

        private void ordenarYa(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
