using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.AppCode.Extensions;
using MyResume.Domain.AppCode.Infrastructure;
using MyResume.Domain.Business.BlogPostModule;
using MyResume.Domain.Migrations;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using MyResume.Domain.Models.ViewModels;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly MyResumeDbContext db;
        private readonly IMediator mediator;

        public BlogController(MyResumeDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_PostsBody", response);
            }
            return View(response);
        }
        [HttpGet]
        [Route("/blog/{slug}")]

        public async Task<IActionResult> Details(BlogPostGetSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            return View(response);

            
        }

       
        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> Add(BlogPostCommentPostCommand command)
        {
            var response = await mediator.Send(command);
            if (response == null)
            {
                return NotFound();
            }
            return PartialView("_Comment", response);
        }
    }
}
