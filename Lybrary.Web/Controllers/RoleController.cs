using Lybrary.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lybrary.Web.Controllers
{
    public class RoleController : Controller
    {

        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }



        // GET: Role
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        // GET: Role/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View();
        }



        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            context.Roles.Find(id);
            return View();
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name")] IdentityRole Role)
        {
        
                context.Entry(Role).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
           
        }

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            IdentityRole Role = context.Roles.Find(id);
            return View();
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            IdentityRole role = context.Roles.Find(id);
            context.Roles.Remove(role);
            context.SaveChanges();
            return RedirectToAction("Index");
         

        }
    }
}
