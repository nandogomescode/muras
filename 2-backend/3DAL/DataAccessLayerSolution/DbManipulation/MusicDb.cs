using DataAccessLayer.DalConnections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation.Music{

    public class MusicRecord {

        public long Music_Id { get; set; }

        public string MusicName { get; set; }

        public TimeOnly MusicLength { get; set; }

        public int? TrackNumber { get; set; }

        public long? ArtistId { get; set; }

        public long? AlbumId { get; set; }

        public long? GenreId { get; set; }

        public bool IsActive { get;  set; }

        public MusicRecord() {

            Music_Id = 0;
            MusicName = string.Empty;
            MusicLength = TimeOnly.MinValue;
            TrackNumber = null;
            ArtistId = null;
            AlbumId = null;
            GenreId = null;
            IsActive = false;

        }   
    }

    public class MusicService : DalConnections {

        #region GLOBAL_VARIABLES
        private string command = string.Empty;
        private string Table = "MUSIC";
        #endregion GLOBAL_VARIABLES

        public void Get(long Id) {

            try {

                DataTable table = new DataTable();

                this.command = $@"
                    SELECT * FROM {this.Table} 
                    WHERE Id = {Id}";

                table = GetTable(this.command);

                foreach(DataRow row in table.Rows) {

                    

                }

            } catch(Exception) {

                throw;
            }
        }

        public long Create() {

			try {

                long musicId = 0;

                string command = $@"";

                return musicId;

			} catch(Exception) {

				throw;
			}
        }

        public void Update() {

        }

        public void Delete() {

            try {



            } catch(Exception) {

                throw;
            }
        }
    }
}
