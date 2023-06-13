﻿using AspNetCore.Entities.Concrete;
using AspNetCoreBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreBlog.Data.Abstract
{
    public interface ICategoryRepository:IEntityRepository<Category>
    {

    }
}
