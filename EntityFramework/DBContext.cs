public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("DatabaseConnectionString");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId);
    }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}

// Usage
using (var context = new ApplicationDbContext())
{
    // Adding a new customer
    var customer = new Customer { Name = "John Doe" };
    context.Customers.Add(customer);
    context.SaveChanges();

    // Querying customers
    var customers = context.Customers.ToList();

    // Updating a customer
    var existingCustomer = context.Customers.Find(1);
    existingCustomer.Name = "John Smith";
    context.SaveChanges();

    // Deleting a customer
    context.Customers.Remove(existingCustomer);
    context.SaveChanges();
}