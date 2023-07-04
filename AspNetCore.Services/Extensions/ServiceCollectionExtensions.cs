using AspNetCoreBlog.Data.Abstract;
using AspNetCoreBlog.Data.Concrete;
using AspNetCoreBlog.Data.Concrete.EntityFramework.Contexts;
using AspNetCoreBlog.Services.Abstract;
using AspNetCoreBlog.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AspNetCoreBlogContext>();
            serviceCollection.AddScoped<IUnitOfWork,UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService,CategoryManager>();
            serviceCollection.AddScoped<IArticleService,ArticleManager>();
            return serviceCollection;
        } 
    }
}
