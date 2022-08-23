using Microsoft.EntityFrameworkCore;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DataAccess
{
    public class NotesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-UDMLI44\\SQLEXPRESS; Database=NotesDb; Trusted_Connection=true");
        }

        public DbSet<Note> Notes { get; set; }
    }
}
