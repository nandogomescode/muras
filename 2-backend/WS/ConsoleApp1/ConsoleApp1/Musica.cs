using DbManipulation.Album;
using DbManipulation.Music;
using System;

namespace BackendManagerConsole{


    public class Musica{

        #region GLOBAL_VARIABLES
        MusicRecord record = new MusicRecord();

        private short option = 0;
        #endregion GLOBAL_VARIABLES

        public void MusicaMenu() {

            Console.Write("0) Sair do programa\n1) Menu de artistas\n2) Menu de gêneros musicais\n3) Menu de albuns\n4) Menu de músicas\n\nDigite sua opção: ");

            switch(option) {

                case 0:
                    return;
                case 1:
                    AdicionarMusica();
                    break;
                case 2:
                    AtualizarMusica();
                    break;
                case 3:
                    DeletarMusica();
                    break;
                case 4:
                    ListarMusicas();
                    break;
                default:
                    Console.WriteLine("Número invalido!");
                    break;
            }

        }

        private void AdicionarMusica() {


        }

        private void AtualizarMusica() {


        }

        private void DeletarMusica() {



        }

        private void ListarMusicas() {



        }

    }
}
