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
    public partial class VentanaProductos : Window
    {
        public VentanaProductos()
        {
            InitializeComponent();
            CategoriaProducto tarjetaProduct1 = new CategoriaProducto();
            CategoriaProducto tarjetaProduct2 = new CategoriaProducto();
            CategoriaProducto tarjetaProduct3 = new CategoriaProducto();
            CategoriaProducto tarjetaProduct4 = new CategoriaProducto();

            List<CategoriaProducto> listp = new List<CategoriaProducto>();
            List<TarjetaConsultaProductos> list = new List<TarjetaConsultaProductos>();
            CategoriaProducto TarjetaProductoTemp;
            TarjetaConsultaProductos TarjetaConsultaProductos1;

            for (int i = 0; i < 10; i++)
            {
                listp.Add(TarjetaProductoTemp = new CategoriaProducto());
                list.Add(TarjetaConsultaProductos1 = new TarjetaConsultaProductos());
            }
                

            for (int i = 0; i < listp.Count; i++)
            {
                warp_categorias_productos.Children.Add(listp[i]);
                wrapPanelProductos.Children.Add(list[i]);
            }
                





        }

        private void btnShowCarClick(object sender, RoutedEventArgs e)
        {
            Tabcontrol1.SelectedIndex=4;
        }
    }
}
