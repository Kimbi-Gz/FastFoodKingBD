using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FastFoodKing.Models;

public partial class FastFoodKingBdContext : DbContext
{
    public FastFoodKingBdContext()
    {
    }

    public FastFoodKingBdContext(DbContextOptions<FastFoodKingBdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<OrdenDetail> OrdenDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-I7T18V9;Initial Catalog=FastFoodKingBD;Integrated Security=True; TrustServerCertificate= True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cart__3214EC07AAC087F1");

            entity.ToTable("Cart");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Count).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GraphIdBd3a9fe11ce34830bc5c477e0efc37cb).HasColumnName("graph_id_BD3A9FE11CE34830BC5C477E0EFC37CB");
            entity.Property(e => e.NodeId0b338c97a1404513b4317e3613ea137d)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_0B338C97A1404513B4317E3613EA137D");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.Carts)
                .HasForeignKey(d => d.IdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Menu");

            entity.HasOne(d => d.IdUsersNavigation).WithMany(p => p.Carts)
                .HasForeignKey(d => d.IdUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Users");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC070683CABA");

            entity.ToTable("Category");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GraphIdE8413eacd7b54be39f6b78209d3a85d7).HasColumnName("graph_id_E8413EACD7B54BE39F6B78209D3A85D7");
            entity.Property(e => e.NodeIdE250659f8d484cfd97ada3b7fee6c4c3)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_E250659F8D484CFD97ADA3B7FEE6C4C3");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Menu__3214EC07EACC784A");

            entity.ToTable("Menu");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.GraphIdE0f94030bdef4a499305d6882c0c17f1).HasColumnName("graph_id_E0F94030BDEF4A499305D6882C0C17F1");
            entity.Property(e => e.NodeId2330d75fc5db4f23ae1fa6f24ec519be)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_2330D75FC5DB4F23AE1FA6F24EC519BE");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Menus)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Category");
        });

        modelBuilder.Entity<OrdenDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrdenDet__3214EC07B0D7E1D4");

            entity.ToTable("OrdenDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Count).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.GraphIdB54e542f2309455d9dc23cdfababa628).HasColumnName("graph_id_B54E542F2309455D9DC23CDFABABA628");
            entity.Property(e => e.NodeId0e3392079dce475dabdee007ef71f07a)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_0E3392079DCE475DABDEE007EF71F07A");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.OrdenDetails)
                .HasForeignKey(d => d.IdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Menu");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC070BFF35B8");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GraphId9ed6bb6dd83949949fccb60e13eb412f).HasColumnName("graph_id_9ED6BB6DD83949949FCCB60E13EB412F");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NodeId11bc9190857141bf9d9b5b9c57af15e9)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_11BC9190857141BF9D9B5B9C57AF15E9");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
