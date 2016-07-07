using GifRoulette.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;


namespace GifRoulette.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Spin(SpinModel model)
        {
            var keywordEncoded = WebUtility.UrlEncode(model.Keyword);
            var url = "http://api.giphy.com/v1/gifs/random?api_key=dc6zaTOxFJmzC&rating=pg13&tag=" + keywordEncoded;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();
                var gifyResponse = JsonConvert.DeserializeObject<GifyResponseModel>(content);
                ViewData["Query"] = url;
                ViewData["ImageUrl"] = gifyResponse.Data.Image_Url;
                ViewData["MyTestData"] = "Hi";

                return View();
            }
        }
    }
}