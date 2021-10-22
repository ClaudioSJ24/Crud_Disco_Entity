using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatAccess
{
    public class AlbumModel
    {
        MusicCSJEntities MusicCSJ = new MusicCSJEntities();
        public bool saveAlbum(albumsD a)
        {
           // MusicCSJEntities album = new MusicCSJEntities();
            try
            {
                
                MusicCSJ.albumsDs.Add(a);
                MusicCSJ.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public bool deleteAlbum(albumsD a)
        {
           // MusicCSJEntities album = new MusicCSJEntities();
            try
            {
                var query = from a_id in MusicCSJ.albumsDs
                                          where
                                          a_id.id == a.id
                                          select a_id;
                MusicCSJ.albumsDs.Remove((albumsD)query.First());
                MusicCSJ.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public bool updateAlbum(albumsD a)
        {
            //MusicCSJEntities album = new MusicCSJEntities();
            try
            {
                var query = (from a_id in MusicCSJ.albumsDs
                               where
                               a_id.id == a.id
                               select
                               a_id).First();
                query.nameA = a.nameA;
                query.author = a.author;
                query.genre_id = a.genre_id;
                MusicCSJ.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public List<albumsD> getAlbums()
        {
            //MusicCSJEntities album = new MusicCSJEntities();

            var query = from a in MusicCSJ.albumsDs
                                      orderby a.id
                                      select a;
            return query.ToList();
        }

    }
}
