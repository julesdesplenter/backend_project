using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Invitor.Model;
using Invitor.Model.eventRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Invitor.Controller
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Person> _userManager;
        private readonly IEventRepo eventRepo;
        public AdminController(RoleManager<IdentityRole> roleMgr, UserManager<Person> userMgr,IEventRepo eventRepo)
        {
            this._userManager = userMgr;
            this._roleManager = roleMgr;
            this.eventRepo = eventRepo;

        }

        // GET: Admin
        public async Task<ActionResult> IndexAsync()
        {
            var result = await eventRepo.GetAllAsync();
            return View(result);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Event evente)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new Exception("Validation Error");
                }
                Event result = await eventRepo.Add(evente);
                if (result == null)
                    throw new Exception("Invalid Entry");
                return RedirectToAction(nameof(IndexAsync));
            }
            catch (Exception exc)
            {
                Debug.WriteLine("Create is unable to save." + exc.Message);
                ModelState.AddModelError("", "Create mislukt. " + exc.Message);
                return View(evente);
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult IndexUsers()
        {
            var users = _userManager.Users;
            return View(users); //De view ontvangt een @model IEnumerable<Person>
        }
        public ActionResult IndexRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles); //De view ontvangt een @model IEnumerable<IdentityRole>
        }
    }
}