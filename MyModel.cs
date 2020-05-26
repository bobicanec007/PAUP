namespace Projekt_proba
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<Otpad> Otpads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Otpad>()
                .Property(e => e.VrstaOtpada)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Pon)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Uto)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Sri)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Cet)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Pet)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Sub)
                .IsFixedLength();

            modelBuilder.Entity<Otpad>()
                .Property(e => e.Ned)
                .IsFixedLength();
        }
    }
}
