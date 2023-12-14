using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Core.Domain;
using ShopTARge22.Models.Accounts;
using System.Security.Claims;

namespace ShopTARge22.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountsController(

            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

       /*
         [HttpPost]
        [AllowAnonymous]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            //var redirectUrl = Url.Action()
            //  var properties = 

            //  retur
          //  return new ChallengeResult(provider, properties);
        }
       */

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallBack(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            LoginViewModel loginViewModel = new()
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if(remoteError!= null)
            {
                // ModelState.AddModelError(string.Empty, "Error loading external login information");
                return View("Login", loginViewModel);
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();

            if(info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information");
                return View("Login", loginViewModel);
            }

            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            ApplicationUser user = null;

            if(email != null)
            {
                user = await _userManager.FindByEmailAsync(email);

                if(user != null && !user.EmailConfirmed)
                {
                    //Modelstate jne
                    return View("Login", loginViewModel);
                }

            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);


            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                if(email != null)
                {
                    if(user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };

                        await _userManager.CreateAsync(user);

                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                        var confirMationLink = Url.Action("ConfirmEmail", "Accounts", new { userId = user.Id , token = token},Request.Scheme);

                        //logger


                        ViewBag.ErrorTitle = "Registration Successful";
                        ViewBag.ErrorMessage = "Before you can login, please confirm your email by clicking the confirm link we emailed you";

                        return View("Error");
                    }

                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                ViewBag.ErrorTitle = $"Email claim not receaved form: {info.LoginProvider}";
                ViewBag.ErrorMessange = "Please contact support at asd@mail.com";

                return View("Error");
            }


        }



        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User);
            var userHasPassword = await _userManager.HasPasswordAsync(user);

            if (userHasPassword)
            {
                return RedirectToAction("AddPassword");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                if(user == null)
                {

                    return RedirectToAction("Login");

                }

                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);


                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View();
                }

                await _signInManager.RefreshSignInAsync(user);
                return View("ChangePasswordConfirmation");

            }

            return View(model);

        }


        [HttpGet]
        public async Task<IActionResult> AddPassword()
        {

            var user = await _userManager.GetUserAsync(User);
            var userHasPassword = await _userManager.HasPasswordAsync(user);

            if (userHasPassword)
            {
                RedirectToAction("ChangePassword");
            }

            return View();
        }

        //mingi error
        [HttpPost]
        public async Task<IActionResult> AddPassword(AddPasswordViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var result = _userManager.AddPasswordAsync(user, model.NewPassword);


                if (!result.IsCompleted)
                {
                    /*foreach(var error in result.Errors)
                    {

                        ModelState.AddModelError(string.Empty, error.Description);
                    }*/
                    return View(result);

                }

                await _signInManager.RefreshSignInAsync(user);
                return View("AddPasswordConfirmation");
            }


            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassWord(string token, string email)
        {
            if (token == null || email == null )
            {

            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {

            if(ModelState.IsValid)
            {

                var user = await _userManager.FindByEmailAsync(model.Email);

                if(user!= null)
                {

                    var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

                    if (result.Succeeded)
                    {

                        if (await _userManager.IsLockedOutAsync(user))
                        {
                            await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.UtcNow);
                        }

                        return View("ResetPasswordConfirmation");

                    }

                   /* foreach ()
                    {

                    }*/
                    return View(model);
                }
                return View("ResetPasswordConfirmation");

            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if(user!= null && await _userManager.IsEmailConfirmedAsync(user))
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordResetLink = Url.Action("ResetPassword", "Accounts", new { email = model.Email, token = token });
                    //logger
                    return View("ForgotPassWordConfirmation");
                }
                return View("ForgotPassWordConfirmation");
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            //logout
            //returnib home index vaatele.
            await _signInManager.SignOutAsync();
            return RedirectToAction("Home", "View");

        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if(ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    City= model.City
                };
            

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmationLink = Url.Action("ConfirmEmail", "Accounts", new { userId = user.Id, token = token }, Request.Scheme);

                    if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Administrations");
                    }
                    ViewBag.Errortitle = "Registration Successful";
                    ViewBag.ErrorMessage = "..";
                    return View("Error");

                }
            }

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"The use Id {userId} is not valid";
                return View("NotFound");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                return View();
            }

            ViewBag.ErrorTitle = "Email cannot be confirmed";
            return View("Error");

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            LoginViewModel vm = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user != null && !user.EmailConfirmed && (await _userManager.CheckPasswordAsync(user, model.Password)))
                {
                    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                    return View(model);
                }

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index, Home");
                    }

                }

                if (result.IsLockedOut)
                {
                    return View("AccountLocked");
                }

               
            }
            return View("LoginSuccessful");
        }
        }

   
    }

