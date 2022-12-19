using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.AppCode.Services;
using MyResume.Domain.Business.ContactPostModule;
using MyResume.Domain.Models.DataContexts;
using System.Threading.Tasks;

namespace MyResume.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "sa")]
    public class ContactPostsController : Controller
    {
        private readonly MyResumeDbContext db;
        private readonly IMediator mediator;
        private readonly CryptoService crypto;
        private readonly EmailService emailService;

        public ContactPostsController(MyResumeDbContext db, IMediator mediator, CryptoService crypto, EmailService emailService)
        {
            this.db = db;
            this.mediator = mediator;
            this.crypto = crypto;
            this.emailService = emailService;
        }

        // GET: Admin/ContactPosts
        public async Task<IActionResult> Index(ContactPostGetAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        public async Task<IActionResult> Details(ContactPostGetSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }
            return View(response);
        }

        // GET: Admin/ContactPosts/Edit/5
        public async Task<IActionResult> Answer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await db.ContactPosts.FirstOrDefaultAsync(cp => cp.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }
            var answerCommand = new ContactPostEditCommand();
            answerCommand.Id = contactPost.Id;
            answerCommand.Answer = contactPost.Answer;
            answerCommand.Email = contactPost.Email;
            return View(contactPost);
        }

        // POST: Admin/ContactPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Answer(int id, ContactPostEditCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            await emailService.SendMailAsync(command.Email, "Answer by Admin", command.Answer);

            if (response.Error == false)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }

        // POST: Admin/ContactPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, ContactPostDeleteCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
    }
}
