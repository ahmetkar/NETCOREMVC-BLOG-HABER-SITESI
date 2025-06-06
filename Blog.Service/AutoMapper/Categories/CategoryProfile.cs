﻿using AutoMapper;
using Blog.Entity.DTOs.Category;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewModel, Category>().ReverseMap();
            CreateMap<MenuCategoryViewModel, Category>().ReverseMap();
            CreateMap<CategoryCreateModel, Category>().ReverseMap();
            CreateMap<CategoryUpdateModel, Category>().ReverseMap();

        }
    }
}
