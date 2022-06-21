using Microsoft.EntityFrameworkCore;

namespace Backend
{
    //first add entity framework (via nuget command); may need to close and reopen visual studio to see files
    //Now we need to create a class for our EntityFramework database context.
    public class ShoppingDatabase : DbContext
    {
        public ShoppingDatabase(DbContextOptions<ShoppingDatabase> options) : base(options)
        {

        }

        public virtual DbSet<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
