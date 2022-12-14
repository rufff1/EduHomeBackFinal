using EduHome.Dal;
using EduHome.Extensions;
using EduHome.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;
        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Teachers.Count() / 3);
            ViewBag.CurrentPage = page;


            IEnumerable<Teacher> teachers = await _context.Teachers
                .Include(t=> t.TeacherHobbies).ThenInclude(th=> th.Hobbie)
                .Include(t=> t.TeacherPosition)
                .Include(t=> t.TeacherSkills).ThenInclude(ts=> ts.Skill)
                .Where(t => t.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToListAsync();
                
            
            return View(teachers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.TeacherSkills = await _context.Skills.Where(s => s.IsDeleted == false).ToListAsync();
            ViewBag.TeacherHobbies = await _context.Hobbies.Where(h => h.IsDeleted == false).ToListAsync();
            ViewBag.TeacherPosition = await _context.TeacherPositions.Where(h => h.IsDeleted == false).ToListAsync();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            ViewBag.TeacherSkills = await _context.Skills.Where(s => s.IsDeleted == false).ToListAsync();
            ViewBag.TeacherHobbies = await _context.Hobbies.Where(h => h.IsDeleted == false).ToListAsync();
            ViewBag.TeacherPosition = await _context.TeacherPositions.Where(h => h.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {

                return View();
            }

            if (!await _context.Teachers.AnyAsync(t => t.IsDeleted == false && t.Id == teacher.TeacherPositionId))
            {
                ModelState.AddModelError("TeacherPositionId", "gelen position yalnisdir");
                return View(teacher);
            }


            if (teacher.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "Image daxil edin");
                return View();
            }

            if (!teacher.ImageFile.CheckFileSize(1000))
            {
                ModelState.AddModelError("ImageFile", "Image olcusu 1mb cox olmamalidir");
                return View();
            }
            if (!teacher.ImageFile.CheckFileType("image/jpeg"))
            {
                ModelState.AddModelError("ImageFile", "image jpeg tipinnen fayl secin! ");
                return View();
            }


            teacher.Image = teacher.ImageFile.CreateImage(_env, "assets/img/teacher");
            teacher.CreatBy = "System";
            teacher.CreatAt = DateTime.UtcNow.AddHours(4);
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();



            return RedirectToAction("Index");

            
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id bos ola bilmez");
            }

            Teacher teacher = await _context.Teachers
                .Include(t=>t.TeacherPosition)
                .Include(t => t.TeacherHobbies).ThenInclude(th=> th.Hobbie)
                .Include(t => t.TeacherSkills).ThenInclude(ts=>ts.Skill)
                .FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);


            if (teacher == null)
            {
                return NotFound("Daxil edilen Id yalnisdir");
            }

            return View(teacher);
        }

    }
}
