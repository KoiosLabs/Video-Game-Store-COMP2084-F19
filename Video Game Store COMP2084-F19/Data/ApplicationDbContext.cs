using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Video_Game_Store_COMP2084_F19.Models;

namespace Video_Game_Store_COMP2084_F19.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Video_Game_Store_COMP2084_F19.Models.Game> Game { get; set; }
    }
}
