﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PSS.Models;
using SGCO.Context;

namespace PSS.Controllers
{
    public class UsersController : Controller
    {
        private Context db = new Context();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Address)
                                .Include(u => u.Gender)
                                .Include(u => u.UserType)
                                .Where(u => u.IsActive == true);

            return View(users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Name");
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Description");
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LastName,CPF,Phone,Email,Birth,Password,UserTypeId,AddressId,GenderId,IsActive")] User user)
        {
            if (ModelState.IsValid)
            {
                user.IsActive = true;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Name", user.AddressId);
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Description", user.GenderId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description", user.UserTypeId);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Name", user.AddressId);
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Description", user.GenderId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description", user.UserTypeId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LastName,CPF,Phone,Email,Birth,Password,UserTypeId,AddressId,GenderId,IsActive")] User user)
        {
            if (ModelState.IsValid)
            {
                user.IsActive = true;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Name", user.AddressId);
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Description", user.GenderId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description", user.UserTypeId);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            user.IsActive = false;
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}