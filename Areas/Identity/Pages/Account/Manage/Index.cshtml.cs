using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RapidLaunch.Areas.Identity.Models;
using RapidLaunch.Areas.Identity.Services;

namespace RapidLaunch.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly ApplicationUserManager _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAuthorizationService _authorizationService;
        private readonly IEmailSender _emailSender;

        public IndexModel(
            ApplicationUserManager userManager,
            SignInManager<ApplicationUser> signInManager,
            IAuthorizationService authorizationService,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authorizationService = authorizationService;
            _emailSender = emailSender;
        }

        public string Email { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public UserProfileVM Input { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var isAuthorized = await _authorizationService.AuthorizeAsync(User, user, UserOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return RedirectToPage("./Unauthorized");
            }

            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Email = email;

            Input = new UserProfileVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Postcode = user.Postcode,
                DOB = user.DOB,
                NHSNumber = user.NHSNumber,
                PhoneNumber = phoneNumber
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var isAuthorized = await _authorizationService.AuthorizeAsync(User, user, UserOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return RedirectToPage("./Unauthorized");
            }

            if (Input.FirstName != user.FirstName) user.FirstName = Input.FirstName;

            if (Input.LastName != user.LastName) user.LastName = Input.LastName;

            if (Input.Postcode != user.Postcode) user.Postcode = Input.Postcode;

            if (Input.DOB != user.DOB) user.DOB = Input.DOB;

            if (Input.NHSNumber != user.NHSNumber) user.NHSNumber = Input.NHSNumber;

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }

        //public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }


        //    var userId = await _userManager.GetUserIdAsync(user);
        //    var email = await _userManager.GetEmailAsync(user);
        //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //    var callbackUrl = Url.Page(
        //        "/Account/ConfirmEmail",
        //        pageHandler: null,
        //        values: new { userId = userId, code = code },
        //        protocol: Request.Scheme);
        //    await _emailSender.SendEmailAsync(
        //        email,
        //        "Confirm your email",
        //        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

        //    StatusMessage = "Verification email sent. Please check your email.";
        //    return RedirectToPage();
        //}
    }
}
