using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatAccess;

namespace Logic
{
    public class AlbumController
    {
        AlbumModel am = new AlbumModel();

        public String saveA(albumsD a)
        {
            return am.saveAlbum(a) ? "Album agregado" : "Album no agregado";
        }

        public String deleteA(albumsD a)
        {
            return am.deleteAlbum(a) ? "Album eliminado" : "Album no eliminado";
        }

        public String updateA(albumsD a)
        {
            return am.updateAlbum(a) ? "Album Actualizado" : "Album no actualizado";
        }

        public List<albumsD> getAll()
        {
            return am.getAlbums();
        }
    }
}
