using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Elegant_Sofas.Data;
using System;
using System.Linq;
using Elegant_Sofas.Controllers;
using Microsoft.AspNetCore.Identity;

namespace Elegant_Sofas.Models
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new Elegant_SofasContext(serviceProvider.GetRequiredService<DbContextOptions<Elegant_SofasContext>>());

            // Look for any sofas.
            if (context.Sofas.Any())
            {
                return;   // DB has been seeded
            }
#pragma warning restore CS8321 // Local function is declared but never used

            // If there are no sofas, add some sample data.
            context.Sofas.AddRange(
                new Sofas
                {
                    Product = "Sample Sofa",
                    Color = "Beige",
                    Material = "Fabric",
                    Price = 7.99M,
                    Rating = "3.5",
                }
            );

            context.SaveChanges();
        }

        }
    }

