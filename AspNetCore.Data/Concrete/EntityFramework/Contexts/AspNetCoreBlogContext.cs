﻿using AspNetCore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreBlog.Data.Concrete.EntityFramework.Contexts
{
    public class AspNetCoreBlogContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }    
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=Blog;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }
    }
}