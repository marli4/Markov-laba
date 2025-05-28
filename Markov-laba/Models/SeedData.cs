using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Markov_laba.Data;
using System;
using System.Linq;

namespace Markov_laba.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Markov_labaContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Markov_labaContext>>()))
        {
            // Look for any movies.
            if (!context.Client.Any())
            {
                context.Client.AddRange
                (
                    new Client
                    {
                        login = "biba123"
                    },
                    new Client
                    {
                        login = "sanyapro2006"
                    }
                );
            }
            if (!context.Client.Any())
            {
                context.Client.AddRange
                (
                    new Client
                    {
                        login = "biba123"
                    },
                    new Client
                    {
                        login = "sanyapro2006"
                    }
                );
            }
            if (!context.Restaurant.Any())
            {
                context.Restaurant.AddRange
                (
                    new Restaurant
                    {
                        name = "Макдоналдс",
                        adress = "Московское Шоссе 91А",
                        cuisine = "Американская"
                    },
                    new Restaurant
                    {
                        name = "Miruku",
                        adress = "Ул. Минаева 15",
                        cuisine = "Японская"
                    },
                    new Restaurant
                    {
                        name = "Додо-Пицца",
                        adress = "Ул. Гончарова 30",
                        cuisine = "Американская"
                    }
                );
            }
            if (!context.Courier.Any())
            {
                context.Courier.AddRange
                (
                    new Courier
                    {
                        login = "amirkiller2006"
                    },
                    new Courier
                    {
                        login = "alexandrPenskoy1488"
                    }
                );
            }
            else
            {
                return;
            }
            context.SaveChanges();
        }
    }
}
