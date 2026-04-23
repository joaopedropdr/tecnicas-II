
var songs = new List<Songs>
{
    new Songs(1, "Bohemian Rhapsody", "Queen", new DateTime(1975, 10, 31)),
    new Songs(2, "Stairway to Heaven", "Led Zeppelin", new DateTime(1971, 11, 8)),
    new Songs(3, "Hotel California", "Eagles", new DateTime(1976, 12, 8)),
    new Songs(4, "Imagine", "John Lennon", new DateTime(1971, 10, 11)),
    new Songs(5, "Smells Like Teen Spirit", "Nirvana", new DateTime(1991, 9, 10))
};

// Usando LINQ para filtrar e ordenar as músicas
Console.WriteLine("Songs released in 1991");
// O Where filtra as músicas lançadas em 1991 e o ToList() converte o resultado para uma lista
var songs91 = songs.Where(songs => songs.ReleaseDate.Year == 1991).ToList();
foreach (var song in songs91)
{
    Console.WriteLine(song.ToString());
}

Console.WriteLine("Songs released on october");
var songsOctober = songs.Where(x => x.ReleaseDate.Month == 10).ToList();
songsOctober = songsOctober.OrderBy(x => x.ReleaseDate).ToList();
foreach (var song in songsOctober)
{
    Console.WriteLine(song.ToString());
}
Console.WriteLine("Return Songs in alphabetical order.");
// O OrderBy ordena as músicas em ordem alfabética pelo nome
var songsAlphabetical = songs.OrderBy(x => x.Name).ToList();
foreach (var song in songsAlphabetical)
{
    Console.WriteLine(song.ToString());
}



public class Songs
{
    public Songs(int id, string name, string band, DateTime releaseDate)
    {
        Id = id;
        Name = name;
        Band = band;
        ReleaseDate = releaseDate;  

    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Band { get; set; }
    public DateTime ReleaseDate { get; set; }

    public override string ToString() =>
        $"Id: {Id}, Name: {Name}, Band: {Band}, ReleaseDate: {ReleaseDate.ToShortDateString()}";
    
}