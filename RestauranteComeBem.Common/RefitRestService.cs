using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace RestauranteComeBem.Common
{
    public class RefitRestService<T>
    {
        private readonly T _restService;

        public RefitRestService(string apiBaseAddress, int timeoutMilliseconds = 60000)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var _client = new HttpClient(handler)
            {
                BaseAddress = new Uri(apiBaseAddress),
                Timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds),
            };

            _restService = RestService.For<T>(_client);
        }

        public T GetAPIEnpoints()
        {
            return new Lazy<T>(() =>
            {
                return _restService;
            }).Value;
        }
    }
}
