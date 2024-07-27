using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class MealListViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<Food> Foods { get; set; }
        public List<Fastfood> Fastfoods { get; set; }
    }
}
