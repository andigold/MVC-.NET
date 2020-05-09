using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UserRestaurnats3.Contacts;
using UserRestaurnats3.Entities;
using UserRestaurnats3.Models;
using UserRestaurnats3.Helpers;

namespace UserRestaurnats3.Controllers
{
    [Route("controller/[controller]")]
    public class HomeController : BaseController
    {
        public IRepository _repository;

        public HomeController(IRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login([FromForm] User loginUser)
        {
            List<User> users = _repository.GetAllUser();
            User user = users.FirstOrDefault(u => (u.Username == loginUser.Username) && (u.Password == loginUser.Password));
            if(user == null)
            {
                ViewBag.IncorrectLoginMessage = "Incorrect username or password";
                return View("login");
            }
            else
            {
                HttpContext.Session.Set(ProgramParameters.Identity, user.Identity.ToByteArray());
                return RedirectToAction("AllUserRestaurants");
            }

        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult HomePage()
        {
            //ViewBag["Identified"] = Identified; // Pass this to the view and use it to render the page, knowing
                                                // if the user has authenticated.
            List<RestaurantAndFoodsDto> listRAF = new List<RestaurantAndFoodsDto>();
            /*int userId = _repository.GetUserByIdentity(
                new Guid(HttpContext.Session.Get(ProgramParameters.Identity))).Id;*/
            List<Restaurant> restaurants = _repository.GetAllRestaurants();
            foreach (Restaurant restaurant in restaurants)
            {
                RestaurantAndFoodsDto restaurantAndFoods = new RestaurantAndFoodsDto();
                restaurantAndFoods.Restaurant = restaurant;
                List<Food> specificFood = _repository.GetFoodByRestaurantId(restaurant.Id);
                restaurantAndFoods.Foods = specificFood;
                listRAF.Add(restaurantAndFoods);
            }
            AllRestaurantsAndFoods allRestaurantsAndFoods = new AllRestaurantsAndFoods(listRAF);
            return View("Homepage", allRestaurantsAndFoods);
        }

        [HttpGet]
        [AuthorizeUser]
        [Route("[action]")]
        public IActionResult AllUserRestaurants()
        {
            List<RestaurantAndFoodsDto> listRAF = new List<RestaurantAndFoodsDto>();
            byte[] identity = HttpContext.Session.Get(ProgramParameters.Identity);
            if (identity != null)
            {
                User user = _repository.GetUserByIdentity(
                    new Guid(HttpContext.Session.Get(ProgramParameters.Identity)));
                int userId = user.Id;
                List<Restaurant> restaurants = _repository.GetRestaurantsByUserId(userId);
                foreach (Restaurant restaurant in restaurants)
                {
                    RestaurantAndFoodsDto restaurantAndFoods = new RestaurantAndFoodsDto();
                    restaurantAndFoods.Restaurant = restaurant;
                    List<Food> specificFood = _repository.GetFoodByRestaurantId(restaurant.Id);
                    restaurantAndFoods.Foods = specificFood;
                    listRAF.Add(restaurantAndFoods);
                }
                AllRestaurantsAndFoods allRestaurantsAndFoods = new AllRestaurantsAndFoods(listRAF);
                return View("MyRestaurants", allRestaurantsAndFoods);
            }
            else
            {
                return View("Login");
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateUser([FromForm] User user)
        {
            if (_repository.CreateUser(user))
            {
                return View("CreateUser", user);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult CreateRestaurant()
        {
            //return Ok(_repository.Test());
            List<User> allUsers = _repository.GetAllUser();
            IEnumerable<SelectListItem> users = new SelectList(allUsers, "Id", "Id", 0);
            ViewBag.UserId = users;
            return View();
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateRestaurant([FromForm] Restaurant restaurant)
        {

            if(_repository.CreateRestaurant(restaurant))
            { 
}
            return View("CreateRestaurant", restaurant);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult CreateFood()
        {
            List<Restaurant> allRestaurants = _repository.GetAllRestaurants();
            IEnumerable<SelectListItem> restaurants = new SelectList(allRestaurants, "Id", "Name", 0);
            ViewBag.RestaurantId = restaurants;
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateFood([FromForm] Food food)
        {
            if(_repository.CreateFood(food))
            {

            }

            return View("CreateFood", food);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
