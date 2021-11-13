namespace MusicHub
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here
            //Console.WriteLine("Db created successfully!");
            string result = ExportSongsAboveDuration(context, 4);
            Console.WriteLine(result);
        }



        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder sb = new StringBuilder();
            var albumsInfo = context
                .Albums
                .ToArray()
                .Where(a => a.ProducerId == producerId)
                .OrderByDescending(a => a.Price)
                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                    ProducerName = a.Producer.Name,
                    AlbumSongs = a.Songs
                    .ToArray()
                    .Select(s => new
                    {
                        SongName = s.Name,
                        Price = s.Price.ToString("f2"),
                        SongWriterName = s.Writer.Name
                    })
                    .OrderByDescending(s => s.SongName)
                    .ThenBy(s => s.SongWriterName)
                    .ToArray(),
                    TotalAlbumPrice = a.Price.ToString("f2")
                })
                .ToArray();

            foreach (var album in albumsInfo)
            {
                sb
                    .AppendLine($"-AlbumName: {album.AlbumName}")
                    .AppendLine($"-ReleaseDate: {album.ReleaseDate}")
                    .AppendLine($"-ProducerName: {album.ProducerName}")
                    .AppendLine($"-Songs:");

                int i = 1;
                foreach (var song in album.AlbumSongs)
                {
                    sb
                        .AppendLine($"---#{i++}")
                        .AppendLine($"---SongName: {song.SongName}")
                        .AppendLine($"---Price: {song.Price}")
                        .AppendLine($"---Writer: {song.SongWriterName}");
                }

                sb.AppendLine($"-AlbumPrice: {album.TotalAlbumPrice}");

            }

            return sb.ToString().TrimEnd();

        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder sb = new StringBuilder();
            var songs = context
                .Songs
                .ToArray()
                .Where(x => x.Duration.TotalSeconds > duration)
                .Select(s => new
                {
                    SongName = s.Name,
                    WriterName = s.Writer.Name,
                    Performer = s.SongPerformers
                   .ToArray()
                   .Select(p => p.Performer.FirstName + " " + p.Performer.LastName)
                   .FirstOrDefault(),
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration
                })
                .OrderBy(s => s.SongName)
                .ThenBy(s => s.WriterName)
                .ThenBy(s => s.Performer)
                .ToArray();

            int i = 1;

            foreach (var song in songs)
            {

                sb
                    .
                    AppendLine($"-Song #{i++}")
                    .AppendLine($"---SongName: {song.SongName}")
                    .AppendLine($"---Writer: {song.WriterName}")
                    .AppendLine($"---Performer: {song.Performer}")
                    .AppendLine($"---AlbumProducer: {song.AlbumProducer}")
                    .AppendLine($"---Duration: {song.Duration}");
                    
                

            }


            return sb.ToString().TrimEnd();
            
        }
    }
}
