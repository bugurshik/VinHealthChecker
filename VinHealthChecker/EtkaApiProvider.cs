using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using VinHealthChecker.Models;

namespace VinHealthChecker
{
    public class EtkaApiProvider
    {
        private Config Config { get; }
        private HttpClient HttpClient { get; } = new();
        public EtkaApiProvider(Config config)
        {
            Config = config;
        }

        public VinWrapper TryGetVins(string vin)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, Config.IpAdress + $"/GetVins?vin={vin}");
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Config.Login}:{Config.Password}")));

                var response = HttpClient.Send(request);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Ошибка доступа к Api. StatusCode: " + response.StatusCode);
                    return null;
                }

                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<VinWrapper>(json);
            }
            catch
            {
                MessageBox.Show("Не удалось обратиться по адресу: " + Config.IpAdress);
                return null;
            }
        }

        public bool TryDeleteVin(int id, string catalog)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, Config.IpAdress + $"/deletevin/{catalog}?id={id}");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Config.Login}:{Config.Password}")));

            var response = HttpClient.Send(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Ошибка доступа к Api. StatusCode: " + response.StatusCode);
                return false;
            }

            return true;
        }
    }
}
