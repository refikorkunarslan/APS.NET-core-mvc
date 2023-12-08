using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SGK.Data;
using System;
using System.Linq;

namespace SGK.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SGKContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SGKContext>>()))
            {
                
                if (context.vtd.Any())
                {
                    return;   
                }

                context.vtd.AddRange(
                    new vtd
                    {
                        Name = "orkun",
                        surname = "arslan",
                        TC = "1234546546543",
                        phone ="34235435435"
                    }

                
                );
                context.SaveChanges();
            }
        }
    }
}