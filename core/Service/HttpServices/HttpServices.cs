using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace core.Service
{
    public class HttpServices : IHttpServicesAuthorized , IHttpServicesUnAuthorized
    {
        private readonly HttpClient client;
        private HttpClientConfig HttpConfig { get; }

        public HttpServices(HttpClient _client, HttpClientConfig httpConfig)
        {
            client = _client;
            HttpConfig = httpConfig;
        }

        #region Authorized
        public async Task<TResponse> GetAuthorizedAsync<TResponse>(string pathUrl, string token)
        {
            if (string.IsNullOrEmpty(pathUrl) || string.IsNullOrEmpty(token))
                throw new ArgumentNullException($"{nameof(pathUrl)} or {nameof(token)} is null");

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpConfig.Application));
                client.DefaultRequestHeaders.Add(HttpConfig.Cache, HttpConfig.NoChace);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var result = await client.GetStringAsync(GetUrl(pathUrl));
            

            return await Task.Run(() => JsonConvert.DeserializeObject<TResponse>(result));

            throw new HttpRequestException(result);
        }

        public async Task<TResponse> PutAuthorizedAsync<TSource, TResponse>(string pathUrl, string token, TSource body)
        {
            if (string.IsNullOrEmpty(pathUrl) || string.IsNullOrEmpty(token))
                throw new ArgumentNullException($"{nameof(pathUrl)} or {nameof(token)} is null");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpConfig.Application));
            client.DefaultRequestHeaders.Add(HttpConfig.Cache, HttpConfig.NoChace);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await client.PutAsync(GetUrl(pathUrl),
                                new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, HttpConfig.Application));

            if (result.IsSuccessStatusCode)
            {
                return await Task.Run(() => JsonConvert.DeserializeObject<TResponse>(result.Content.ReadAsStringAsync().Result));
            }

            throw new HttpRequestException(result.ReasonPhrase);
        }

        public async Task<TResponse> DeleteAuthorizedAsync<TSource, TResponse>(string pathUrl, string token, TSource body)
        {
            if (string.IsNullOrEmpty(pathUrl) || string.IsNullOrEmpty(token))
                throw new ArgumentNullException($"{nameof(pathUrl)} or {nameof(token)} is null");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpConfig.Application));
            client.DefaultRequestHeaders.Add(HttpConfig.Cache, HttpConfig.NoChace);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var request = new HttpRequestMessage(HttpMethod.Delete, GetUrl(pathUrl));

            request.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, HttpConfig.Application);

            var result = await Task.Run(() => client.SendAsync(request));

            if (result.IsSuccessStatusCode)
            {
                return await Task.Run(() => JsonConvert.DeserializeObject<TResponse>(result.Content.ReadAsStringAsync().Result));
            }

            throw new HttpRequestException(result.ReasonPhrase);
        }
        public async Task<TResponse> PostAuthorizedAsync<TSource, TResponse>(string pathUrl, string token, TSource body)
        {
            try
            {
                if (string.IsNullOrEmpty(pathUrl) || string.IsNullOrEmpty(token))
                    throw new ArgumentNullException($"{nameof(pathUrl)} or {nameof(token)} is null");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpConfig.Application));
                client.DefaultRequestHeaders.Add(HttpConfig.Cache, HttpConfig.NoChace);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var result = await client.PostAsync(GetUrl(pathUrl),
                                    new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, HttpConfig.Application));

                if (result.IsSuccessStatusCode)
                {
                    var value = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TResponse>(value);
                }
                throw new HttpRequestException(result.ReasonPhrase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region UnAuthorized
            
        public async Task<TResponse> GetUnAuthorizedAsync<TResponse>(string pathUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(pathUrl))
                    throw new ArgumentNullException($"{nameof(pathUrl)} is required");

                var result = await client.GetStringAsync(GetUrl(pathUrl));

                return await Task.Run(() => JsonConvert.DeserializeObject<TResponse>(result));
                throw new HttpRequestException(result);
            }
            catch (Exception x)
            {

                throw;
            }
         

     
        }

        public async Task<TResponse> PostUnAuthorizedAsync<TSource, TResponse>(string pathUrl, TSource body)
        {
            try
            {
                if (string.IsNullOrEmpty(pathUrl))
                    throw new ArgumentNullException($"{nameof(pathUrl)}");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");

                var result = await client.PostAsync(GetUrl(pathUrl),
                                    new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json"));

                if (result.IsSuccessStatusCode)
                {
                    var value = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TResponse>(value);
                }
                throw new HttpRequestException(result.ReasonPhrase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<TResponse> PutUnAuthorizedAsync<TSource, TResponse>(string pathUrl, TSource body)
        {
            if (string.IsNullOrEmpty(pathUrl))
                throw new ArgumentNullException($"{nameof(pathUrl)} is null");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpConfig.Application));
            client.DefaultRequestHeaders.Add(HttpConfig.Cache, HttpConfig.NoChace);

            var result = await client.PutAsync(GetUrl(pathUrl),
                                new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, HttpConfig.Application));

            if (result.IsSuccessStatusCode)
            {
                return await Task.Run(() => JsonConvert.DeserializeObject<TResponse>(result.Content.ReadAsStringAsync().Result));
            }

            throw new HttpRequestException(result.ReasonPhrase);
        }

        #endregion

        private string GetUrl(string pathUrl)
        {
            var url = "http://api-prod-rest.us-east-1.elasticbeanstalk.com/" + pathUrl;
            return url;
        }
    }
}
