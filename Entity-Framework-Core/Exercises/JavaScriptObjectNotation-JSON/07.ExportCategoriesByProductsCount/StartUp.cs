using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DataTransferObject;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        static IMapper mapper;
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
           // context.Database.EnsureDeleted();
           // context.Database.EnsureCreated();


            

          // string usersJson = File.ReadAllText//("../../../Datasets/users.json");
          //
          // string productsJson = File.ReadAllText//("../../../Datasets/products.json");
          //
          // string categoriesJson = File.ReadAllText//("../../../Datasets/categories.json");
          //
          // string catProductsJson = /File.ReadAllText/("../../../Datasets//categories-/products.json");
          //

           // ImportUsers(context, usersJson);
           //
           // ImportProducts(context, productsJson);
           //
           // ImportCategories(context, //categoriesJson);
           //
            var result = GetCategoriesByProductsCount(context);
           
           Console.WriteLine(result);

        }

        

       private static void InitializeAutomapper()
       {
           var config = new MapperConfiguration(cfg =>
           {
               cfg.AddProfile<ProductShopProfile>();
           });
           mapper = config.CreateMapper();
       }
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context
                .Categories
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoryProducts.Count,
                    averagePrice = c.CategoryProducts.Count == 0 ? 0.ToString("f2") :
                    c.CategoryProducts.Average(p => p.Product.Price).ToString("f2"),
                    totalRevenue = c.CategoryProducts.Sum(p => p.Product.Price).ToString("f2")
                })
                .OrderByDescending(c => c.productsCount)
                .ToArray();

            var result = JsonConvert.SerializeObject(categories, Formatting.Indented);

            return result;
        }
           
        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context
                .Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                    .Where(p => p.BuyerId != null)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buyerFirstName = p.Buyer.FirstName,
                        buyerLastName = p.Buyer.LastName

                    }).ToArray()
                })
                .OrderBy(u => u.lastName)
                .ThenBy(u => u.firstName)
                .ToArray();

            var result = JsonConvert.SerializeObject(users, Formatting.Indented);

            return result;
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context
                .Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .OrderBy(p => p.price)
                .ToArray();

            var result = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();

            var dtoCatProducts = JsonConvert.DeserializeObject<IEnumerable<CategoryProduct>>(inputJson);

            var catProducts = mapper.Map<IEnumerable<CategoryProduct>>(dtoCatProducts);

            context.CategoryProducts.AddRange(catProducts);
            context.SaveChanges();



            return $"Successfully imported {catProducts.Count()}";
        }
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();

            var dtoCategories = JsonConvert.DeserializeObject<IEnumerable<CategorieInputModel>>(inputJson)
                .Where(c => c.Name != null)
                .ToArray();

            var categories = mapper.Map<IEnumerable<Category>>(dtoCategories);

            context.Categories.AddRange(categories);
            context.SaveChanges();


            return $"Successfully imported {categories.Count()}";
        }
        public static string ImportProducts(ProductShopContext context, string inputJson)
            
        {
            InitializeAutomapper();

            var dtoProducts = JsonConvert.DeserializeObject<IEnumerable<ProductInputModel>>(inputJson);
                
            var products = mapper.Map<IEnumerable<Product>>(dtoProducts);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count()}";

        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();
            var dtoUsers = JsonConvert.DeserializeObject<IEnumerable<UserInputModel>>(inputJson);
             var users = mapper.Map<IEnumerable<User>>(dtoUsers);
            //var mappedUsers = dtoUsers.Select(x => x.MapToDomainUser()).ToArray();
            context.Users.AddRange(users);
            context.SaveChanges();
        return  $"Successfully imported {users.Count()}";

        }

    }

   
}