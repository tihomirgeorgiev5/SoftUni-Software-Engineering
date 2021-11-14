namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var dbContext = new BookShopContext();
            DbInitializer.ResetDatabase(dbContext);

           int year =
                int.Parse(Console.ReadLine());

            string result = GetBooksNotReleasedIn(dbContext, year);

            Console.WriteLine(result);
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();
            AgeRestriction ageRestriction =
                Enum.Parse<AgeRestriction>(command, true);
            var bookTitles = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            foreach (var title in bookTitles)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();


        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var goldenEditionBooks = context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (var title in goldenEditionBooks)
            {
                sb.AppendLine(title);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var bookPrices = context
                .Books
                .Where(b => b.Price > 40)
                
                .Select(b => new
                {
                    titles = b.Title,
                    prices = b.Price
                })
                .OrderByDescending(b => b.prices)
                .ToArray();

            foreach (var book in bookPrices)
            {
                sb.AppendLine($"{book.titles} - ${book.prices:f2}");

            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
       {
            StringBuilder sb = new StringBuilder();
            var notReleasedBooks = context
                .Books
                .Where(b => b.ReleaseDate.HasValue &&
                       b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (var book in notReleasedBooks)
            {
                sb.AppendLine(book);
            }


            return sb.ToString().TrimEnd();
       }




    }
}
