using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.Persistence
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContextDB") { }
        public DbSet<DTO.OrderDTO> Orders { get; set; }
    }
}
