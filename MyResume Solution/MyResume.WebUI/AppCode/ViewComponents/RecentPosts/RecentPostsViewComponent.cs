using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyResume.Domain.Business.BlogPostModule;
using System.Threading.Tasks;

namespace MyResume.WebUI.AppCode.ViewComponents.RecentPosts
{
    public class RecentPostsViewComponent : ViewComponent
    {
    
        private readonly IMediator mediator;

        public RecentPostsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new BlogPostRecentQuery() { Size = 3 };
            var posts = await mediator.Send(query);

            return View(posts);
        }
    }
}
