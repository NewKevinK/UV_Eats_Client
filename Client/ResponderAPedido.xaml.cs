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
    /// Lógica de interacción para RecuperarContrasenia.xaml
    /// </summary>
    public partial class ResponderAPedido : Window
    {
        public ResponderAPedido()
        {

            InitializeComponent();

        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
 

        }

        private void btnNuevaContrasenia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEnviarCodigoRC(object sender, RoutedEventArgs e)
        {

        }

        private void BtActualizarContrasenia(object sender, RoutedEventArgs e)
        {

        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {

            List<TarjetaProductosPedidos> list2p = new List<TarjetaProductosPedidos>();

            TarjetaProductosPedidos TarjetaProductoTemp1 = new TarjetaProductosPedidos();
            // TarjetaProductoTemp1.btProductoMenu.Content = "Eliminar";

            for (int i = 0; i < 4; i++)
                list2p.Add(TarjetaProductoTemp1);

            for (int i = 0; i < list2p.Count; i++)
                warp_productos.Children.Add(list2p[i]);
        }
    }
}

