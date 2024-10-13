//using BlogWebApplication.Context;
//using BlogWebApplication.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace BlogWebApplication.Controllers
//{
//    public class DestinosController : Controller
//    {
//        private readonly BlogAppDbContext _context;

//        public DestinosController(BlogAppDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult PraiaDoUna()
//        {
//            return View();
//        }

//        public IActionResult CamposDoJordao()
//        {
//            // Carregar os comentários do banco de dados
//            var comentarios = _context.Comentarios.ToList();
//            ViewBag.Comentarios = comentarios;
//            return View();
//        }

//        [HttpPost]
//        public IActionResult AdicionarComentario(Comentario comentario)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Comentarios.Add(comentario);
//                _context.SaveChanges();
//                return RedirectToAction("CamposDoJordao"); // Redireciona para a página do artigo
//            }

//            return View("CamposDoJordao");
//        }
//    }
//}

using BlogWebApplication.Context;
using BlogWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlogWebApplication.Controllers
{
    public class DestinosController : Controller
    {
        private readonly BlogAppDbContext _context;
        private readonly string _weatherApiKey = "5e3cb400abca22d194651d6d362ebe43"; // API de Previsão do Tempo
        private readonly string _weatherApiUrl = "https://api.openweathermap.org/data/2.5/weather"; // API de Previsão do Tempo

        public DestinosController(BlogAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PraiaDoUna()
        {
            return View();
        }

        public async Task<IActionResult> CamposDoJordaoAsync()
        {
            // Carregar os comentários do banco de dados
            var comentarios = _context.Comentarios.ToList();
            ViewBag.Comentarios = comentarios;
            ViewBag.HasComentarios = comentarios.Any(); // Verifica se existem comentários

            // Chamar a API de previsão do tempo
            var weatherData = await GetWeatherDataAsync("Campos do Jordão");
            ViewBag.WeatherData = weatherData;

            return View();
        }

        [HttpPost]
        public IActionResult AdicionarComentario(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                _context.Comentarios.Add(comentario);
                _context.SaveChanges();
                return RedirectToAction("CamposDoJordao"); // Redireciona para a página do artigo
            }

            return View("CamposDoJordao");
        }

        // Método para buscar dados da API do OpenWeatherMap
        private async Task<dynamic> GetWeatherDataAsync(string cidade)
        {
            using (var httpClient = new HttpClient())
            {
                var url = $"{_weatherApiUrl}?q={cidade}&appid={_weatherApiKey}&units=metric&lang=pt_br";
                var response = await httpClient.GetStringAsync(url);
                dynamic weatherData = JsonConvert.DeserializeObject(response);
                return weatherData;
            }
        }
    }
}
