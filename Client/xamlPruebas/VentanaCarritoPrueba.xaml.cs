using MaterialDesignThemes.Wpf;
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

namespace UV_Eats_Client.Client
{
    /// <summary>
    /// Lógica de interacción para VentanaCarritoPrueba.xaml
    /// </summary>
    public partial class VentanaCarritoPrueba : Window
    {
        public VentanaCarritoPrueba()
        {
            InitializeComponent();
            TarjetaProductoCarrito tarjetaProduct1 = new TarjetaProductoCarrito();
            TarjetaProductoCarrito tarjetaProduct2 = new TarjetaProductoCarrito();
            TarjetaProductoCarrito tarjetaProduct3 = new TarjetaProductoCarrito();
            TarjetaProductoCarrito tarjetaProduct4 = new TarjetaProductoCarrito();

            List<TarjetaProductoCarrito> listp = new List<TarjetaProductoCarrito>();

            TarjetaProductoCarrito TarjetaProductoTemp;

            for(int i=0;i<3;i++)
                listp.Add(TarjetaProductoTemp = new TarjetaProductoCarrito());
 
            for(int i= 0; i < listp.Count; i++)
                warpanle_prueb.Children.Add(listp[i]);





        }

        private void btnShowCarClick(object sender, RoutedEventArgs e)
        {
            Tabcontrol1.SelectedIndex=4;
        }
    }
}
