using ArageekWebsite.Models;
using ArageekWebsite.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArageekWebsite.Controllers
{
    public class ArticalController : Controller
    {
        private readonly IArtical articalRepo;
        private readonly UserManager<IdentityUser> userManager;

        public ArticalController(IArtical _articalRepo, UserManager<IdentityUser> _UserManager)
        {
            articalRepo = _articalRepo;
            userManager = _UserManager;
        }
        public IActionResult Index()
        {
            Artical artical = new Artical();
            articalRepo.Add(artical, userManager.GetUserId(User));
            return View();
        }
    }
}
