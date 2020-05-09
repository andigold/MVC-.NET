using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRestaurnats3.Entities;

namespace UserRestaurnats3.Contacts
{
    public interface IRepository
    {
         bool CreateUser(User user);

         bool CreateRestaurant(Restaurant restaurant);

        bool CreateFood(Food food);
        List<Restaurant> Test();

        List<User> GetAllUser();
        List<Restaurant> GetRestaurantsByUserId(int id);
        List<Food> GetFoodsByRestaurantId(int id);
        List<Food> GetFoodByRestaurantId(int rid);
        bool IsUserAuthenticated(byte[] userIdentity);
        User GetUserByIdentity(Guid guid);
        List<Restaurant> GetAllRestaurants();
    }
}
