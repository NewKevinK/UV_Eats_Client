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
using UV_Eats_Client.Client.UserControls;

namespace UV_Eats_Client.Client.xamlPruebas
{
    /// <summary>
    /// Lógica de interacción para PlatillosFavoritos.xaml
    /// </summary>
    public partial class PlatillosFavoritos : Window
    {
        public PlatillosFavoritos()
        {
            InitializeComponent();
            TarjetaPlatilloFavorito tarjetaProduct1 = new TarjetaPlatilloFavorito();
            TarjetaPlatilloFavorito tarjetaProduct2 = new TarjetaPlatilloFavorito();
            TarjetaPlatilloFavorito tarjetaProduct3 = new TarjetaPlatilloFavorito();
            TarjetaPlatilloFavorito tarjetaProduct4 = new TarjetaPlatilloFavorito();

            List<TarjetaPlatilloFavorito> listp = new List<TarjetaPlatilloFavorito>();

            TarjetaPlatilloFavorito TarjetaProductoTemp;

            for (int i = 0; i < 3; i++)
                listp.Add(TarjetaProductoTemp = new TarjetaPlatilloFavorito());

            for (int i = 0; i < listp.Count; i++)
                warpanle_platillosFav.Children.Add(listp[i]);
        }

        private void btnShowProfileClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
