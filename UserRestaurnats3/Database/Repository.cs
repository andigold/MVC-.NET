using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRestaurnats3.Contacts;
using UserRestaurnats3.Entities;

namespace UserRestaurnats3.Database
{
    public class Repository : IRepository
    {
        DataStorage _context;
        public Repository(DataStorage dataStorage)
        {
            _context = dataStorage;
        }

        public bool CreateRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return true;
        }

        public bool CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool CreateFood(Food food)
        {
            _context.Foods.Add(food);
            _context.SaveChanges();
            return true;
        }

        public List<Restaurant> Test() => _context.Restaurants.Where(x => x.UserId == 2).ToList();

        public List<User> GetAllUser()
        {
            var users_con = _context.Users;
            List<User> users = users_con.ToList();
            return users;
        }
        public List<Restaurant> GetRestaurantsByUserId(int id)
        {
            List<Restaurant> restaurants = _context.Restaurants.Where(x => x.UserId == id).ToList();
            return restaurants;
        }

        public List<Food> GetFoodsByRestaurantId(int id)
        {
            List<Food> foods = _context.Foods.Where(x => x.RestaurantId == id).ToList();
            return foods;
        }

        public List<Food> GetFoodByRestaurantId(int rid)
        {
            List<Food> foods = _context.Foods.Where(f => f.RestaurantId == rid).ToList();
            return foods;
        }

        public bool IsUserAuthenticated(byte[] userIdentity)
        {
            if (userIdentity != null)
            {
                return _context.Users.Any(u => u.Identity == new Guid(userIdentity));
            }
            else
            {
                return false;
            }
        }

        public User GetUserByIdentity(Guid guid)
            => _context.Users.Where(x => x.Identity == guid).SingleOrDefault();

        public List<Restaurant> GetAllRestaurants()
            => _context.Restaurants.ToList();
    }
}
