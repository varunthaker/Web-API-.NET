using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        //Constructor
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        //Property
        public DbSet<Contact> Contacts { get; set;}
    }
}
