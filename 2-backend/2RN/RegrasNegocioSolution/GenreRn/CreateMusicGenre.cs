using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DalConnections;
using DbManipulation.Genre;

namespace GenreRn {

    public class CreateMusicGenre : DalConnections {

        public void CreateNewGenre(GenreRecord record)
        {

            GenreService genreDbService = new GenreService();             

            genreDbService.Create(record);

        }

    }
}
