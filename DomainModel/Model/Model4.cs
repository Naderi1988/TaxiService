using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DomainModel.Model
{
    public partial class Model4 : DbContext
    {
        public Model4()
            : base(@"data source = DESKTOP-ABS8B82; initial catalog = Taxi; persist security info=True;user id = sa; password=123;MultipleActiveResultSets=True")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Cartex> Cartexes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.CarMake)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.CarModel)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.CarModelYear)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Trips)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Trips)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Destination>()
                .HasMany(e => e.Trips)
                .WithRequired(e => e.Destination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DraiverAdress)
                .IsFixedLength();

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Cartexes)
                .WithRequired(e => e.Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Origin>()
                .HasMany(e => e.Trips)
                .WithRequired(e => e.Origin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.Trips)
                .WithRequired(e => e.Reservation)
                .WillCascadeOnDelete(false);
        }
    }
}
