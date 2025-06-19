using DbManipulation.Genre;
using GenreRn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendManagerConsole{

    public class Genero {

        #region GLOBAL_VARIABLES
        GenreRecord record = new GenreRecord();
        CreateMusicGenre create = new CreateMusicGenre();

        private short option = 0;
        #endregion GLOBAL_VARIABLES

        public void GeneroMenu() {

            Console.Clear();
            Console.Write("0) Retornar ao Menu principal\n1)Adicionar gênero: ");
            option = Convert.ToInt16(Console.ReadLine());

            switch(option) {

                case 0:
                    return;
                case 1:
                    AdicionarGenero();
                    break;
                default:
                    Console.WriteLine("Número invalido!");
                    break;
            }

        }

        public void AdicionarGenero() {

            Console.Write("Digite o nome do gênero que deseja adicionar: ");
            record.GenreName = Console.ReadLine();

            Console.Write("Digite a descrição do gênero que deseja adicionar: ");
            record.Description = Console.ReadLine();

            this.create.CreateNewGenre(record);

        }

    }
}
