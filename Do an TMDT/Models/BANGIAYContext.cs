using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class BANGIAYContext : DbContext
    {
        public BANGIAYContext()
        {
        }

        public BANGIAYContext(DbContextOptions<BANGIAYContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitiet> Chitiets { get; set; }
        public virtual DbSet<Danhgium> Danhgia { get; set; }
        public virtual DbSet<Giohang> Giohangs { get; set; }
        public virtual DbSet<Hang> Hangs { get; set; }
        public virtual DbSet<Kieu> Kieus { get; set; }
        public virtual DbSet<Phanquyen> Phanquyens { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<SpGh> SpGhs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-73VOUOE\\SQLEXPRESS;Database=BANGIAY; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Chitiet>(entity =>
            {
                entity.HasKey(e => e.IdChiTiet);

                entity.ToTable("CHITIET");

                entity.Property(e => e.IdChiTiet)
                    .HasMaxLength(20)
                    .HasColumnName("ID_ChiTiet")
                    .IsFixedLength(true);

                entity.Property(e => e.GhId).HasColumnName("GH_ID");

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<Danhgium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DANHGIA");

                entity.Property(e => e.NoiDung).HasMaxLength(1000);

                entity.Property(e => e.SpId).HasColumnName("SP_ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Sp)
                    .WithMany()
                    .HasForeignKey(d => d.SpId)
                    .HasConstraintName("FK_DANHGIA_SANPHAM");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.HasKey(e => e.IdGh);

                entity.ToTable("GIOHANG");

                entity.Property(e => e.IdGh)
                    .HasMaxLength(20)
                    .HasColumnName("ID_GH")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GIOHANG_User");
            });

            modelBuilder.Entity<Hang>(entity =>
            {
                entity.HasKey(e => e.IdHang);

                entity.ToTable("Hang");

                entity.Property(e => e.IdHang)
                    .HasMaxLength(10)
                    .HasColumnName("ID_Hang")
                    .IsFixedLength(true);

                entity.Property(e => e.IdKieu)
                    .HasMaxLength(20)
                    .HasColumnName("ID_Kieu")
                    .IsFixedLength(true);

                entity.Property(e => e.IdSp)
                    .HasMaxLength(20)
                    .HasColumnName("ID_SP")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdKieuNavigation)
                    .WithMany(p => p.Hangs)
                    .HasForeignKey(d => d.IdKieu)
                    .HasConstraintName("FK_Hang_Kieu");
            });

            modelBuilder.Entity<Kieu>(entity =>
            {
                entity.ToTable("Kieu");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.ChitietId)
                    .HasMaxLength(20)
                    .HasColumnName("Chitiet_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.TenKieu)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_kieu");

                entity.HasOne(d => d.Chitiet)
                    .WithMany(p => p.Kieus)
                    .HasForeignKey(d => d.ChitietId)
                    .HasConstraintName("FK_Kieu_CHITIET");
            });

            modelBuilder.Entity<Phanquyen>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("PHANQUYEN");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .HasColumnName("Role_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .ValueGeneratedNever()
                    .HasColumnName("MaSP");

                entity.Property(e => e.Anh)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Anh2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BanChay)
                    .HasMaxLength(10)
                    .HasColumnName("Ban_chay")
                    .IsFixedLength(true);

                entity.Property(e => e.DaBan)
                    .HasMaxLength(10)
                    .HasColumnName("Da_Ban")
                    .IsFixedLength(true);

                entity.Property(e => e.DanhGia).HasColumnName("Danh_gia");

                entity.Property(e => e.GhId).HasColumnName("GH_ID");

                entity.Property(e => e.Gia)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.IdHang)
                    .HasMaxLength(10)
                    .HasColumnName("ID_Hang")
                    .IsFixedLength(true);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MoTa)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Slug)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slug")
                    .IsFixedLength(true);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdHangNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.IdHang)
                    .HasConstraintName("FK_SANPHAM_Hang");
            });

            modelBuilder.Entity<SpGh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SP_GH");

                entity.Property(e => e.IdGh)
                    .HasMaxLength(20)
                    .HasColumnName("ID_GH")
                    .IsFixedLength(true);

                entity.Property(e => e.SpId).HasColumnName("SP_ID");

                entity.HasOne(d => d.IdGhNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdGh)
                    .HasConstraintName("FK_SP_GH_GIOHANG");

                entity.HasOne(d => d.Sp)
                    .WithMany()
                    .HasForeignKey(d => d.SpId)
                    .HasConstraintName("FK_SP_GH_SANPHAM");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.MaUs);

                entity.ToTable("User");

                entity.Property(e => e.MaUs)
                    .ValueGeneratedNever()
                    .HasColumnName("MaUS");

                entity.Property(e => e.Anhdaidien)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .HasMaxLength(10)
                    .HasColumnName("diachi")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.EmailHd).HasColumnName("email_HD");

                entity.Property(e => e.HashMk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hash_MK")
                    .IsFixedLength(true);

                entity.Property(e => e.IdGh)
                    .HasMaxLength(10)
                    .HasColumnName("Id_GH")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .HasColumnName("Role_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Salt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salt")
                    .IsFixedLength(true);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.SdtHd).HasColumnName("SDT_HD");

                entity.Property(e => e.Slug)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("slug")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_PHANQUYEN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
