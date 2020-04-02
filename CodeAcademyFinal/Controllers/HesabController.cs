using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using CodeAcademyFinal.Utilities;
using CodeAcademyFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CodeAcademyFinal.Controllers
{
    public class HesabController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;
        private string fileName;
        public HesabController(RentEstateDb context,
                               IConfiguration configuration,
                               IHostingEnvironment env,
                               UserManager<CustomUser> userManager,
                               SignInManager<CustomUser> signInManager
                               )
        {
            _context = context;
            _configuration = configuration;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Qeydiyyat()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Menimhesabim", "Hesab");
            }

            ViewBag.MobileOperators = _context.MobileOperators;
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Qeydiyyat(RegisterViewModel registerViewModel)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Menimhesabim", "Hesab");
            }

            MobileOperator mobileOperatorFromDb = _context.MobileOperators.FirstOrDefault(mo => mo.Id == registerViewModel.MobileOperatorId);

            if (!ModelState.IsValid)
            {
                ViewBag.MobileOperators = _context.MobileOperators;
                return View(registerViewModel);
            }

            if (registerViewModel.UploadFile == null)
            {
                ViewBag.MobileOperators = _context.MobileOperators;
                ModelState.AddModelError("", "Zəhmət olmasa, şəkil yükləyin");
                return View(registerViewModel);
            }

            CustomUser customUser = new CustomUser
            {
                FirstName = registerViewModel.FirstName.Trim(),
                UserName = registerViewModel.Email.Trim(),
                Email = registerViewModel.Email.Trim(),
                MobileOperatorId = registerViewModel.MobileOperatorId,
                PhoneNumber = mobileOperatorFromDb.MobileOperatorCode + registerViewModel.PhoneNumber.Trim()
            };

            if (registerViewModel.LastName != null)
            {
                customUser.LastName = registerViewModel.LastName.Trim();
            }

            IdentityResult result = await _userManager.CreateAsync(customUser, registerViewModel.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Bu email artıq qeydiyyatdan keçirilib və ya şifrə tələblərə uyğun deyil.");
                ViewBag.MobileOperators = _context.MobileOperators;
                return View(registerViewModel);
            }

            if (registerViewModel.UploadFile.ContentType.Contains("image/jpg") || registerViewModel.UploadFile.ContentType.Contains("image/jpeg"))
            {
                if(registerViewModel.UploadFile.Length > (2 * 1024 * 1024))
                {
                    await _userManager.DeleteAsync(customUser);
                    await _context.SaveChangesAsync();
                    ViewBag.MobileOperators = _context.MobileOperators;
                    ModelState.AddModelError("", "Şəklin həcmi 2MB'dan çox ola bilməz.");
                    return View(registerViewModel);
                }

                string folderPath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "users");
                fileName = Guid.NewGuid().ToString() + "_istifadechi_" + registerViewModel.UploadFile.FileName;
                string filePath = Path.Combine(folderPath, fileName);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await registerViewModel.UploadFile.CopyToAsync(fileStream);
                }
                customUser.ProfilePictureURL = fileName;
            }
            else
            {
                await _userManager.DeleteAsync(customUser);
                await _context.SaveChangesAsync();
                ViewBag.MobileOperators = _context.MobileOperators;
                ModelState.AddModelError("", "Zəhmət olmasa, tələb olunan formatda şəkil yükləyin");
                return View(registerViewModel);
            }

            await _userManager.AddToRoleAsync(customUser, "İstifadəçi");
            await _context.SaveChangesAsync();

            string emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(customUser);

            #region Sending Email Confirmation Message
            string messageSubject = "Hesabın təsdiqlənməsi";
            string messageBody = $"<table style='width:100%;background-color:#292C34;padding:50px'><thead style ='width:100%;display:flex;justify-content:center;'><tr style ='width:100%;display:flex;justify-content:center;'><th style ='width:100%;color:#F9F9F9;font-family:Roboto, sans-serif;font-weight:400;font-size:50px'>Kirayemlak.az</th></tr><thead><tbody><tr><td style ='padding:30px 0px;color:#888888;font-family:Roboto Condensed, sans-serif;font-size:20px;text-align:center;'>Hörmətli istifadəçi, qeydiyyatdan uğurla keçdiniz. Hesabınızı təsdiqləmək üçün aşağıdakı 'Hesabını təsdiqlə' düyməsinə tıklayın.</td></tr><tr><td style ='font-family:Roboto Condensed, sans-serif;text-align:center;'><a href='http://kirayemlak.az/Hesab/Tesdiqetme?userId={customUser.Id}&emailConfirmationToken={emailConfirmationToken}' style ='text-decoration:none;padding:10px 30px;border-radius:3px;background-color:#F9F9F9;color:#292C34;font-weight:lighter;font-size:20px;cursor:pointer;'>Hesabını təsdiqlə</a></td></tr></tbody></table>";
            await UtilityRealEstate.SendMessage(_configuration, registerViewModel.Email, messageSubject, messageBody, customUser, customUser, emailConfirmationToken);
            #endregion

            ViewBag.MobileOperators = _context.MobileOperators;
            TempData["AccountRegistered"] = true;
            return View();
        }

        public async Task<IActionResult> Tesdiqetme(string userId, string emailConfirmationToken)
        {
            if(userId == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            if (emailConfirmationToken == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            CustomUser customUserFromDb = await _userManager.FindByIdAsync(userId);

            if (customUserFromDb == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            await _userManager.ConfirmEmailAsync(customUserFromDb, emailConfirmationToken);
            customUserFromDb.EmailConfirmed = true;
            await _context.SaveChangesAsync();
            TempData["AccountConfirmed"] = true;

            return View();
        }
        public IActionResult Girish()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Menimhesabim", "Hesab");
            }
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Girish(SignInViewModel signInViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(signInViewModel);
            }

            CustomUser customUserFromDb = await _userManager.FindByEmailAsync(signInViewModel.Email);

            if (customUserFromDb == null)
            {
                ModelState.AddModelError("", "Daxil etdiyiniz email və ya şifrə yanlışdır.");
                return View(signInViewModel);
            }

            if (customUserFromDb.EmailConfirmed == false)
            {
                ModelState.AddModelError("", "Zəhmət olmasa, email ünvanınıza daxil olub hesabınızı təsdiqləyin.");
                return View(signInViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(customUserFromDb, signInViewModel.Password, signInViewModel.RememberMe, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Daxil etdiyiniz email və ya şifrə yanlışdır.");
                return View(signInViewModel);
            }

            return RedirectToAction("Menimhesabim", "Hesab");
        }
        [Authorize(Roles = "İstifadəçi")]
        public async Task<IActionResult> Menimhesabim()
        {
            ViewBag.MyAccount = "MyAccount";

            CustomUser customUserFromDb = await _userManager.FindByNameAsync(User.Identity.Name);

            if (customUserFromDb == null)
            {
                ViewBag.MyAccount = "MyAccount";
                return View("Views/Xeta/Index.cshtml");
            }

            return View(customUserFromDb);
        }
        public async Task<IActionResult> Istifadechininmelumatlari()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            string activeUserName = User.Identity.Name;

            if (activeUserName == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            CustomUser customUserFromDb = await _userManager.FindByNameAsync(activeUserName);

            if (customUserFromDb == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            ViewBag.FirstName = customUserFromDb.FirstName;
            ViewBag.LastName = customUserFromDb.LastName;
            ViewBag.Email = customUserFromDb.Email;
            ViewBag.SelectedMobileOperatorId = customUserFromDb.MobileOperatorId;
            ViewBag.PhoneNumber = customUserFromDb.PhoneNumber.Substring(6, 7);
            ViewBag.MobileOperators = _context.MobileOperators;

            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Istifadechininmelumatlari(AccountDetailsViewModel accountDetailsViewModel)
        {
            string activeUserName = User.Identity.Name;
            CustomUser customUserFromDb = await _userManager.FindByNameAsync(activeUserName);

            if(customUserFromDb == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            MobileOperator mobileOperatorFromDb = _context.MobileOperators.FirstOrDefault(mo => mo.Id == accountDetailsViewModel.MobileOperatorId);

            if (!ModelState.IsValid)
            {
                ViewBag.FirstName = customUserFromDb.FirstName;
                ViewBag.LastName = customUserFromDb.LastName;
                ViewBag.Email = customUserFromDb.Email;
                ViewBag.SelectedMobileOperatorId = customUserFromDb.MobileOperatorId;
                ViewBag.PhoneNumber = customUserFromDb.PhoneNumber.Substring(6, 7);
                ViewBag.MobileOperators = _context.MobileOperators;
                return View(accountDetailsViewModel);
            }

            string customUserFromDbOldEmail = customUserFromDb.Email;
            customUserFromDb.FirstName = accountDetailsViewModel.FirstName.Trim();
            customUserFromDb.LastName = accountDetailsViewModel.LastName.Trim();
            customUserFromDb.UserName = accountDetailsViewModel.Email.Trim();
            customUserFromDb.Email = accountDetailsViewModel.Email.Trim();
            customUserFromDb.MobileOperatorId = accountDetailsViewModel.MobileOperatorId;
            customUserFromDb.PhoneNumber = mobileOperatorFromDb.MobileOperatorCode + accountDetailsViewModel.PhoneNumber.Trim();
            await _userManager.UpdateAsync(customUserFromDb);
            if(customUserFromDb.Email != customUserFromDbOldEmail)
            {
                customUserFromDb.EmailConfirmed = false;
            }
            await _userManager.UpdateAsync(customUserFromDb);

            if (accountDetailsViewModel.CurrentPassword != null && accountDetailsViewModel.NewPassword != null)
            {
                string replacedCurrentPassword = accountDetailsViewModel.CurrentPassword.Trim();
                string replacedNewPassword = accountDetailsViewModel.NewPassword.Trim();

                IdentityResult result = await _userManager.ChangePasswordAsync(customUserFromDb, replacedCurrentPassword, replacedNewPassword);
                await _userManager.UpdateAsync(customUserFromDb);

                if(!result.Succeeded)
                {
                    ViewBag.FirstName = customUserFromDb.FirstName;
                    ViewBag.LastName = customUserFromDb.LastName;
                    ViewBag.Email = customUserFromDb.Email;
                    ViewBag.SelectedMobileOperatorId = customUserFromDb.MobileOperatorId;
                    ViewBag.PhoneNumber = customUserFromDb.PhoneNumber.Substring(6, 7);
                    ViewBag.MobileOperators = _context.MobileOperators;
                    ViewBag.MobileOperators = _context.MobileOperators;
                    ModelState.AddModelError("CurrentPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                    ModelState.AddModelError("NewPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                    return View(accountDetailsViewModel);
                }
            }

            if (accountDetailsViewModel.UploadFile != null)
            {
                if (accountDetailsViewModel.UploadFile.ContentType.Contains("image/jpg") || accountDetailsViewModel.UploadFile.ContentType.Contains("image/jpeg"))
                {
                    if (accountDetailsViewModel.UploadFile.Length > (2 * 1024 * 1024))
                    {
                        ViewBag.FirstName = customUserFromDb.FirstName;
                        ViewBag.LastName = customUserFromDb.LastName;
                        ViewBag.Email = customUserFromDb.Email;
                        ViewBag.SelectedMobileOperatorId = customUserFromDb.MobileOperatorId;
                        ViewBag.PhoneNumber = customUserFromDb.PhoneNumber.Substring(6, 7);
                        ViewBag.MobileOperators = _context.MobileOperators;
                        ViewBag.MobileOperators = _context.MobileOperators;
                        ModelState.AddModelError("", "Şəklin həcmi 2MB'dan çox ola bilməz.");
                        return View(accountDetailsViewModel);
                    }

                    string folderPath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "users");
                    fileName = Guid.NewGuid().ToString() + "_istifadechi_" + accountDetailsViewModel.UploadFile.FileName;
                    string filePath = Path.Combine(folderPath, fileName);

                    //Deleting profile picture of the user from file system
                    string customUserFromDbFilePath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "users", customUserFromDb.ProfilePictureURL);
                    if (System.IO.File.Exists(customUserFromDbFilePath))
                    {
                        try
                        {
                            System.IO.File.Delete(customUserFromDbFilePath);
                        }
                        catch
                        {
                            ModelState.AddModelError("UploadFile", "Xəta baş verdi");
                            return View(accountDetailsViewModel);
                        }
                    }

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await accountDetailsViewModel.UploadFile.CopyToAsync(fileStream);
                    }
                    customUserFromDb.ProfilePictureURL = fileName;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    ViewBag.FirstName = customUserFromDb.FirstName;
                    ViewBag.LastName = customUserFromDb.LastName;
                    ViewBag.Email = customUserFromDb.Email;
                    ViewBag.SelectedMobileOperatorId = customUserFromDb.MobileOperatorId;
                    ViewBag.PhoneNumber = customUserFromDb.PhoneNumber.Substring(6, 7);
                    ViewBag.MobileOperators = _context.MobileOperators;
                    ViewBag.MobileOperators = _context.MobileOperators;
                    ModelState.AddModelError("", "Zəhmət olmasa, tələb olunan formatda şəkil yükləyin");
                    return View(accountDetailsViewModel);
                }
            }

            string emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(customUserFromDb);

            if(customUserFromDb.EmailConfirmed == false)
            {
                #region Sending Email Confirmation Message
                string messageSubject = "Hesabın(Yeni email ünvanı) təsdiqlənməsi";
                string messageBody = $"<table style='width:100%;background-color:#292C34;padding:50px'><thead style ='width:100%;display:flex;justify-content:center;'><tr style ='width:100%;display:flex;justify-content:center;'><th style ='width:100%;color:#F9F9F9;font-family:Roboto, sans-serif;font-weight:400;font-size:50px'>Kirayeemlak.az</th></tr><thead><tbody><tr><td style ='padding:30px 0px;color:#888888;font-family:Roboto Condensed, sans-serif;font-size:20px;'>Hörmətli istifadəçi, yeni email ünvanınız uğurla qeydiyyatdan keçdi. Hesabınızı təsdiqləmək üçün aşağıdakı 'Hesabını təsdiqlə' düyməsinə tıklayın.</td></tr><tr><td style ='font-family:Roboto Condensed, sans-serif;text-align:center;'><a href='http://kirayemlak.az/Hesab/Tesdiqetme?userId={customUserFromDb.Id}&emailConfirmationToken={emailConfirmationToken}' style ='text-decoration:none;padding:10px 30px;border-radius:3px;background-color:#F9F9F9;color:#292C34;font-weight:lighter;font-size:20px;cursor:pointer;'>Hesabını təsdiqlə</a></td></tr></tbody></table>";
                await UtilityRealEstate.SendMessage(_configuration, accountDetailsViewModel.Email, messageSubject, messageBody, customUserFromDb, customUserFromDb, emailConfirmationToken);
                #endregion
            }

            TempData["AccountDetailsUpdated"] = true;

            ViewBag.FirstName = customUserFromDb.FirstName;
            ViewBag.LastName = customUserFromDb.LastName;
            ViewBag.Email = customUserFromDb.Email;
            ViewBag.SelectedMobileOperatorId = customUserFromDb.MobileOperatorId;
            ViewBag.PhoneNumber = customUserFromDb.PhoneNumber.Substring(6, 7);
            ViewBag.MobileOperators = _context.MobileOperators;

            return View();
        }
        public async Task<IActionResult> Chixish()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Girish", "Hesab");
        }
        public IActionResult Shifreniunutdum()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Shifreniunutdum(ForgotPasswordViewModel forgotPasswordViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(forgotPasswordViewModel);
            }

            CustomUser customUserFromDb = await _userManager.FindByEmailAsync(forgotPasswordViewModel.Email);

            if(customUserFromDb == null)
            {
                ModelState.AddModelError("", "Bu email veb portalda qeydiyyatdan keçirilməyib.");
                return View(forgotPasswordViewModel);
            }

            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(customUserFromDb);

            #region Sending Email Account Restoration Message
            string messageSubject = "Hesabın bərpası";
            string messageBody = $"<table style='width:100%;background-color:#AD0028;padding:50px'><thead style ='width:100%;display:flex;justify-content:center;'><tr style ='width:100%;display:flex;justify-content:center;'><th style ='width:100%;color:#F9F9F9;font-family:Roboto, sans-serif;font-weight:400;font-size:50px'>Kirayemlak.az</th></tr><thead><tbody><tr><td style ='padding:30px 0px;color:white;font-family:Roboto Condensed, sans-serif;font-size:20px;text-align:center;'>Hörmətli istifadəçi, hesabınızın bərpası üçün aşağıdakı 'Hesabını bərpa et' düyməsinə tıklayın.</td></tr><tr><td style ='font-family:Roboto Condensed, sans-serif;text-align:center;'><a href='http://kirayemlak.az/Hesab/Shifrenideyish?userId={customUserFromDb.Id}&passwordResetToken={passwordResetToken}' style ='text-decoration:none;padding:10px 30px;border-radius:3px;background-color:#F9F9F9;color:#292C34;font-weight:lighter;font-size:20px;cursor:pointer;'>Hesabını bərpa et</a></td></tr></tbody></table>";
            await UtilityRealEstate.SendMessage(_configuration, forgotPasswordViewModel.Email, messageSubject, messageBody, customUserFromDb, customUserFromDb, passwordResetToken, passwordResetToken);
            #endregion

            TempData["ForgotPassword"] = true;

            return View();
        }
        public async Task<IActionResult> Shifrenideyish(string userId, string passwordResetToken)
        {
            if (passwordResetToken == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            //As Tokens often are generated with "+" and come from query parameter with spaces we have to replace spaces with "+"
            string replacedPasswordResetToken = passwordResetToken.Replace(" ", "+");

            ViewBag.UserId = userId;
            ViewBag.PasswordResetToken = replacedPasswordResetToken;

            if(passwordResetToken == null)
            {
                ViewBag.UserId = userId;
                ViewBag.PasswordResetToken = replacedPasswordResetToken;
                return View("Views/Xeta/Index.cshtml");
            }

            CustomUser customUserFromDb = await _userManager.FindByIdAsync(userId);

            if(customUserFromDb == null)
            {
                ViewBag.UserId = userId;
                ViewBag.PasswordResetToken = replacedPasswordResetToken;
                return View("Views/Xeta/Index.cshtml");
            }

            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Shifrenideyish(ResetAndSetNewPasswordViewModel resetAndSetNewPasswordViewModel )
        {

            ViewBag.UserId = resetAndSetNewPasswordViewModel.UserId;
            ViewBag.PasswordResetToken = resetAndSetNewPasswordViewModel.PasswordResetToken;
            CustomUser customUserFromDb = await _userManager.FindByIdAsync(resetAndSetNewPasswordViewModel.UserId);

            if (!ModelState.IsValid)
            {
                ViewBag.UserId = resetAndSetNewPasswordViewModel.UserId;
                ViewBag.PasswordResetToken = resetAndSetNewPasswordViewModel.PasswordResetToken;
                return View(resetAndSetNewPasswordViewModel);
            }

            IdentityResult result = await _userManager.ResetPasswordAsync(customUserFromDb, resetAndSetNewPasswordViewModel.PasswordResetToken, resetAndSetNewPasswordViewModel.NewPassword);

            if(!result.Succeeded)
            {
                ViewBag.UserId = resetAndSetNewPasswordViewModel.UserId;
                ViewBag.PasswordResetToken = resetAndSetNewPasswordViewModel.PasswordResetToken;
                ModelState.AddModelError("", "Daxil etdiyiniz şifrə tələblərə uyğun deyil.");
                return View(resetAndSetNewPasswordViewModel);
            }

            await _userManager.UpdateAsync(customUserFromDb);
            TempData["AccountRestored"] = true;
            return RedirectToAction("Girish", "Hesab");
        }
    }
}