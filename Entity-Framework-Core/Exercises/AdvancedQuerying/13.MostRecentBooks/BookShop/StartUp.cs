namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var dbContext = new BookShopContext();
            DbInitializer.ResetDatabase(dbContext);

            //int input =
                // int.Parse(Console.ReadLine());

            string result = GetMostRecentBooks(dbContext);

             


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

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            var listCategories = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.ToLower())
                .ToList();

            var books = context
                .Books
                .Where(b => b.BookCategories.Any(bc => listCategories.Contains(bc.Category.Name.ToLower())))

                .Select(c => new
                {
                    Title = c.Title
                })
                .OrderBy(b => b.Title)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder sb = new StringBuilder();
            var rightlyDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var books = context
                .Books
                .Where(b => b.ReleaseDate < rightlyDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    title = b.Title,
                    editionType = b.EditionType,
                    price = b.Price
                }).ToArray();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.title} - {book.editionType} - ${book.price:f2}");
            }

            return sb.ToString().TrimEnd();

        }
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            var authors = context
                .Authors
                .ToArray()
                .Where(a => a.FirstName.ToLower().EndsWith(input.ToLower()))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .OrderBy(n => n)
                .ToArray();

            foreach (var author in authors)
            {
                sb.AppendLine(author);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            var titles = context
                .Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => new
                {
                    title = b.Title
                })
                .OrderBy(t => t.title)
                .ToArray();

            foreach (var book in titles)
            {
                sb.AppendLine(book.title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            var books = context
                .Books
                .OrderBy(b => b.BookId)
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    titles = b.Title,
                    authorsNames = b.Author.FirstName + " " + b.Author.LastName
                })
                .ToArray();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.titles} ({book.authorsNames})");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context
                  .Books
                  .Where(b => b.Title.Length > lengthCheck)
                  .ToArray();

            return books.Count();    
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var authors = context
                .Authors
                .Select(a => new
                {
                    fullName = a.FirstName + " " + a.LastName,
                    totalNumOfCop = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(b => b.totalNumOfCop)
                .ToArray();

            foreach (var book in authors)
            {
                sb.AppendLine($"{book.fullName} - {book.totalNumOfCop}");
            }

            return sb.ToString().TrimEnd();
                
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var categories = context
                .Categories
                .Select(c => new
                {
                    categoryName = c.Name,
                    totalProfit = c.CategoryBooks
                    .Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(c => c.totalProfit)
                .ThenBy(c => c.categoryName)
                .ToArray();

            foreach (var book in categories)
            {
                sb.AppendLine($"{book.categoryName} ${book.totalProfit:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var categories = context
                .Categories
                .Select(c => new
                {
                    categoryName = c.Name,
                    mostRecentBooks = c.CategoryBooks
                    .Select(cb => cb.Book)
                    .OrderByDescending(b => b.ReleaseDate)
                    .Select(b => new
                    {
                        title = b.Title,
                        releaseYear = b.ReleaseDate.Value.Year
                    })
                    .Take(3)
                    .ToArray()

                })
                .OrderBy(c => c.categoryName)
                .ToArray();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.categoryName}");

                foreach (var book in category.mostRecentBooks)
                {
                    sb.AppendLine($"{book.title} ({book.releaseYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }



    }
   
    

      
        
      
   
}
