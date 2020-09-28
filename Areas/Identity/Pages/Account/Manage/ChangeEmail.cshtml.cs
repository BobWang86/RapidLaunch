using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Bogus.DataSets;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RapidLaunch.Areas.Identity.Models;
using RapidLaunch.Areas.Identity.Services;

namespace RapidLaunch.Areas.Identity.Pages.Account.Manage
{
    public class ChangeEmailModel : PageModel
    {
        private readonly ApplicationUserManager _userManager;
        private readonly IAuthorizationService _authorizationService;
        private readonly ILogger<ChangeEmailModel> _logger;
        private readonly IEmailSender _emailSender;

        public ChangeEmailModel(
            ApplicationUserManager userManager,
            IAuthorizationService authorizationService,
            ILogger<ChangeEmailModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _authorizationService = authorizationService;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        [Display(Name = "Verified Email")]
        public string Email { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "New Email")]
            public string Email { get; set; }
        }

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
                return new RedirectToPageResult("Unauthorized");
            }

            var email = await _userManager.GetEmailAsync(user);

            Email = email;

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
                return new RedirectToPageResult("Unauthorized");
            }

            var email = await _userManager.GetEmailAsync(user);
            if (Input.Email != email)
            {
                var errors = new List<IdentityError>();
                if (_userManager.Options.User.RequireUniqueEmail)
                {
                    var owner = await _userManager.FindByEmailAsync(Input.Email);
                    if (owner != null && !string.Equals
                       (await _userManager.GetUserIdAsync(owner),
                        await _userManager.GetUserIdAsync(user)))
                    {
                        ModelState.AddModelError(string.Empty,
                        new IdentityErrorDescriber().DuplicateEmail(Input.Email).Description);
                        return Page();
                    }
                }

                var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmailResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred when setting email for user with ID '{userId}'.");
                }

                if (Input.Email.ToUpper() != email.ToUpper())
                {
                    var result = await _userManager.UpdateSecurityStampAsync(user);
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                            return Page();
                        }
                    }

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by < a href = '{HtmlEncoder.Default.Encode(callbackUrl)}' > clicking here </ a >.");
                    _logger.LogInformation("User email has been updated.");
                    StatusMessage = "Please check your inbox to confirm the new email.";
                }
                else
                {
                    _logger.LogInformation("User email has been updated.");
                    StatusMessage = "Your email has been updated.";
                }
            }

            return RedirectToPage();
        }
    }
}
