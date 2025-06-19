using Microsoft.Data.SqlClient;
using MusicRn;
using System.Data;
using DbManipulation.Genre;
using GenreRn;
using DbManipulation.Artist;
using ArtistRn;
using BackendManagerConsole;

internal class main {

    private static void Main(string[] args) {

        Album albumObj = new Album();
        Musica musicaObj = new Musica();
        Genero generoObj = new Genero();
        Artista artistaObj = new Artista();

        int menu = 0;
        string response = string.Empty;

        do {

            Console.Write("0) Sair do programa\n1) Menu de artistas\n2) Menu de gêneros musicais\n3) Menu de albuns\n4) Menu de músicas\n\nDigite sua opção: ");
        
            menu = Convert.ToInt32(Console.ReadLine());

            switch(menu) {

                case 0: return;                
                case 1:
                    artistaObj.ArtistMenu();                
                    break;
                case 2:
                    generoObj.GeneroMenu();
                    break;
                case 3:
                    albumObj.AlbumMenu();
                    break;
                case 4:
                    musicaObj.MusicaMenu();
                    break;  
                default:
                    Console.WriteLine("Opção inválida!");
                    break;

            }

            Console.WriteLine("Deseja sair?");
            response = Console.ReadLine();

        } while(!(response.Equals("Sim") || response.Equals("S") || response.Equals("s") || response.Equals("YES") || response.Equals("Y") || response.Equals("y")));


        Console.Read();
        
    }


    private static void AdicionarArtista() {

        ArtistRecord record = new ArtistRecord();
        CreateArtist service = new CreateArtist();

        Console.Write("Digite o nome do artista que deseja adicionar: ");
        record.ArtistName = Console.ReadLine();

        Console.Write("Digite a bio do artista que deseja adicionar: ");
        record.ArtistBio = Console.ReadLine();

        Console.Write("Digite o país do artista que deseja adicionar: ");
        record.Country = Console.ReadLine();

        Console.Write("Digite o ano do artista que deseja adicionar: ");
        record.DebutYear = Convert.ToInt32(Console.ReadLine());

        service.CreateNewArtist(record);

    }

    private static void MenuArtistas() {

        try {



        } catch(Exception) {

            throw;
        }

    }

    private static void MenuGeneros() {

        try {

        } catch(Exception) {

            throw;
        }

    }

    private static void MenuAlbuns() {

        try {

        } catch(Exception) {

            throw;
        }

    }

    private static void MenuMusicas() {

        try {

        } catch(Exception) {

            throw;
        }

    }

}