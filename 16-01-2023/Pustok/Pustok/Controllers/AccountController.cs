using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using Pustok.ViewModels.Member;

namespace Pustok.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly PustokContext _pustokContext;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,PustokContext pustokContext, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _pustokContext = pustokContext;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterViewModel memberRegisterVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser member = await _userManager.FindByNameAsync(memberRegisterVM.Username);

            if (member != null)
            {
                ModelState.AddModelError("Username", "Username has taken!");
                return View();
            }

            member = await _pustokContext.Users.FirstOrDefaultAsync(x => x.NormalizedEmail == memberRegisterVM.Email.ToUpper());
            //member = await _userManager.FindByEmailAsync(memberRegisterVM.Email);

            if (member != null)
            {
                ModelState.AddModelError("Email", "Email has taken!");
                return View();
            }

            member = new AppUser
            {
                Fullname = memberRegisterVM.Fullname,
                UserName = memberRegisterVM.Username,
                Email = memberRegisterVM.Email
            };

            var result = await _userManager.CreateAsync(member, memberRegisterVM.Password);
            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                    return View();
                }
            }

            var roleResult = await _userManager.AddToRoleAsync(member, "Member");

            if (!roleResult.Succeeded)
            {
                foreach (var err in roleResult.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                    return View();
                }
            }
            await _signInManager.SignInAsync(member, isPersistent: false);

            return RedirectToAction("index", "home");
        }
    }
}
