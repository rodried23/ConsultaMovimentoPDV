using ConsultaMovimentoPDV.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaMovimentoPDV.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

       public DbSet<MovimentoModel> Movimento { get; set; }
       public DbSet<NfceSerieModel> NfceSerie { get; set; }
        
    }
}
