using Microsoft.EntityFrameworkCore;
using WebAPIBorrar.Data;

namespace WebAPIBorrar.Contexto
{
    public class ContextProyext : DbContext
    {
        public ContextProyext(DbContextOptions option) :base(option)
        {

        }

        public DbSet<Usuarios> usuario { get; set; }
            
    }
}
