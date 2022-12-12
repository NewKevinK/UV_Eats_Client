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
using System.Security.Policy;

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
        //int opciosc = 0;
        string tipoUsuario="CLIENTE";

        OpcionesExtras extras = new OpcionesExtras();
        
        OpcionesExtrasEmpleado extrasEmpleado = new OpcionesExtrasEmpleado();

        List<ProductoImagen> urlImagenProducto = new List<ProductoImagen>();
        List<Producto> JsonProducto = new List<Producto>();
        public PantallaInicial(Auth auth)//Usuario normal
        {
            token = auth.token;
            idUsuario = auth.id;
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
        public PantallaInicial(Auth auth,string tipoUsuario)//Usuario Empleado
        {
            token = auth.token;
            idUsuario = auth.id;
            this.tipoUsuario = tipoUsuario;

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

            dynamic respuestaCarro = API.GetToken("https://uveatsapi-production.up.railway.app/api/carro", token);

            dynamic idCarroProductoRespuesta = API.GetToken("https://uveatsapi-production.up.railway.app/api/carro/carroProducto/"+idUsuario, token);

            List<CarroCompraProductos> productosCarro = JsonConvert.DeserializeObject<List<CarroCompraProductos>>(idCarroProductoRespuesta.Content);


            // dynamic imagenRespuestaProductos = API.GetNoToken("https://uveatsapi-production.up.railway.app/api/archivo/getProducto");
            int preciosub=0;

            for(int i = 0; i < productosCarro.Count; i++)
            {
                
                for (int z = 0; z < urlImagenProducto.Count; z++)
                {
                    if(productosCarro[i].idProducto == urlImagenProducto[z].IdProducto)
                    {
                        productosCarro[i].imagenProducto = urlImagenProducto[z].url;
                    }
                }
                preciosub = preciosub + productosCarro[i].precio;

            }
            List<TarjetaProductoCarrito> listp = new List<TarjetaProductoCarrito>();

            TarjetaProductoCarrito TarjetaProductoTemp;

            for (int i = 0; i < productosCarro.Count; i++)
                listp.Add(TarjetaProductoTemp = new TarjetaProductoCarrito(productosCarro[i]));

            for (int i = 0; i < listp.Count; i++)
                warp_panel_Carritos.Children.Add(listp[i]);

            labelsubtotal.Content = preciosub;
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
            MessageBox.Show("Error 1");
            dynamic respuestaProductosfav = API.GetToken("https://uveatsapi-production.up.railway.app/api/producto/getFav/"+idUsuario, token);

            List<ProductoID> productosFavoritos = JsonConvert.DeserializeObject<List<ProductoID>>(respuestaProductosfav.Content);

            MessageBox.Show(productosFavoritos[0].idProducto+"Error 1" + productosFavoritos[1].idProducto);

            List<Producto> productosFavoritosSeleccionados = new List<Producto>();

            MessageBox.Show("Error 11");
            for (int i = 0; i < productosFavoritos.Count; i++)
            {
               // MessageBox.Show("Error 122"+productosFavoritos.Count);
                for (int z = 0; z < JsonProducto.Count; z++)
                {
                   // MessageBox.Show("Error 133"+JsonProducto.Count);
                    if (productosFavoritos[i].idProducto == JsonProducto[z].idProducto)
                    {
                       // MessageBox.Show("Error 144"+ JsonProducto.Count);
                        productosFavoritosSeleccionados.Add(JsonProducto[z]);
                       // MessageBox.Show("Error 155");
                    }
                }
            }
            MessageBox.Show("Error 144523");
            List<TarjetaPlatilloFavorito> listp = new List<TarjetaPlatilloFavorito>();
            TarjetaPlatilloFavorito TarjetaConsultaProductos1;

            for (int i = 0; i < productosFavoritosSeleccionados.Count; i++)
                listp.Add(TarjetaConsultaProductos1 = new TarjetaPlatilloFavorito(productosFavoritosSeleccionados[i]));

            for (int i = 0; i < listp.Count; i++)
                warpanle_platillosFav.Children.Add(listp[i]);
        }

        private void cargarPedidos()
        {

            dynamic respuestaProductos = API.GetToken("https://uveatsapi-production.up.railway.app/api/orden/ordenProducto", token);
            dynamic imagenRespuestaProductos = API.GetNoToken("https://uveatsapi-production.up.railway.app/api/archivo/getProducto");

            List<TarjetaProductosRealizados> listp = new List<TarjetaProductosRealizados>();
            TarjetaProductosRealizados TarjetaConsultaProductos1;

            for (int i = 0; i < 10; i++)
                listp.Add(TarjetaConsultaProductos1 = new TarjetaProductosRealizados());

            for (int i = 0; i < listp.Count; i++)
                warpPanelPedidosRealizados.Children.Add(listp[i]);
            
        }

        private void cargarProductos()
        {
            //Categoria
            dynamic respuestaCategoria= API.GetToken("https://uveatsapi-production.up.railway.app/api/categoria", token);
            dynamic imagenRespuestaCategoria = API.GetNoToken("https://uveatsapi-production.up.railway.app/api/archivo/getCategoria");

            //Producto
            dynamic respuestaProductos = API.GetToken("https://uveatsapi-production.up.railway.app/api/producto", token);
            dynamic imagenRespuestaProductos = API.GetNoToken("https://uveatsapi-production.up.railway.app/api/archivo/getProducto");


            List<CategoriaImagen> urlImagenCategoria = JsonConvert.DeserializeObject<List<CategoriaImagen>>(imagenRespuestaCategoria.Content);
            List<Categorias> JsonCategoria = JsonConvert.DeserializeObject<List<Categorias>>(respuestaCategoria.Content);


            urlImagenProducto = JsonConvert.DeserializeObject<List<ProductoImagen>>(imagenRespuestaProductos.Content);
            JsonProducto = JsonConvert.DeserializeObject<List<Producto>>(respuestaProductos.Content);


            for (int i = 0; i < JsonCategoria.Count; i++)
            {
                JsonCategoria[i].imagenCategoria = urlImagenCategoria[i].url;
            }
            for (int i = 0; i < JsonProducto.Count; i++)
            {
                JsonProducto[i].imagenProducto = urlImagenProducto[i].url;
            }
            //listastemp
            List<CategoriaProducto> listCate = new List<CategoriaProducto>();
            List<TarjetaProducto> listPro = new List<TarjetaProducto>();

            CategoriaProducto tarjetaCategorias;
            TarjetaProducto tarjetaProducto;

            for (int i = 0; i < JsonCategoria.Count; i++)
            {
                listCate.Add(tarjetaCategorias = new CategoriaProducto(JsonCategoria[i]));
               
            }
            for (int i = 0; i < JsonProducto.Count; i++)
            {
                listPro.Add(tarjetaProducto = new TarjetaProducto(JsonProducto[i]));
           
            }

            for (int i = 0; i < listCate.Count; i++)
            {
                warp_categorias_productos.Children.Add(listCate[i]);
            }
            for (int i = 0; i < listPro.Count; i++)
            {
                wrapPanelProductos.Children.Add(listPro[i]);
            }
        }

        private void cargarMenu()
        {
            
        }

        private void btnShowCarClick(object sender, RoutedEventArgs e)
        {
            //dynamic respuesta = API.GetToken("http://localhost:1999/api/Menu/", token);
            //List<Menu> menu = JsonConvert.DeserializeObject<List<Menu>>(respuesta.Content);
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
            if (tipoUsuario == "CLIENTE")
            {
                if (banOpcionExtra == 0)
                {
                    gripOpciones.Children.Add(extras);
                    gripOpciones.Visibility = Visibility.Visible;
                    banOpcionExtra = 1;

                }
                else if (banOpcionExtra == 1)
                {
                    gripOpciones.Visibility = Visibility.Collapsed;
                    gripOpciones.Children.Clear();
                    banOpcionExtra = 0;
                }
            }
            else if(tipoUsuario == "EMPLEADO"){
                if (banOpcionExtra == 0)
                {
                    gripOpciones.Children.Add(extrasEmpleado);
                    gripOpciones.Visibility = Visibility.Visible;
                    banOpcionExtra = 1;

                }
                else if (banOpcionExtra == 1)
                {
                    gripOpciones.Visibility = Visibility.Collapsed;
                    gripOpciones.Children.Clear();
                    banOpcionExtra = 0;
                }

            }


        }


        private void btnLogoutClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
