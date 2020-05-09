using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRestaurnats3.Models
{
    public class AllRestaurantsAndFoods
    {
        public List<RestaurantAndFoodsDto> RestaurantAndFoods { get; set; }

        public AllRestaurantsAndFoods(List<RestaurantAndFoodsDto> listRAF)
        {
            RestaurantAndFoods = listRAF;
        }
    }
}
