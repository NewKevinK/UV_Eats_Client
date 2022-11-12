using RestSharp;
using Newtonsoft.Json;
using Newtonsoft;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

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
                Movie m = JsonConvert.DeserializeObject<Movie>(respo.Content);
                string mess = m.message;
                dynamic dinames = m.message;
                //MessageBox.Show(mess);
                return dinames;

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
