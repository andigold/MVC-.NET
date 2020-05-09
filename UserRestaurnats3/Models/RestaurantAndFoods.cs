using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRestaurnats3.Entities;

namespace UserRestaurnats3.Models
{
    public class RestaurantAndFoodsDto
    {
        public Restaurant Restaurant { get; set; }
        public List<Food> Foods { get; set; }
    }
}
