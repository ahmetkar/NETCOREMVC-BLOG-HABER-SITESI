﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Category
{
    public class CategoryUpdateModel
    {
        public Guid Id  { get; set; }
        public string Name { get; set; }
    }
}
