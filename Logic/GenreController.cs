using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatAccess;

namespace Logic
{
    public class GenreController
    {
        public String addGenre(genresD g)
        {
            GenreModel gm = new GenreModel();
            return gm.saveGenre(g) ? "Genre Agregado" : "Genre no agregado!!!!";
        }

        public String removeGenre(genresD g)
        {
            GenreModel gm = new GenreModel();
            return gm.deleteGenre(g) ? "Gender Eliminado" : "Genre no eliminado";

        }

        public String updateGenre(genresD g)
        {
            GenreModel gm = new GenreModel();
            return gm.updateGenre(g) ? "Gender actualizado" : "Genre no actualizado";

        }

        public List<genresD> allGenres()
        {
            GenreModel gm = new GenreModel();
            return gm.getAllGenres();

        }


    }
}
