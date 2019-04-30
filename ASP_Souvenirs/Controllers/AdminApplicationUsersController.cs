using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Souvenirs.Data;
using ASP_Souvenirs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_Souvenirs.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminApplicationUsersController : Controller
    {
        private ApplicationDbContext _application;

        public AdminApplicationUsersController(ApplicationDbContext application)
        {
            _application = application;
        }

        public IActionResult Index()
        {
            return View(_application.Users.ToList());
        }

    }
}