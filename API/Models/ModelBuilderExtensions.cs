using Microsoft.EntityFrameworkCore;


namespace API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Furniture" },
                new Category { Id = 2, Name = "Mirrors" },
                new Category { Id = 3, Name = "Cupboard" },
                new Category { Id = 4, Name = "Light bulb" },
                new Category { Id = 5, Name = "Showpieces" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Sectional Sofa", Sku = "AWMGSJ", Price = 95520, IsAvailable = true },
                new Product { Id = 2, CategoryId = 1, Name = "Recliner Sofa", Sku = "AWMPS", Price = 50250, IsAvailable = true },
                new Product { Id = 3, CategoryId = 1, Name = "Chesterfield", Sku = "AWMSGT", Price = 43390, IsAvailable = true },
                new Product { Id = 4, CategoryId = 1, Name = "Loveseat Sofa", Sku = "AWMSJ", Price = 50000, IsAvailable = true },
                new Product { Id = 5, CategoryId = 1, Name = "Lawson Couch", Sku = "AWMTFJ", Price = 60060, IsAvailable = true },
                new Product { Id = 6, CategoryId = 1, Name = "Settee Sofa", Sku = "AWMUTV", Price = 95090, IsAvailable = true },
                new Product { Id = 7, CategoryId = 1, Name = "Cabriole", Sku = "AWMVNP", Price = 65560, IsAvailable = true },
                new Product { Id = 8, CategoryId = 1, Name = "Mid-century Modern Sofa", Sku = "AWMVNS", Price = 65000, IsAvailable = true },
                new Product { Id = 9, CategoryId = 1, Name = "Low-seated Sofa", Sku = "AWMVNT", Price = 81700, IsAvailable = true },
                new Product { Id = 10, CategoryId = 2, Name = "Plane Mirror", Sku = "AWWBTSC", Price = 1399, IsAvailable = true },
                new Product { Id = 11, CategoryId = 2, Name = "Concave Mirror", Sku = "AWWCTT", Price = 2400, IsAvailable = false },
                new Product { Id = 12, CategoryId = 2, Name = "Convex Mirror", Sku = "AWWGSJ", Price = 6800, IsAvailable = true },
                new Product { Id = 13, CategoryId = 2, Name = "Non-Reversing Mirror", Sku = "AWWSJ", Price = 1400, IsAvailable = true },
                new Product { Id = 14, CategoryId = 2, Name = "Two-Way Mirror", Sku = "AWWSDP", Price = 2550, IsAvailable = true },
                new Product { Id = 15, CategoryId = 2, Name = "Mounted Mirror", Sku = "AWDP", Price = 1550, IsAvailable = true },
                new Product { Id = 16, CategoryId = 2, Name = "Traditional Full-Length Mirror", Sku = "AAWSJ", Price = 4125, IsAvailable = true },
                new Product { Id = 17, CategoryId = 2, Name = "Freestanding Full-Length Mirror", Sku = "AWWDP", Price = 2550, IsAvailable = true },
                new Product { Id = 18, CategoryId = 3, Name = "Raised Panel Kitchen Cabinets", Sku = "MWB", Price = 30000, IsAvailable = true },
                new Product { Id = 19, CategoryId = 3, Name = "Shaker Kitchen Cabinets", Sku = "MWLL", Price = 40000, IsAvailable = true },
                new Product { Id = 20, CategoryId = 3, Name = "Flat-Panel Cabinets", Sku = "MWO", Price = 25000, IsAvailable = true },
                new Product { Id = 21, CategoryId = 3, Name = "Inset Cabinets", Sku = "MWP", Price = 24000, IsAvailable = true },
                new Product { Id = 22, CategoryId = 3, Name = "Distressed Cabinets", Sku = "MWR", Price = 31080, IsAvailable = true },
                new Product { Id = 23, CategoryId = 3, Name = "Beadboard Cabinets", Sku = "MWS", Price = 23590, IsAvailable = true },
                new Product { Id = 24, CategoryId = 4, Name = "LED bulb", Sku = "PITK", Price = 185, IsAvailable = true },
                new Product { Id = 25, CategoryId = 4, Name = "Fluorescent tube", Sku = "PKTK", Price = 700, IsAvailable = true },
                new Product { Id = 26, CategoryId = 4, Name = "Mercury Lamp", Sku = "PMTK", Price = 4980, IsAvailable = true },
                new Product { Id = 27, CategoryId = 4, Name = "Fluorescent Lamp", Sku = "PITK", Price = 815, IsAvailable = true },
                new Product { Id = 28, CategoryId = 4, Name = "Spotlight Bulbs", Sku = "IPTO", Price = 290, IsAvailable = true },
                new Product { Id = 29, CategoryId = 4, Name = "Dimmer Switch", Sku = "TKOP", Price = 500, IsAvailable = true },
                new Product { Id = 30, CategoryId = 4, Name = "Flame-Shaped Bulb", Sku = "KNOT", Price = 5000, IsAvailable = true },
                new Product { Id = 31, CategoryId = 5, Name = "Tied Ribbons", Sku = "FTYU", Price = 700, IsAvailable = true },
                new Product { Id = 32, CategoryId = 5, Name = "Golden Peacock", Sku = "SFUIP", Price = 700, IsAvailable = true },
                new Product { Id = 33, CategoryId = 5, Name = "Teady Bears", Sku = "SJFT", Price = 800, IsAvailable = true },
                new Product { Id = 34, CategoryId = 5, Name = "Flower Vase", Sku = "SMIOT", Price = 300, IsAvailable = true },
                new Product { Id = 35, CategoryId = 5, Name = "Diy Wall Showpiece", Sku = "SMV", Price = 6000, IsAvailable = true },
                new Product { Id = 36, CategoryId = 5, Name = "Book Case", Sku = "SVA", Price = 5500, IsAvailable = true },
                new Product { Id = 37, CategoryId = 5, Name = "Paper Showcase", Sku = "SVB", Price = 1290, IsAvailable = true },
                new Product { Id = 38, CategoryId = 5, Name = "Smell Candels", Sku = "SVC", Price = 900, IsAvailable = true });


        }
    }
}

