using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Learner_Management_System.Models;

namespace Learner_Management_System.Data
{
    public class Learner_Management_SystemContext : DbContext
    {
        public Learner_Management_SystemContext (DbContextOptions<Learner_Management_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<Learner_Management_System.Models.Learners> Learners { get; set; } = default!;

        public DbSet<Learner_Management_System.Models.Facilitators> Facilitators { get; set; } = default!;

        public DbSet<Learner_Management_System.Models.Courses> Courses { get; set; } = default!;
    }
}
