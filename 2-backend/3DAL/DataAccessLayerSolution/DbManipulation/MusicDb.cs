using DataAccessLayer.DalConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation.Music{

    public class MusicRecord() {



    }

    public class MusicService : DalConnections{

        public long Create() {

			try {

                long musicId = 0;

                string command = $@"";

                return musicId;

			} catch(Exception) {

				throw;
			}

        }

    }
}
