using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatAccess
{
    public class GenreModel
    {
        MusicCSJEntities MusicCSJ = new MusicCSJEntities();
        public bool saveGenre(genresD g)
        {
            //MusicCSJEntities genre = new MusicCSJEntities();
            try
            {
                
                MusicCSJ.genresDs.Add(g);
                MusicCSJ.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public bool deleteGenre(genresD g)
        {
           // MusicCSJEntities genre = new MusicCSJEntities();
            /*
             * OPCIÓN 1
             try
            {
                genre query = from gid in genre.genres
                            where gid.id == g.id
                            select gid;
                genre.genres.Remove(query);
                genre.SaveChanges();
                return true;
            }
             OPCIÓN 2
             */
            try
            {
                var query = from gid in MusicCSJ.genresDs
                                          where gid.id == g.id
                                          select gid;
                MusicCSJ.genresDs.Remove((genresD)query.First());
                MusicCSJ.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return false;
        }

        public bool updateGenre(genresD g)
        {
            //MusicCSJEntities genre = new MusicCSJEntities();
            try
            {
                var query = (from gid in MusicCSJ.genresDs
                               where gid.id == g.id
                               select gid).First();
                query.nameG = g.nameG;
                MusicCSJ.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public List<genresD> getAllGenres()
        {
           // MusicCSJEntities company = new MusicCSJEntities();
            var query = from g in MusicCSJ.genresDs
                                      orderby g.id ascending
                                      select g;
            return query.ToList();

        }

    }
}
