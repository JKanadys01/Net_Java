using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRaitingBlazorApp.Components;

namespace MovieRaitingBlazorApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<MovieRaitingBlazorApp.Components.Movie> Movie { get; set; } = default!;
    }
}
