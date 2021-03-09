using System.Net.Http;
using System.Threading.Tasks;
namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            //The await keyword tells the C# compiler to wait for the result of the Task that the GetAsync method returns
            //and then carry on executing other statements in the same method
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
