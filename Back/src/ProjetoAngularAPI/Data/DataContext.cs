using Microsoft.EntityFrameworkCore;
using ProjetoAngularAPI.Models;

namespace ProjetoAngularAPI.Data {

    public class DataContext : DbContext{
        public DataContext(DbContextOptions<DataContext>options): base(options){}
      
        public DbSet <Evento>Eventos { get; set; }
    }

}