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
using UV_Eats_Client.Client.VentanasFlotantes;
using MaterialDesignThemes.Wpf;

namespace UV_Eats_Client.Client
{
    /// <summary>
    /// Lógica de interacción para PantallaInicial.xaml
    /// </summary>
    public partial class PantallaInicial : Window
    {   

        public int banOpcionExtra = 0;
        API API = new API();
        String token;
        String idUsuario;
        int opciosc = 0;
        OpcionesExtras extras = new OpcionesExtras();

        public PantallaInicial(Auth auth)
        {
            MessageBox.Show("CACA");
            token = auth.token;
            idUsuario = auth.id;
            MessageBox.Show("CACA2");

            InitializeComponent();
            DataContext = new MenuViewModel(token);

            _carouselDABMenu.SelectionChanged += _carouselDABEE_SelectionChanged;

            cargarMenu();
            cargarProductos();
            cargarPedidos();
            cargarFavoritos();
            cargarPedidosAsolicitar();
            cargarCarrito();
            cargarObjetos();
        }


        private void cargarObjetos()
        {
            
        }

        private void cargarCarrito()
        {
            
        }

        private void cargarPedidosAsolicitar()
        {
            List<TarjetaProductosPedidos> listp = new List<TarjetaProductosPedidos>();
            TarjetaProductosPedidos TarjetaConsultaProductos1;

            for (int i = 0; i < 10; i++)
                listp.Add(TarjetaConsultaProductos1 = new TarjetaProductosPedidos());

            for (int i = 0; i < listp.Count; i++)
                Warp_panel_Pedidos.Children.Add(listp[i]);
        }

        private void cargarFavoritos()
        {
            List<TarjetaPlatilloFavorito> listp = new List<TarjetaPlatilloFavorito>();
            TarjetaPlatilloFavorito TarjetaConsultaProductos1;

            for (int i = 0; i < 10; i++)
                listp.Add(TarjetaConsultaProductos1 = new TarjetaPlatilloFavorito());

            for (int i = 0; i < listp.Count; i++)
                warpanle_platillosFav.Children.Add(listp[i]);
        }

        private void cargarPedidos()
        {
            List<TarjetaProductosRealizados> listp = new List<TarjetaProductosRealizados>();
            TarjetaProductosRealizados TarjetaConsultaProductos1;

            for (int i = 0; i < 10; i++)
                listp.Add(TarjetaConsultaProductos1 = new TarjetaProductosRealizados());

            for (int i = 0; i < listp.Count; i++)
                warpPanelPedidosRealizados.Children.Add(listp[i]);
            
        }

        private void cargarProductos()
        {
            List<CategoriaProducto> listp = new List<CategoriaProducto>();
            List<TarjetaProducto> list = new List<TarjetaProducto>();
            CategoriaProducto TarjetaProductoTemp;
            TarjetaProducto TarjetaConsultaProductos1;

            for (int i = 0; i < 10; i++)
            {
                listp.Add(TarjetaProductoTemp = new CategoriaProducto());
                list.Add(TarjetaConsultaProductos1 = new TarjetaProducto());
            }


            for (int i = 0; i < listp.Count; i++)
            {
                warp_categorias_productos.Children.Add(listp[i]);
                wrapPanelProductos.Children.Add(list[i]);
            }
        }

        private void cargarMenu()
        {
            
        }

        private void btnShowCarClick(object sender, RoutedEventArgs e)
        {
            //dynamic respuesta = API.GetToken("http://localhost:1999/api/Menu/", token);
            //List<Menu> menu = JsonConvert.DeserializeObject<List<Menu>>(respuesta.Content);

            List<TarjetaProductoCarrito> listp = new List<TarjetaProductoCarrito>();

            TarjetaProductoCarrito TarjetaProductoTemp;

            for (int i = 0; i < 3; i++)
                listp.Add(TarjetaProductoTemp = new TarjetaProductoCarrito());

            for (int i = 0; i < listp.Count; i++)
                warp_panel_Carritos.Children.Add(listp[i]);
            Producto producto = new Producto
            {
                nombre = "test",
                descripcion = "siuuu",
                precio = 20,
                unidades = 50

            };
            //string objectU = JsonConvert.SerializeObject(producto);
            //dynamic respu = API.PatchToken("http://localhost:1999/api/producto/", objectU, token );

            tabControManager.SelectedIndex = 6;
        }

        public string TokenMenu()
        {
            //dynamic respuestaMenu = API.GetToken("https://uveatsapi-production.up.railway.app/api/Menu/", token);

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
            if (banOpcionExtra==0)
            {
                gripOpciones.Children.Add(extras);
                gripOpciones.Visibility=Visibility.Visible;
                banOpcionExtra = 1;

            }else if (banOpcionExtra==1)
            {
                gripOpciones.Visibility = Visibility.Collapsed;
                gripOpciones.Children.Clear();
                banOpcionExtra = 0;
            }

        }


        private void btnLogoutClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
