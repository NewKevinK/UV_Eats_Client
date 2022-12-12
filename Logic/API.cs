using RestSharp;
using Newtonsoft.Json;
using Newtonsoft;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using UV_Eats_Client.Models;
using RestSharp.Authenticators;

namespace UV_Eats_Client.Logic
{
    public class API
    {
        public async Task<dynamic> PostAsync(string url, string body, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                if (autorizacion != null)
                {

                }

                RestResponse respo  = await client.PostAsync(request);
                //dynamic dat = JsonConvert.DeserializeObject<MensajeLogin>(respo.Content);


                //RestResponse response =  client.Execute(request);
                //dynamic datos = JsonConvert.DeserializeObject(response.Content);


                //IRestResponse response = client.Execute(request);
                Auth auth = JsonConvert.DeserializeObject<Auth>(respo.Content);
                Movie m = JsonConvert.DeserializeObject<Movie>(respo.Content);
                string mess = m.message;
                dynamic dinames = m.message;
                //MessageBox.Show(mess);
                return auth;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public dynamic PostNoToken(string url, string body, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                if (autorizacion != null)
                {

                }

                RestResponse respo =  client.Post(request);
                //Auth auth = JsonConvert.DeserializeObject<Auth>(respo.Content);
                
                return respo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }

        public dynamic PostToken(string url, string body, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                //var authenticator = new JwtAuthenticator(autorizacion);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                if (autorizacion != null)
                {

                }

                RestResponse respo = client.Post(request);
                
                return respo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public dynamic GetToken(string url, string token)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Authorization", token);
                RestResponse response = client.Execute(request);

                return response;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public dynamic GetNoToken(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                RestResponse response = client.Execute(request);

                return response;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public dynamic DeleteToken(string url, string token)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Authorization", token);
                RestResponse response = client.Execute(request);

                return response;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public dynamic PatchToken(string url, string body, string token = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Authorization", token);
                //request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                

                RestResponse respo = client.Post(request);

                return respo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }



        private class Movie
        {
            public string message { get; set; }
            public string token { get; set; }
        }
    }

    internal class MensajeLogin
    {
        public string message { get; set; }
        public string token { get; set; }
    };
}
