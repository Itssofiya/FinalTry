using JobSeeker.Entites;
using JobSeeker.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobSeeker.DataLayer
{
    public class JSDbContext : IdentityDbContext<UserMaster>
    {
        public JSDbContext(DbContextOptions<JSDbContext> options) : base(options)
        {

        }
        public DbSet<JSRegistration> JSRegistrations { get; set; }
        public DbSet<JSProfile> JSProfiles { get; set; }
        public DbSet<JSJobs> JSJobs { get; set; }
        public DbSet<JobSeekerSkill> JobSeekerSkills { get; set; }
        public DbSet<JobSeekerSession> JobSeekerSessions { get; set; }
        public DbSet<JSCourse> JSCourses { get; set; }

       

      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<JSRegistration>().HasKey(x => x.RID);
            builder.Entity<JSProfile>().HasKey(x => x.ProfileId);
            builder.Entity<JSJobs>().HasKey(x => x.Id);
            builder.Entity<JobSeekerSkill>().HasKey(x => x.SId);
            builder.Entity<JobSeekerSession>().HasKey(x => x.Id);
            builder.Entity<JSCourse>().HasKey(x => x.Id);

            base.OnModelCreating(builder);
        }
    }
}
