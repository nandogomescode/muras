using DataAccessLayer.DalConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation.Genre {

    public class GenreRecord {
       
        public long Id { get; set; }

        public string GenreName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        public GenreRecord() {

            Id = 0;
            GenreName = string.Empty;
            Description = string.Empty;
            CreatedAt = DateTime.Now;
            IsActive = true;

        }

    }
    
    public class GenreService : DalConnections {


        public long Create(GenreRecord record) {

			try {

                long Genre_Id = 0;

                string command = $@"
                    INSERT INTO GENRE (
                        GenreName, 
                        Description, 
                        CreatedAt, 
                        Is_Active
                    ) VALUES (
                        '{record.GenreName}', 
                        '{record.Description}', 
                        '{record.CreatedAt}', 
                        {BooleanFormat(record.IsActive)});";

                ExecuteQuery(command);

                return Genre_Id;

			} catch(Exception) {

				throw;
			}

        }

    }
}
