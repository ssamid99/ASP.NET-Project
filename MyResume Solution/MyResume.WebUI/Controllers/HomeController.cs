using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.AppCode.Extensions;
using MyResume.Domain.Business.AboutModule;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using MyResume.Domain.Models.ViewModels;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly MyResumeDbContext db;
        private readonly IMediator mediator;

        public HomeController(MyResumeDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(AboutGetAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        public IActionResult Resume()
        {
            return View();
        }

        public async Task<IActionResult> Portfolio(PortfolioViewModel model)
        {
            var projectCategories = await db.ProjectCategories.Where(pc => pc.DeletedDate == null).ToListAsync();

            var projects = await db.Projects.Where(c => c.DeletedDate == null).ToListAsync();

            return View(new PortfolioViewModel
            {
                ProjectCategories = projectCategories,
                Projects = projects
            });
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactPost model)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(model);
                db.SaveChanges();

                var response = new
                {
                    error = false,
                    message = "Muracietiniz qeyde alindi. Tezlikle geri donush edilecek."
                };
                return Json(response);
            }

            var responseError = new
            {
                error = true,
                message = "Melumatlar uygun deyil. Duzelish edib yeniden yoxlayin",
                state = ModelState.GetError()
            };

            return Json(responseError);
        }

        public IActionResult Pdf()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Export(string GridHtml)
        {

            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Grid.pdf");
            }
        }
    }
}
