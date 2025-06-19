using DataAccessLayer.DalConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation.Album{

    public class AlbumRecord {

        public long Album_Id { get; set; }

        public string AlbumName { get; set; }

        public DateTime? AlbumReleaseDate { get; set; }

        public TimeSpan? AlbumLenght { get; set; }

        public string Genre { get; set; }

        public string Label { get; set; } 

        public string CoverImageUrl { get; set; }

        public long? ArtistId { get; set; }

        public bool IsActive { get; set; }

        public AlbumRecord() {

            Album_Id = 0;
            AlbumName = string.Empty;
            AlbumReleaseDate = DateTime.Now;
            AlbumLenght = null; 
            Genre = null;
            Label = null;
            CoverImageUrl = null;
            ArtistId = null;
            IsActive = true;
        }
    }

    public class AlbumService : DalConnections { 
    
        public void Get(long Id) {

            try {

                string command = $@"SELECT * FROM ALBUM WHERE Album_Id = {Id}";



            } catch(Exception) {

                throw;
            }

        }

        public void Create(AlbumRecord record) {

            try {

                string command = $@"
                    INSERT INTO ALBUM (
                        AlbumName,
                        AlbumReleaseDate,
                        AlbumLenght,
                        Genre,
                        Label,
                        CoverImageUrl,
                        ArtistId,
                        IsActive
                    ) VALUES (
                        '{record.AlbumName}',
                        '{record.AlbumReleaseDate}',
                        '{record.AlbumLenght}',
                        '{record.Genre}',
                        '{record.Label}',
                        '{record.CoverImageUrl}',
                        {record.ArtistId},
                        {record.IsActive})";

                ExecuteQuery(command);

            } catch(Exception) {

                throw;
            }

        }

        public void Update() {

            try {



            } catch(Exception) {

                throw;
            }

        }

        public void CreateOrUpdate() {

            try {



            } catch(Exception) {

                throw;
            }

        }

        public void Delete() {

            try {



            } catch(Exception) {

                throw;
            }

        }
    
    }

}
