using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Business.ProjectCategoryModule;
using MyResume.Domain.Models.DataContexts;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "sa")]
    public class ProjectCategoriesController : Controller
    {
        private readonly MyResumeDbContext db;
        private readonly IMediator mediator;

        public ProjectCategoriesController(MyResumeDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/ProjectCategories
        public async Task<IActionResult> Index(ProjectCategoryGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/ProjectCategories/Details/5
        public async Task<IActionResult> Details(ProjectCategoryGetSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/ProjectCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectCategoryCreateCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/ProjectCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectCategory = await db.ProjectCategories.FindAsync(id);
            if (projectCategory == null)
            {
                return NotFound();
            }
            return View(projectCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProjectCategoryEditCommand command)
        {

            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/ProjectCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectCategory = await db.ProjectCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectCategory == null)
            {
                return NotFound();
            }

            return View(projectCategory);
        }

        // POST: Admin/ProjectCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ProjectCategoryRemoveCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));

        }

        private bool ProjectCategoryExists(int id)
        {
            return db.ProjectCategories.Any(e => e.Id == id);
        }
    }
}

