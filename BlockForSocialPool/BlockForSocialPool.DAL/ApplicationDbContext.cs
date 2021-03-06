﻿using BlockForSocialPool.Data;
using BlockForSocialPool.Data.Infrastructure;
using BlockForSocialPool.Data.Questions;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockForSocialPool.DAL
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {

        public ApplicationDbContext() : base("ApplicationDbContext")
        {
        }

        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionSlide> QuestionSlides { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Respondent> Respondents { get; set; }
        public DbSet<RespondentAnswer> RespondentAnswers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}
