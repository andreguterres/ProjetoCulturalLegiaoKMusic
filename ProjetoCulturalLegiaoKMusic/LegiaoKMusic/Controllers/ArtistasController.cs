using LegiaoKMusic.Interface;
using LegiaoKMusic.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LegiaoKMusic.Controllers
{
    public class ArtistasController : Controller
    {
        private readonly IArtistaService _artistaService;

        public ArtistasController(IArtistaService artistaService)
        {
            _artistaService = artistaService;
        }
        public IActionResult Index()
        {
            var artistas = _artistaService.GetArtistas().ToList();

            var modelo = new ArtistaViewModel()
            {
                Artistas = artistas,
            };
            return View(modelo);
        }

        public IActionResult Artistas()
        {
            var artistas = _artistaService.GetArtistas();

            return View(artistas);
        }
        //[HttpGet]
        //public IActionResult Contato()

        //{ 
        //    return View();
        //}
    }
}
