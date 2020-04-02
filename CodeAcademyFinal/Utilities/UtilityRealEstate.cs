using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Utilities
{
    public static class UtilityRealEstate
    {
        public static async Task<bool> DbInitializer(UserManager<CustomUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            #region Creating Roles("Admin", "İstifadəçi") and main user("admin") while running app
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await _roleManager.RoleExistsAsync("İstifadəçi"))
            {
                await _roleManager.CreateAsync(new IdentityRole("İstifadəçi"));
            }

            CustomUser customUserFromDb = await _userManager.FindByNameAsync("admin");
            if (customUserFromDb == null)
            {
                CustomUser customUser = new CustomUser
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "admin",
                    Email = "kirayeemlak@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+994001234567",
                    ProfilePictureURL = "person-male-default.jpg"
                };

                IdentityResult result = await _userManager.CreateAsync(customUser, "");

                if (!result.Succeeded)
                {
                    return false;
                }

                await _userManager.AddToRoleAsync(customUser, "Admin");
            }
            #endregion

            return true;
        }
        public static async Task SendMessage(IConfiguration _configuration, string toMailAdress, string messageSubject, string messageBody, CustomUser customUser = null, CustomUser customUserFromDb = null, string emailConfirmationToken = null, string passwordResetToken = null)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionStrings:SmtpClientCredentialEmail"], _configuration["ConnectionStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage(_configuration["ConnectionStrings:SmtpClientCredentialEmail"], toMailAdress);
            message.IsBodyHtml = true;
            message.Subject = messageSubject;
            message.Body = messageBody;
            await client.SendMailAsync(message);
        }
    }
}
