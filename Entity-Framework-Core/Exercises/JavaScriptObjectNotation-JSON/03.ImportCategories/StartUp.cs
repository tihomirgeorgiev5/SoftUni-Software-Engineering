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
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            

            string usersJson = File.ReadAllText("../../../Datasets/users.json");

            string productsJson = File.ReadAllText("../../../Datasets/products.json");

            string categoriesJson = File.ReadAllText("../../../Datasets/categories.json");

            
            ImportUsers(context, usersJson);

            ImportProducts(context, productsJson);

            var result = ImportCategories(context, categoriesJson);

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