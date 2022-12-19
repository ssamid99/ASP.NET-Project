using MyResume.Domain.AppCode.Extensions;
using MyResume.Domain.AppCode.Services;
using MyResume.Domain.Models.Entities.Membership;
using MyResume.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<MyResumeUser> signInManager;
        private readonly UserManager<MyResumeUser> userManager;
        private readonly EmailService emailService;

        public AccountController(SignInManager<MyResumeUser> signInManager, UserManager<MyResumeUser> userManager, EmailService emailService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailService = emailService;
        }

        [AllowAnonymous]
        [Route("/signin.html")]
        public IActionResult Signin()
        {
            return View();
        }

        [Route("/signin.html")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Signin(LoginFormModel user)
        {
            MyResumeUser foundedUser = null;

            if (user.UserName == null || user.Password == null)
            {
                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }


            if (user.UserName.IsEmail())
            {
                foundedUser = await userManager.FindByEmailAsync(user.UserName);
            }
            else
            {
                foundedUser = await userManager.FindByNameAsync(user.UserName);
            }



            if (foundedUser == null)
            {
                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            if (foundedUser.EmailConfirmed == false)
            {
                ViewBag.Message = "Zəhmət olmasa emailinizə gələn təsdiq linkindən hesabınızı doğrulayın";
                goto end;
            }

            var signInResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);

            if (!signInResult.Succeeded)
            {
                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            var callbackUrl = Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(callbackUrl))
            {
                return Redirect(callbackUrl);
            }
            return RedirectToAction("Index", "Home");

        end:
            return View(user);
        }

        [AllowAnonymous]
        [Route("/register.html")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("/register.html")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new MyResumeUser();

                user.Email = model.Email;
                user.UserName = model.Email;
                user.Name = model.Name;
                user.Surname = model.Surname;
                //user.EmailConfirmed = true;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string path = $"{Request.Scheme}://{Request.Host}/registration-confirm.html?email={user.Email}&token={token}";

                    var emailResponse = await emailService.SendMailAsync(user.Email, "Registration for MyResume.com", $"Abuneliyinizi <a href='{path}'>link</a> vasitesile tesdiq edin");

                    if (emailResponse)
                    {
                        ViewBag.Message = "Qeydiyyat uğurla tamamlandı";
                    }
                    else
                    {
                        ViewBag.Message = " E-mail' göndərərkən xəta baş verdi, zəhmət olmasa yenidən cəhd edin";
                    }

                    await userManager.AddToRoleAsync(user, "user");
                    await signInManager.SignInAsync(user, false);

                    return RedirectToAction(nameof(Signin));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }

            return View(model);

        }

        [Route("registration-confirm.html")]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterConfirm(string email, string token)
        {
            var foundedUser = await userManager.FindByEmailAsync(email);
            if (foundedUser == null)
            {
                ViewBag.Message = "Xetalı token";
                goto end;
            }
            token = token.Replace(" ", "+");
            var result = await userManager.ConfirmEmailAsync(foundedUser, token);

            if (!result.Succeeded)
            {
                ViewBag.Message = "Xetalı token";
                goto end;
            }

            ViewBag.Message = "Hesabiniz Tesdiqlendi";
        end:
            return RedirectToAction(nameof(Signin));
        }


        [Route("/logout.html")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "home");
        }
    }
}