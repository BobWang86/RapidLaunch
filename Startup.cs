using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RapidLaunch.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using RapidLaunch.Areas.Identity.Services;
using RapidLaunch.Areas.Identity.Models;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace RapidLaunch
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });

            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(options => {
                // Password Settings
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 1;

                // Lockout Settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                options.Lockout.MaxFailedAccessAttempts = 6;
                options.Lockout.AllowedForNewUsers = true;

                //User Settings
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;

            })
                .AddEntityFrameworkStores<RapidLaunchUserDbContext>()
                .AddUserManager<ApplicationUserManager>()
                .AddDefaultTokenProviders();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.Cookie.Name = "RapidLaunchCookie";

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.Configure<DataProtectionTokenProviderOptions>(options => options.TokenLifespan = TimeSpan.FromHours(1));
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<IAuthorizationHandler, UserAuthorizationHandler>();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, UserClaimsPrincipalFactory>();

            services.AddDbContext<RapidLaunchUserDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("LocalIdentityConnection")));

            //services.AddDbContext<RapidLaunchDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("LocalDbConnection"), x => x.UseNetTopologySuite()));

            services.AddMvc(config => {
                //var policy = new AuthorizationPolicyBuilder()
                //.RequireAuthenticatedUser()
                //.Build();
                //config.Filters.Add(new AuthorizeFilter(policy));
            }).AddRazorPagesOptions(options => {
                options.AllowAreas = true;
                options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-GB"),
                RequestCultureProviders = null
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Initialize the database with data seeding
            RapidLaunchDbInitializer.Initialize(app);
        }
    }

    public class EmailSender : IEmailSender
    {
        private const string ExchangeUri = "https://c9-ex01.c9.sshis.nhs.uk/EWS/Exchange.asmx";
        private const string ImpersonatedMailBox = "Haobo.Wang@mpft.nhs.uk";

        //private static ExchangeService GetExchangeService()
        //{
        //    ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2010_SP2)
        //    {
        //        Credentials = new WebCredentials("RioExchImp", "W1nter1!"),
        //        Url = new Uri(ExchangeUri)
        //    };
        //    return service;
        //}

        public System.Threading.Tasks.Task SendEmailAsync(string email, string subject, string message)
        {
            //try
            //{
            //    Email newEmail = new Email
            //    {
            //        Origin = "Haywood Arthritis Portal",
            //        EmailSubject = subject,
            //        EmailBody = message,
            //        DateCreated = DateTime.Now,
            //        EmailRecipient = new List<EmailRecipient> { new EmailRecipient { EmailAddress = email } }
            //    };

            //    SendEmail(email, newEmail.EmailSubject, newEmail.EmailBody, newEmail.Origin);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

            return System.Threading.Tasks.Task.CompletedTask;
        }

        public static void SendEmail(string toEmail, string subject, string body, string origin)
        {
            //try
            //{
            //    ExchangeService service = GetExchangeService();

            //    service.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, ImpersonatedMailBox);

            //    EmailMessage message = new EmailMessage(service)
            //    {
            //        ToRecipients = { new EmailAddress(toEmail) },
            //        Subject = subject,
            //        Body = new MessageBody(BodyType.HTML, body)
            //    };
            //    message.SendAndSaveCopy();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
    }
}
