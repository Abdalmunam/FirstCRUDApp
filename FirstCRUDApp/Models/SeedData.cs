using FirstCRUDApp.Data;
using FirstCRUDApp.Models;
using Microsoft.EntityFrameworkCore;
using FirstCRUDApp.Data;
namespace FirstCRUDApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FirstCRUDAppContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<FirstCRUDAppContext>>()))
            {
                // Look for any students.
                if (context.Student.Any())
                {
                    return; // DB has been seeded
                }
                context.Student.AddRange(
                new Student
                {
                    Name = "Alice Smith",
                    Age = 30,
                    Email = "alice.smith@example.com",
                    Address = "123 Maple Street, Springfield, IL",
                    PhoneNumber = "555-1234"
                },
                new Student
                {
                    Name = "Bob Johnson",
                    Age = 45,
                    Email = "bob.johnson@example.com",
                    Address = "456 Oak Avenue, Metropolis, NY",
                    PhoneNumber = "555-5678"
                }, new Student
                {
                    Name = "Charlie Brown",
                    Age = 28,
                    Email = "charlie.brown@example.com",
                    Address = "789 Pine Road, Smalltown, TX",
                    PhoneNumber = "555-8765"
                }, new Student
                {
                    Name = "Diana Prince",
                    Age = 35,
                    Email = "diana.prince@example.com",
                    Address = "101 Elm Street, Gotham, NJ",
                    PhoneNumber = "555-4321"
                }, new Student
                {
                    Name = "Ethan Hunt",
                    Age = 40,
                    Email = "ethan.hunt@example.com",
                    Address = "202 Cedar Boulevard, Star City, CA",
                    PhoneNumber = "555-1357"
                }
                );
                context.SaveChanges();
            }
        }
    }
}