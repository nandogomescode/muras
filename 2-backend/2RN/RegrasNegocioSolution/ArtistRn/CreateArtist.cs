using DataAccessLayer.DalConnections;
using DbManipulation.Artist;

namespace ArtistRn {

    public class CreateArtist : DalConnections {

        public void CreateNewArtist(ArtistRecord record) {

            ArtistDbService service = new ArtistDbService();

            service.Create(record);

        }

    }
}
