using LegiaoKMusic.Interface;
using LegiaoKMusic.Models;

namespace LegiaoKMusic.Servives
{
    public class ArtistaService : IArtistaService
    {
        public List<Artista> GetArtistas()
        {

            return new List<Artista>()
            {
                new Artista
                {
                    Nome = "André",
                    Descricao="",
                    Link="",
                    ImagemURL=""
                
                }
            };
        }
    }
}
