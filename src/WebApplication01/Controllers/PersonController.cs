﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication01.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication01.Controllers
{
    public class PersonController : Controller
    {
        // GET: /<controller>/
        private static Person _person = new Person
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            Birthday = DateTime.Now.AddYears(-30)
        };
        private static Student _student = new Student
        {
            StudentID =3            
        };

        public IActionResult Index()
        {
            return View(new PersonViewModel { Person = _person, Students = _student, PersonViewModelID=5 });
        }

        [HttpPost, ValidateAntiForgeryToken]
        // See variations above of what I have tried.
        //[Bind("Id", "FirstName", "LastName", "Birthday", Prefix = "Person")]
        public IActionResult Index(int id, [Bind("Id", "FirstName", "LastName", "Birthday", Prefix = "Person")] Person personmodel,[Bind("StudentID",Prefix="Students")] Student studentmodel,[Bind("Person,Students,PersonViewModelID")] PersonViewModel bigmodel)
        {

            //if (id != model.Person.Id)
            //    return NotFound();

            //if (ModelState.IsValid)
            //{
            //    _person = model.Person;
            //    return RedirectToAction("Index");
            //}

           return     RedirectToAction("Index");

        }
    }
}
