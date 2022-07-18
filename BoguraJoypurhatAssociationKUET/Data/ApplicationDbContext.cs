using BoguraJoypurhatAssociationKUET.Models;
using Microsoft.EntityFrameworkCore;

//namespace BoguraJoypurhatAssociationKUET.Data
//{
   // public class ApplicationDbContext :DbContext
   // {
       // public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
      //  {

      //  }

      //  public DbSet<Category> Categories { get; set; }
    //}
//}

namespace BoguraJoypurhatAssociationKUET.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}