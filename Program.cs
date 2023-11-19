using SupermarketEF.Data;
using SupermarketEF.Models;

namespace SupermarketEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SupermarketContext context = new SupermarketContext();

            Category oilCategory = new Category()
            {
                Name = "Oil",
                Description = "Oil Category"
            };

            context.Categories.Add(oilCategory);

            Category grainsCategory = new Category()
            {
                Name = "Grains",
                Description = "Grains Category"
            };

            //context.Add(grainsCategory);

            //context.SaveChanges();
            var grainCategory = context.Categories
                .Where(p => p.Name == "Grains")
                .FirstOrDefault();
            if (grainCategory is Category)
            {
                grainCategory.Description = "New description Applied";
                context.Remove(grainCategory);
            }
            context.SaveChanges();

            var categories = context.Categories.OrderBy(p => p.Name);

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Name} | {category.Description}");
            }
        }
    }
}