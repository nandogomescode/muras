using ConsoleApp1;
using Microsoft.Data.SqlClient;
using MusicRn;
using System.Data;
using DbManipulation.Genre;
using GenreRn;
using DbManipulation.Artist;
using ArtistRn;

internal class Program {

    private static void Main(string[] args) {

        int menu = 0;

        Console.WriteLine("1) Adicione um artista:\n2)Adicione um gênero:");
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu) {

            case 1:
                AdicionarArtista();
                break;
            case 2:
                AdicionarGenero();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;

        }

        Console.Read();
        
    }

    private static void AdicionarGenero() {

        GenreRecord record = new GenreRecord();
        CreateMusicGenre create = new CreateMusicGenre();

        Console.Write("Digite o nome do gênero que deseja adicionar: ");
        record.GenreName = Console.ReadLine();

        Console.Write("Digite a descrição do gênero que deseja adicionar: ");
        record.Description = Console.ReadLine();

        create.CreateNewGenre(record);

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
}