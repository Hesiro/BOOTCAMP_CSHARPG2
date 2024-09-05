﻿using Microsoft.AspNetCore.Mvc;
using MVC_Razor.Data;
using MVC_Razor.Models;

namespace MVC_Razor.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ContactController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Contact> listContact = _appDbContext.Contacts.ToList();
            return View(listContact);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid) {
                contact.CreationDate = DateTime.Now;
                _appDbContext.Contacts.Add(contact);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id) {
            if (id == null)
            {
                return NotFound();
            }

            Contact contact = _appDbContext.Contacts.Find(id);
            if (contact == null) { 
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {                
                _appDbContext.Update(contact);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Detail(int id) {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = _appDbContext.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        public IActionResult Privacy() { 
            return View();
        }
    }
}
