using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietHDBan> ChiTietHDBans { get; set; }
        public virtual DbSet<Hang> Hangs { get; set; }
        public virtual DbSet<HDBan> HDBans { get; set; }
        public virtual DbSet<Khach> Khaches { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang>()
                .HasMany(e => e.ChiTietHDBans)
                .WithRequired(e => e.Hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HDBan>()
                .HasMany(e => e.ChiTietHDBans)
                .WithRequired(e => e.HDBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khach>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.Khach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiHang>()
                .HasMany(e => e.Hangs)
                .WithRequired(e => e.LoaiHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);
        }
    }
}
