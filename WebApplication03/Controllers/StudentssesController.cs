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
    public class StudentssesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentssesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Studentsses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Studentss.ToListAsync());
        }

        // GET: Studentsses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentss = await _context.Studentss.SingleOrDefaultAsync(m => m.StudentssID == id);
            if (studentss == null)
            {
                return NotFound();
            }

            return View(studentss);
        }

        // GET: Studentsses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentsses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentssID,Name")] Studentss studentss)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentss);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(studentss);
        }

        // GET: Studentsses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentss = await _context.Studentss.SingleOrDefaultAsync(m => m.StudentssID == id);
            if (studentss == null)
            {
                return NotFound();
            }
            return View(studentss);
        }

        // POST: Studentsses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentssID,Name")] Studentss studentss)
        {
            if (id != studentss.StudentssID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentss);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentssExists(studentss.StudentssID))
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
            return View(studentss);
        }

        // GET: Studentsses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentss = await _context.Studentss.SingleOrDefaultAsync(m => m.StudentssID == id);
            if (studentss == null)
            {
                return NotFound();
            }

            return View(studentss);
        }

        // POST: Studentsses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentss = await _context.Studentss.SingleOrDefaultAsync(m => m.StudentssID == id);
            _context.Studentss.Remove(studentss);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool StudentssExists(int id)
        {
            return _context.Studentss.Any(e => e.StudentssID == id);
        }
    }
}
