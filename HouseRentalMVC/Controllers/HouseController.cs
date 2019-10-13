using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseRentalMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRentalMVC.Controllers
{
    public class HouseController : Controller
    {

        private readonly ApplicationDbContext _db;

        public HouseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Houses.ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var house = await _db.Houses.SingleOrDefaultAsync(h => h.Id == id);

            if (house == null) return NotFound();

            return View(house);
        }
    }
}