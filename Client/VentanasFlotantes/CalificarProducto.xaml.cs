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

namespace UV_Eats_Client.Client.VentanasFlotantes
{
    /// <summary>
    /// Lógica de interacción para CalificarProducto.xaml
    /// </summary>
    public partial class CalificarProducto : UserControl
    {
        int calificacion=0;
        public CalificarProducto()
        {
            InitializeComponent();
            bulike.Background = Brushes.Gray;
            butdislike.Background = Brushes.Gray;
        }

        private void dislike(object sender, RoutedEventArgs e)
        {
            calificacion = 1;//dislike
            bulike.Background = Brushes.Gray;
            butdislike.Background = Brushes.Green;
        }

        private void like(object sender, RoutedEventArgs e)
        {
            calificacion = 2;//like
            butdislike.Background = Brushes.Gray;
            bulike.Background = Brushes.Green;
        }

        private void btcancelar(object sender, RoutedEventArgs e)
        {
            var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

            if (padre != null)
            {
                padre.gridCalificar.Children.Clear();
                padre.gridCalificar.Visibility = Visibility.Collapsed;
            }
        }

        private void btconfirmar(object sender, RoutedEventArgs e)
        {
            if(calificacion == 0)
            {
                MessageBox.Show("Seleccione una calificacion por favor");
            }else if(calificacion == 1)
            {
                MessageBox.Show("Se ha calificado con exito");
                var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

                if (padre != null)
                {
                    padre.gridCalificar.Children.Clear();
                    padre.gridCalificar.Visibility = Visibility.Collapsed;
                }
            }
            else if(calificacion == 2)
            {
                MessageBox.Show("Se ha calificado con exito");
                var padre = Window.GetWindow(this) as UV_Eats_Client.Client.PantallaInicial;

                if (padre != null)
                {
                    padre.gridCalificar.Children.Clear();
                    padre.gridCalificar.Visibility = Visibility.Collapsed;
                }
            }

        }

    }
}
