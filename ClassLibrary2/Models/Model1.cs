namespace ClassLibrary2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<BillOrder> BillOrder { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<levelAccount> levelAccount { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<Produce> Produce { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<BillInfo> BillInfo { get; set; }
        public virtual DbSet<DeliveryInfo> DeliveryInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillOrder>()
                .Property(e => e.totalPrice)
                .IsUnicode(false);

            modelBuilder.Entity<BillOrder>()
                .Property(e => e.totalPayment)
                .IsUnicode(false);

            modelBuilder.Entity<BillOrder>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.BillOrder)
                .HasForeignKey(e => e.idBillOrder);

            modelBuilder.Entity<BillOrder>()
                .HasMany(e => e.Delivery)
                .WithRequired(e => e.BillOrder)
                .HasForeignKey(e => e.idBillOrder);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Produce)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.idCategory);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Provider)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.idCategory);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.BillOrder)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.idCustomer);

            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.DeliveryInfo)
                .WithRequired(e => e.Delivery)
                .HasForeignKey(e => e.idDelivery);

            modelBuilder.Entity<Produce>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<Produce>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.Produce)
                .HasForeignKey(e => e.idProduce);

            modelBuilder.Entity<Produce>()
                .HasMany(e => e.DeliveryInfo)
                .WithRequired(e => e.Produce)
                .HasForeignKey(e => e.idProduce);

            modelBuilder.Entity<BillInfo>()
                .Property(e => e.totalPrice)
                .IsUnicode(false);

            modelBuilder.Entity<BillInfo>()
                .Property(e => e.totalPayment)
                .IsUnicode(false);
        }
    }
}
