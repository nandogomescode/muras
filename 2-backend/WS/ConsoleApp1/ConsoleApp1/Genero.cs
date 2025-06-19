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
            Console.Write("0) Retornar ao Menu principal\n1) Adicionar um gênero: \n2) Atualizar um gênero\n3) Deletar um gênero\n4) Listar gêneros\n\nDigite sua opção: ");
            option = Convert.ToInt16(Console.ReadLine());

            switch(option) {

                case 0:
                    return;
                case 1:
                    AdicionarGenero();
                    break;
                case 2:
                    AtualizarGenero();
                    break;
                case 3:
                    DeletarGenero();
                    break;
                case 4:
                    ListarGeneros();
                    break;
                default:
                    Console.WriteLine("Número invalido!");
                    break;
            }
        }

        private void AdicionarGenero() {

            Console.Write("Digite o nome do gênero que deseja adicionar: ");
            record.GenreName = Console.ReadLine();

            Console.Write("Digite a descrição do gênero que deseja adicionar: ");
            record.Description = Console.ReadLine();

            this.create.CreateNewGenre(record);

        }

        private void AtualizarGenero() {



        }

        private void DeletarGenero() {


        }

        private void ListarGeneros() {


        }
    }
}
