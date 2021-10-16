using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebMotors.Domain.Entities;

namespace WebMotors.InfraStructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        #region DbSet

        public DbSet<AnnouncementWebmotors> AnnouncementWebmotors { get; set; }

        #endregion DbSet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}