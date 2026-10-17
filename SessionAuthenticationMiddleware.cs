using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using RaceDay.API.Data;

namespace RaceDay.API.Middleware;

public class SessionAuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public SessionAuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(
        HttpContext context,
        RaceDayDbContext dbContext)
    {
        int? userId = context.Session.GetInt32("UserId");

        if (userId.HasValue)
        {
            var user = await dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.UserId == userId.Value);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(
                        ClaimTypes.NameIdentifier,
                        user.UserId.ToString()),

                    new Claim(
                        ClaimTypes.Name,
                        $"{user.FirstName} {user.LastName}"),

                    new Claim(
                        ClaimTypes.Email,
                        user.Email),

                    new Claim(
                        ClaimTypes.Role,
                        user.Role)
                };

                var identity = new ClaimsIdentity(
                    claims,
                    authenticationType: "RaceDaySession");

                context.User = new ClaimsPrincipal(identity);
            }
            else
            {
                // The account no longer exists.
                context.Session.Clear();
            }
        }

        await _next(context);
    }
}