using Microsoft.EntityFrameworkCore;

namespace TogetherTest.Database {
    public class AddressesContext : DbContext {

        public AddressesContext(DbContextOptions options) : base(options) { }

        public DbSet<Address>? Addresses { get; set; }
    }
}
