using System;
using Cms.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace Cms.Core.Identity
{
    public class Options
    {
        public static void ApplyDefaultIdentityOptions(IdentityOptions options)
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = false;
            options.Password.RequiredUniqueChars = 6;
            options.User.RequireUniqueEmail = true;
            options.Lockout.AllowedForNewUsers = false;
        }

        public static void ApplyDefaultCookieOptions(CookieAuthenticationOptions options)
        {
            options.Cookie.HttpOnly = true;
            options.Cookie.Expiration = TimeSpan.FromDays(150);
            options.LoginPath = string.Format(Routes.Cms, "Login", "Index");
            options.LogoutPath = string.Format(Routes.Cms, "Login", "Logout");
            options.AccessDeniedPath = string.Format(Routes.Cms, "Login", "AccessDenied");
            options.SlidingExpiration = true;
        }
    }
}