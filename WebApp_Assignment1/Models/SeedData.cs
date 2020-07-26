using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebApp_Assignment1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.
                GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.uResponses.Any())
            {
                context.uResponses.AddRange(
                    new UResponse
                    {
                        Name = "Pawan",
                        EmailID = "pawan234@gmail.com",
                        Message = "Nice job done for front end servcies",
                        PhoneNumber = "(432) 907-7890"
                    },
                    new UResponse
                    {
                        Name = "Adam",
                        EmailID = "Adam234@gmail.com",
                        Message = "We need services for mobile app",
                        PhoneNumber = "(432) 687-7980"
                    },
                    new UResponse
                    {
                        Name = "Kiya",
                        EmailID = "kiya234@gmail.com",
                        Message = "We need assistance for UI Design",
                        PhoneNumber = "(432) 677-8980"
                    }, new UResponse
                    {
                        Name = "Liza",
                        EmailID = "Liza234@gmail.com",
                        Message = "We want to hire you to modify our app",
                        PhoneNumber = "(432) 687-7980"
                    }
                    );
                context.SaveChanges();
            }
        }

    }
}
