using System;
using System.Collections.Generic;
using System.Text;
using Invitor.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Invitor.Web.Data
{
    public class InvitorDbContext : IdentityDbContext<Person>
    {
        public InvitorDbContext(DbContextOptions<InvitorDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonEvent> PersonEvent { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder); //must voor identity }
            modelBuilder.Entity<PersonEvent>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.EventId });
            });

        }
    }
}
