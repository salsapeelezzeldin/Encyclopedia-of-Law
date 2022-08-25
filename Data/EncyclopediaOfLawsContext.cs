using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Encyclopedia_Of_Laws.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace Encyclopedia_Of_Laws.Data
{
    public partial class EncyclopediaOfLawsContext : IdentityDbContext<ApplicationUser>
    {
        public EncyclopediaOfLawsContext()
        {
        }

        public EncyclopediaOfLawsContext(DbContextOptions<EncyclopediaOfLawsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Request> Requests { get; set; }

        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Bookكتابقسمباب> Bookكتابقسمبابs { get; set; }
        public virtual DbSet<Chapter1> Chapter1s { get; set; }
        public virtual DbSet<Chapter2> Chapter2s { get; set; }
        public virtual DbSet<Chapter3> Chapter3s { get; set; }
        public virtual DbSet<Law> Laws { get; set; }
        public virtual DbSet<Partقسمكتابباب> Partقسمكتاببابs { get; set; }
        public virtual DbSet<Sectionكتابقسم> Sectionكتابقسمs { get; set; }
        public virtual DbSet<Subjectsمواد> Subjectsموادs { get; set; }
        public virtual DbSet<UserIssue> UserIssues { get; set; }
        public virtual DbSet<LawyerInfo> LawyerInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("Users", "security");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles", "security");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");


            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.AssignedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AssignedDate");

                entity.Property(e => e.LawyerId).HasColumnName("Lawyer_ID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Subject).HasColumnName("Subject");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RequestDate");

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Request_Status")
                    .HasDefaultValueSql("(N'Pending')");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.RequestLawyers)
                    .HasForeignKey(d => d.LawyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_Lawyers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RequestUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_users");
            });

            modelBuilder.Entity<Bookكتابقسمباب>(entity =>
            {
                entity.HasKey(e => e.IdB)
                    .HasName("PK_كتاب(/قسم/باب)");

                entity.ToTable("book[كتاب(/قسم/باب)]");

                entity.Property(e => e.IdB).HasColumnName("ID_B");

                entity.Property(e => e.IdS).HasColumnName("ID_S");

                entity.Property(e => e.اسمالكتاب)
                    .HasMaxLength(50)
                    .HasColumnName("اسم الكتاب");

                entity.Property(e => e.رقمالكتاب)
                    .HasMaxLength(50)
                    .HasColumnName("رقم الكتاب");

                entity.HasOne(d => d.IdSNavigation)
                    .WithMany(p => p.Bookكتابقسمبابs)
                    .HasForeignKey(d => d.IdS)
                    .HasConstraintName("FK_كتاب(/قسم/باب)_قسم(/كتاب/باب)");
            });

            modelBuilder.Entity<Chapter1>(entity =>
            {
                entity.HasKey(e => e.IdChapter)
                    .HasName("PK_الفصل1");

                entity.ToTable("Chapter1");

                entity.Property(e => e.IdChapter).HasColumnName("ID_Chapter");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.اسمالفصل)
                    .HasMaxLength(50)
                    .HasColumnName("اسم الفصل");

                entity.Property(e => e.رقمالفصل)
                    .HasMaxLength(50)
                    .HasColumnName("رقم الفصل");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.Chapter1s)
                    .HasForeignKey(d => d.IdP)
                    .HasConstraintName("FK_الفصل1_باب(كتاب/قسم)");
            });

            modelBuilder.Entity<Chapter2>(entity =>
            {
                entity.HasKey(e => e.IdCh2)
                    .HasName("PK_فصل2");

                entity.ToTable("Chapter2");

                entity.Property(e => e.IdCh2).HasColumnName("ID_Ch2");

                entity.Property(e => e.IdChapter).HasColumnName("ID_Chapter");

                entity.Property(e => e.اسمالنقطه)
                    .HasMaxLength(50)
                    .HasColumnName("اسم النقطه");

                entity.HasOne(d => d.IdChapterNavigation)
                    .WithMany(p => p.Chapter2s)
                    .HasForeignKey(d => d.IdChapter)
                    .HasConstraintName("FK_فصل2_الفصل1");
            });

            modelBuilder.Entity<Chapter3>(entity =>
            {
                entity.HasKey(e => e.IdCh3)
                    .HasName("PK_فصل3");

                entity.ToTable("Chapter3");

                entity.Property(e => e.IdCh3).HasColumnName("ID_Ch3");

                entity.Property(e => e.IdCh2).HasColumnName("ID_Ch2");

                entity.Property(e => e.محتويالنقطه)
                    .HasMaxLength(50)
                    .HasColumnName("محتوي النقطه");

                entity.HasOne(d => d.IdCh2Navigation)
                    .WithMany(p => p.Chapter3s)
                    .HasForeignKey(d => d.IdCh2)
                    .HasConstraintName("FK_فصل3_فصل2");
            });

            modelBuilder.Entity<Law>(entity =>
            {
                entity.HasKey(e => e.IdLaw)
                    .HasName("PK_القانون");

                entity.ToTable("Law");

                entity.Property(e => e.IdLaw).HasColumnName("ID_law");

                entity.Property(e => e.اسمالقانون)
                    .HasMaxLength(50)
                    .HasColumnName("اسم القانون");

                entity.Property(e => e.اسممصدره)
                    .HasMaxLength(50)
                    .HasColumnName("اسم مصدره");

                entity.Property(e => e.تاريخاصدارالقانون)
                    .HasMaxLength(50)
                    .HasColumnName("تاريخ اصدار القانون");

                entity.Property(e => e.تاريخالنشر)
                    .HasMaxLength(50)
                    .HasColumnName("تاريخ النشر");

                entity.Property(e => e.جهةالاصدار)
                    .HasMaxLength(50)
                    .HasColumnName("جهة الاصدار");

                entity.Property(e => e.جهةالنشر)
                    .HasMaxLength(50)
                    .HasColumnName("جهة النشر");

                entity.Property(e => e.رقمالوثيقه)
                    .HasMaxLength(50)
                    .HasColumnName("رقم الوثيقه");
            });

            modelBuilder.Entity<Partقسمكتابباب>(entity =>
            {
                entity.HasKey(e => e.IdS)
                    .HasName("PK_قسم(/كتاب/باب)");

                entity.ToTable("Part[قسم(/كتاب/باب)]");

                entity.Property(e => e.IdS).HasColumnName("ID_S");

                entity.Property(e => e.IdLaw).HasColumnName("ID_law");

                entity.Property(e => e.اسمالقسم)
                    .HasMaxLength(50)
                    .HasColumnName("اسم القسم");

                entity.Property(e => e.رقمالقسم)
                    .HasMaxLength(50)
                    .HasColumnName("رقم القسم");

                entity.HasOne(d => d.IdLawNavigation)
                    .WithMany(p => p.Partقسمكتاببابs)
                    .HasForeignKey(d => d.IdLaw)
                    .HasConstraintName("FK_قسم(/كتاب/باب)_القانون");
            });

            modelBuilder.Entity<Sectionكتابقسم>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PK_باب(كتاب/قسم)");

                entity.ToTable("Section(كتاب/قسم)]");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.IdB).HasColumnName("ID_B");

                entity.Property(e => e.اسمالباب)
                    .HasMaxLength(50)
                    .HasColumnName("اسم الباب");

                entity.Property(e => e.رقمالباب)
                    .HasMaxLength(50)
                    .HasColumnName("رقم الباب");

                entity.HasOne(d => d.IdBNavigation)
                    .WithMany(p => p.Sectionكتابقسمs)
                    .HasForeignKey(d => d.IdB)
                    .HasConstraintName("FK_باب(كتاب/قسم)_كتاب(/قسم/باب)");
            });

            modelBuilder.Entity<Subjectsمواد>(entity =>
            {
                entity.HasKey(e => e.IdSubjects)
                    .HasName("PK_مواد");

                entity.ToTable("Subjects[مواد]");

                entity.Property(e => e.IdSubjects).HasColumnName("ID_Subjects");

                entity.Property(e => e.IdB).HasColumnName("ID_B");

                entity.Property(e => e.IdCh2).HasColumnName("ID_Ch2");

                entity.Property(e => e.IdCh3).HasColumnName("ID_Ch3");

                entity.Property(e => e.IdChapter).HasColumnName("ID_Chapter");

                entity.Property(e => e.IdLaw).HasColumnName("ID_Law");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.IdSقسم).HasColumnName("ID_S(قسم)");

                entity.Property(e => e.التعديلالسابقللماده).HasColumnName("التعديل السابق للماده");

                entity.Property(e => e.حالهالماده)
                    .HasMaxLength(50)
                    .HasColumnName("حاله الماده")
                    .HasDefaultValueSql("(N'مازلت موجوده')");

                entity.Property(e => e.رقمالماده)
                    .HasMaxLength(50)
                    .HasColumnName("رقم الماده");

                entity.Property(e => e.سنهالتعديلالسابق)
                    .HasMaxLength(50)
                    .HasColumnName("سنه التعديل السابق");

                entity.Property(e => e.محتوىالماده).HasColumnName("محتوى الماده");

                entity.HasOne(d => d.IdBNavigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdB)
                    .HasConstraintName("FK_مواد_كتاب(/قسم/باب)");

                entity.HasOne(d => d.IdCh2Navigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdCh2)
                    .HasConstraintName("FK_مواد_فصل2");

                entity.HasOne(d => d.IdCh3Navigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdCh3)
                    .HasConstraintName("FK_مواد_فصل3");

                entity.HasOne(d => d.IdChapterNavigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdChapter)
                    .HasConstraintName("FK_مواد_الفصل1");

                entity.HasOne(d => d.IdLawNavigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdLaw)
                    .HasConstraintName("FK_مواد_القانون");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdP)
                    .HasConstraintName("FK_مواد_باب(كتاب/قسم)");

                entity.HasOne(d => d.IdSقسمNavigation)
                    .WithMany(p => p.Subjectsموادs)
                    .HasForeignKey(d => d.IdSقسم)
                    .HasConstraintName("FK_مواد_قسم(/كتاب/باب)");
            });

            modelBuilder.Entity<UserIssue>(entity =>
            {
                entity.HasKey(e => e.IssueId)
                    .HasName("PK__UserIssu__749E804CF181F235");

                entity.Property(e => e.IssueId).HasColumnName("issueID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("issue_Date");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'pending')");

                entity.Property(e => e.Subject).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
