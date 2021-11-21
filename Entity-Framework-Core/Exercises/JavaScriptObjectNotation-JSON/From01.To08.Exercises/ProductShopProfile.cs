﻿using AutoMapper;
using ProductShop.DataTransferObject;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            this.CreateMap<UserInputModel, User>();

            this.CreateMap<ProductInputModel, Product>();

            this.CreateMap<CategorieInputModel, Category>();

            this.CreateMap<CatProductInputModel, CategoryProduct>();
        }
    }
}
