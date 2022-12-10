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
    public partial class ConsultarPedidos : Window
    {
        public ConsultarPedidos()
        {

            InitializeComponent();
            List<TarjetaConsultaPedidos> listp = new List<TarjetaConsultaPedidos>();

            TarjetaConsultaPedidos TarjetaProductoTemp;

            for (int i = 0; i < 100; i++)
                listp.Add(TarjetaProductoTemp = new TarjetaConsultaPedidos());

            for (int i = 0; i < listp.Count; i++)
                warpanle_categorias.Children.Add(listp[i]);
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

        }
    }
}

