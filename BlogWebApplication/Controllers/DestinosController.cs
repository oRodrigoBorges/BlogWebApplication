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

namespace BlogWebApplication.Controllers
{
    public class DestinosController : Controller
    {
        private readonly BlogAppDbContext _context;

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

        public IActionResult CamposDoJordao()
        {
            // Carregar os comentários do banco de dados
            var comentarios = _context.Comentarios.ToList();
            ViewBag.Comentarios = comentarios;
            ViewBag.HasComentarios = comentarios.Any(); // Verifica se existem comentários
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
    }
}
