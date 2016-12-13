using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;

namespace WebApplication03.Controllers
{
    public class StudentssssesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentssssesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Studentsssses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Studentssss.ToListAsync());
        }

        // GET: Studentsssses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentssss = await _context.Studentssss.SingleOrDefaultAsync(m => m.Studentss == id);
            if (studentssss == null)
            {
                return NotFound();
            }

            return View(studentssss);
        }

        // GET: Studentsssses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentsssses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Studentss,Name")] Studentssss studentssss)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentssss);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(studentssss);
        }

        // GET: Studentsssses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentssss = await _context.Studentssss.SingleOrDefaultAsync(m => m.Studentss == id);
            if (studentssss == null)
            {
                return NotFound();
            }
            return View(studentssss);
        }

        // POST: Studentsssses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Studentss,Name")] Studentssss studentssss)
        {
            if (id != studentssss.Studentss)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentssss);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentssssExists(studentssss.Studentss))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(studentssss);
        }

        // GET: Studentsssses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentssss = await _context.Studentssss.SingleOrDefaultAsync(m => m.Studentss == id);
            if (studentssss == null)
            {
                return NotFound();
            }

            return View(studentssss);
        }

        // POST: Studentsssses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentssss = await _context.Studentssss.SingleOrDefaultAsync(m => m.Studentss == id);
            _context.Studentssss.Remove(studentssss);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool StudentssssExists(int id)
        {
            return _context.Studentssss.Any(e => e.Studentss == id);
        }
    }
}
