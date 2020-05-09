using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRestaurnats3.Contacts;
using UserRestaurnats3.Helpers;

namespace UserRestaurnats3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        IRepository _repository;

        public BaseController(IRepository repository) :base()
        {
            _repository = repository;
        }

        public bool Identified { get; set; }
    }
}