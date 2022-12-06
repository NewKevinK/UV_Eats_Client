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
using UV_Eats_Client.Models;
using Newtonsoft.Json;
using UV_Eats_Client.Logic;

using System.Windows.Threading;
using Menu = UV_Eats_Client.Models.Menu;
using ControlzEx.Controls;
using UV_Eats_Client.Client.UserControls;

namespace UV_Eats_Client.Client
{
    /// <summary>
    /// Lógica de interacción para PantallaInicial.xaml
    /// </summary>
    public partial class PantallaInicial : Window
    {
        API API = new API();
        String token;
        String idUsuario;
        public PantallaInicial(Auth auth)
        {
            
            token = auth.token;
            idUsuario = auth.id;


            InitializeComponent();
            DataContext = new MenuViewModel(token);

            _carouselDABMenu.SelectionChanged += _carouselDABEE_SelectionChanged;
        }


        private void btnShowCarClick(object sender, RoutedEventArgs e)
        {
            //dynamic respuesta = API.GetToken("http://localhost:1999/api/Menu/", token);
            //List<Menu> menu = JsonConvert.DeserializeObject<List<Menu>>(respuesta.Content);

            TarjetaProductoCarrito tarjetaProduct1 = new TarjetaProductoCarrito();
            TarjetaProductoCarrito tarjetaProduct2 = new TarjetaProductoCarrito();
            TarjetaProductoCarrito tarjetaProduct3 = new TarjetaProductoCarrito();
            TarjetaProductoCarrito tarjetaProduct4 = new TarjetaProductoCarrito();

            List<TarjetaProductoCarrito> listp = new List<TarjetaProductoCarrito>();

            TarjetaProductoCarrito TarjetaProductoTemp;

            for (int i = 0; i < 3; i++)
                listp.Add(TarjetaProductoTemp = new TarjetaProductoCarrito());

            for (int i = 0; i < listp.Count; i++)
                warpanle_prueb.Children.Add(listp[i]);
            Producto producto = new Producto
            {
                nombre = "test",
                descripcion = "siuuu",
                precio = 20,
                unidades = 50

            };
            //string objectU = JsonConvert.SerializeObject(producto);
            //dynamic respu = API.PatchToken("http://localhost:1999/api/producto/", objectU, token );

            tabControManager.SelectedIndex = 4;
        }

        public string TokenMenu()
        {
            //dynamic respuestaMenu = API.GetToken("http://localhost:1999/api/Menu/", token);

            return token;
        }


        private void _carouselDABEE_SelectionChanged(FrameworkElement selectedElement)
        {
            var viewModel = DataContext as MenuViewModel;
            if (viewModel == null)
            {
                return;
            }

            viewModel.SelectedMenuDAB = selectedElement.DataContext as Menu;
        }

        private void _buttonLeftArrow_Click(object sender, RoutedEventArgs e)
        {
            _carouselDABMenu.RotateRight();
        }

        private void _buttonRightArrow_Click(object sender, RoutedEventArgs e)
        {
            _carouselDABMenu.RotateLeft();
        }

        private void btnShowProfileClick(object sender, RoutedEventArgs e)
        {
            //Mostrar perfil

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

            tabControManager.SelectedIndex = 5;
        }

        private void btnLogoutClick(object sender, RoutedEventArgs e)
        {
            //cerrar sesion
        }
    }
}
