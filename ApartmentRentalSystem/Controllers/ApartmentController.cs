using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApartmentRentalSystem.Data;
using ApartmentRentalSystem.Models.Apartment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApartmentRentalSystem.Controllers
{
    public class ApartmentController : Controller
    {

        private readonly ApplicationDbContext _db;
            
        public ApartmentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Apartments.ToList());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var apartment = await _db.Apartments.SingleOrDefaultAsync(a => a.Id == id);

            if (apartment == null) return NotFound();

            return View(apartment);
        }

        public IActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Appointment(Appointment appointment, int? id)
        {
            if (ModelState.IsValid)
            {

                _db.Appointments.Add(appointment);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("Appointment");
        }


        public IActionResult Message()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Message(Message message)
        {
            if (ModelState.IsValid)
            {

                _db.Messages.Add(message);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("Message");
        }

    }
}