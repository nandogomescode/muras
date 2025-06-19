using DbManipulation.Album;
using DbManipulation.Genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendManagerConsole{

    public class Album{

        #region GLOBAL_VARIABLES
        AlbumRecord record = new AlbumRecord();

        private short option = 0;
        #endregion GLOBAL_VARIABLES

        public void AlbumMenu() {

            Console.Write("0) Sair do programa\n1) Menu de artistas\n2) Menu de gêneros musicais\n3) Menu de albuns\n4) Menu de músicas\n\nDigite sua opção: ");

            switch(option) {

                case 0:
                    return;
                case 1:
                    AdicionarAlbum();
                    break;
                case 2:
                    AtualizarAlbum();
                    break;
                case 3:
                    DeletarAlbum();
                    break;
                case 4:
                    ListarAlbuns();
                    break;
                default:
                    Console.WriteLine("Número invalido!");
                    break;
            }

        }

        private void AdicionarAlbum() {




        }

        private void AtualizarAlbum() {




        }

        private void DeletarAlbum() {




        }

        private void ListarAlbuns() {




        }

    }
}
