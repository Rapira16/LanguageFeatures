using System.Net.Http;
using System.Threading.Tasks;
namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var HttpMessage = await client.GetAsync("http://apress.com");
            return HttpMessage.Content.Headers.ContentLength;
        }
    }
}