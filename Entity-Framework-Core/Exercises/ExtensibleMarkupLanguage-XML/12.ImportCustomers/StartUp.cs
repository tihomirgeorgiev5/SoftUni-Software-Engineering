﻿using CarDealer.Data;
using CarDealer.DTO.ExportDto;
using CarDealer.DTO.ImportDto;
using CarDealer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext dbContext = new CarDealerContext();

            //ResetDb(dbContext);

            string inputXml = File.ReadAllText("../../../Datasets/customers.xml");
            string result = ImportCustomers(dbContext, inputXml);

            Console.WriteLine(result);

        }
       
        //Problem.19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter sw = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlserializer("sales", typeof(ExportSalesWithDiscount[]));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            ExportSalesWithDiscount[] dtos = context
                .Sales
                .Select(s => new ExportSalesWithDiscount()
                {
                    Car = new ExportSalesCarDto()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TravelledDistance.ToString()
                    },
                    Discount = s.Discount.ToString(),
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price).ToString(),
                    PriceWithDiscount = (s.Car.PartCars.Sum(pc => pc.Part.Price) - s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100).ToString()

                }).ToArray();

            xmlSerializer.Serialize(sw, dtos, namespaces);
            return sb.ToString().TrimEnd();

        }

        private static void ResetDb(CarDealerContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            Console.WriteLine("Db reset successfully");
        }
        //Problem14
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = GenerateXmlserializer("cars", typeof(ExportCarsWithDistanceDto[]));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            using StringWriter stringWriter = new StringWriter(sb);

            ExportCarsWithDistanceDto[] carsDtos =
                context
                .Cars
                .Where(c => c.TravelledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .Select(c => new ExportCarsWithDistanceDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TravelledDistance.ToString()
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, carsDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem.12
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlserializer("Customers", typeof(ImportCustomerDto[]));

            using StringReader stringReader = new StringReader(inputXml);

            var customerDtos = (ImportCustomerDto[])xmlSerializer.Deserialize(stringReader);

            var customers = new HashSet<Customer>();

            foreach (var custDto in customerDtos)
            {
                Customer customer = new Customer()
                {
                    Name = custDto.Name,
                    BirthDate = DateTime.Parse(custDto.BirthDate),
                    IsYoungDriver = bool.Parse(custDto.IsYoungDriver)
                };

                customers.Add(customer);
                // Name = partDto.Name,
             //      Price = decimal.Parse//(partDto.Price),
             //      Quantity = partDto.Quantity,
             //      Supplier = supplier
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";
        }

        //problem 11
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlserializer("Cars", typeof(ImportCarDto[]));

            using StringReader stringReader = new StringReader(inputXml);

            ImportCarDto[] carDtos = (ImportCarDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Car> cars = new HashSet<Car>();
            //ICollection<Part> partCars = new HashSet<PartCar>();

            foreach (var carDto in carDtos)
            {
                Car c = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TravelledDistance
                };

                ICollection<PartCar> currentCarParts = new HashSet<PartCar>();
                foreach (var partId in carDto.Parts.Select(p => p.Id).Distinct())
                {
                    Part part = context
                        .Parts
                        .Find(partId);

                    if (part == null)
                    {
                        continue;
                    }
                    PartCar partCar = new PartCar()
                    {
                        Car = c,
                        Part = part
                    };
                    currentCarParts.Add(partCar);

                        
                }
                c.PartCars = currentCarParts;
                cars.Add(c);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";

        }
        //Problem 10
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Parts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPartDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportPartDto[] partDtos = (ImportPartDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Part> parts = new HashSet<Part>();

            foreach (var partDto in partDtos)
            {
                Supplier supplier = context
                    .Suppliers
                    .Find(partDto.SupplierId);

                if (supplier == null)
                {
                    continue;
                }
                Part p = new Part()
                {
                    Name = partDto.Name,
                    Price = decimal.Parse(partDto.Price),
                    Quantity = partDto.Quantity,
                    Supplier = supplier
                };

                parts.Add(p);
            }
            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";

        }
        //Problem 09
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Suppliers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSupplierDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportSupplierDto[] dtos = (ImportSupplierDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Supplier> suppliers = new HashSet<Supplier>();

            foreach (var supplierDto in dtos)
            {
                Supplier s = new Supplier()
                {
                    Name = supplierDto.Name,
                    IsImporter = bool.Parse(supplierDto.IsImporter)
                };

                suppliers.Add(s);

            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";

        }

        private static XmlSerializer GenerateXmlserializer(string rootName, Type dtoType)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
            XmlSerializer xmlSerializer = new XmlSerializer(dtoType, xmlRoot);

            return xmlSerializer;
        }
    }
}