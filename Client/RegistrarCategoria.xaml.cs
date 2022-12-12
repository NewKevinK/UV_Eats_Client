using Microsoft.Win32;
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
using UV_Eats_Client.Logic;
using UV_Eats_Client.Models;
using UV_Eats_Client;
using UV_Eats_Client.Client.UserControls;
using UV_Eats_Client.Client.VentanasFlotantes;
using Newtonsoft.Json;


namespace UV_Eats_Client.Client
{
    /// <summary>
    /// Lógica de interacción para RecuperarContrasenia.xaml
    /// </summary>
    public partial class RegistrarCategoria : Window
    {

        API API = new API();
        Auth auth2;
        String token;
        String idUsuario;
        public RegistrarCategoria(Auth auth)
        {
            token = auth.token;
            idUsuario = auth.id;
            auth2 = auth;
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
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

        private void subirImagen(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new OpenFileDialog();

            bool? response = openFileDialog.ShowDialog();

            if (response == true)
            {
                string filepath = openFileDialog.FileName;
                MessageBox.Show(filepath);

            }
        }

        private void btnRegistrarCategoria(object sender, RoutedEventArgs e)
        {
            

        }

        private void btnRegistrarCategoria2(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegistrarCategoria3_Click(object sender, RoutedEventArgs e)
        {
            Categorias categoria = new Categorias
            {
                nombre = TxNombrecategoria.Text,
                descripcion = "Disponible"

            };
            string objectC = JsonConvert.SerializeObject(categoria);
            try
            {
                //dynamic respuesta = API.PostNoToken("https://uveatsapi-production.up.railway.app/api/auth", objectU);
                dynamic respuesta = API.PostToken("https://uveatsapi-production.up.railway.app/api/categoria/", objectC, token);

                //Auth auth = JsonConvert.DeserializeObject<Auth>(respuesta.Content);
                Respuesta res = JsonConvert.DeserializeObject<Respuesta>(respuesta.Content);
                if (res.message == "categoria added")
                {
                    OpcionesExtrasEmpleado op = new OpcionesExtrasEmpleado(auth2);
                    //
                    this.Hide();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

