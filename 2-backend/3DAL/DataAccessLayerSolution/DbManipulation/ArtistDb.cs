using DataAccessLayer.DalConnections;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation.Artist{

    public class ArtistRecord {

        public int Artist_Id { get; set; }

        public string ArtistName { get; set; }

        public string ArtistBio { get; set; }

        public string ArtistType { get; set; }

        public string Country { get; set; }

        public int? DebutYear { get; set; }

        public bool IsActive { get; set; }

        public ArtistRecord() {

            Artist_Id = 0;  
            ArtistName = string.Empty; 
            ArtistBio = string.Empty;  
            ArtistType = string.Empty; 
            Country = string.Empty;
            DebutYear = null;
            IsActive = true;   


        }

    }

    public class ArtistDbService : DalConnections {

        public long Create(ArtistRecord record) {

            try {

                long Artist_Id = 0;
                string command = $@"
                    INSERT INTO ARTIST (
                        ArtistName, 
                        ArtistBio, 
                        ArtistType, 
                        Country, 
                        DebutYear, 
                        IsActive) 
                    VALUES (
                        '{record.ArtistName}', 
                        '{record.ArtistBio}', 
                        '{record.ArtistType}', 
                        '{record.Country}', 
                        '{record.DebutYear}', 
                        {BooleanFormat(record.IsActive)});";

                ExecuteQuery(command);

                return Artist_Id;

            } catch(Exception) {

                throw;
            }

        }

    }
}
