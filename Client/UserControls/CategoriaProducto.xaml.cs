using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Security.Policy;
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
    /// Lógica de interacción para CategoriaProducto.xaml
    /// </summary>
    public partial class CategoriaProducto : UserControl
    {
        public CategoriaProducto(Categorias categoria)
        {
            InitializeComponent();
            nombreCategoria.Content = categoria.nombre;
            //OpenFileDialog openFileDialog = new OpenFileDialog();

            Uri fileUri = new Uri(categoria.imagenCategoria);
            imagenCategoria.Source = new BitmapImage(fileUri);
  
                /*var fullFilePath = categoria.imagenCategoria;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
                bitmap.EndInit();*/
             
            
        }
        public CategoriaProducto()
        {

        }

        private void cambiarCategoria(object sender, RoutedEventArgs e)
        {

        }
    }
}
