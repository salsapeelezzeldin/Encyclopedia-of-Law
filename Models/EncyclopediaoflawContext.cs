using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class EncyclopediaoflawContext : DbContext
    {
        public EncyclopediaoflawContext()
        {
        }

        public EncyclopediaoflawContext(DbContextOptions<EncyclopediaoflawContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LawyerInfo> LawyerInfo { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserIssues> UserIssues { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<الفصل1> الفصل1 { get; set; }
        public virtual DbSet<القانون> القانون { get; set; }
        public virtual DbSet<بابكتابقسم> بابكتابقسم { get; set; }
        public virtual DbSet<فصل2> فصل2 { get; set; }
        public virtual DbSet<فصل3> فصل3 { get; set; }
        public virtual DbSet<قسمكتابباب> قسمكتابباب { get; set; }
        public virtual DbSet<كتابقسمباب> كتابقسمباب { get; set; }
        public virtual DbSet<مواد> مواد { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-2B0NP05\\MSSQLSERVER01;Database=Encyclopedia of law;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LawyerInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lawyer_info");

                entity.Property(e => e.Information)
                    .HasColumnName("information")
                    .HasColumnType("text");

                entity.Property(e => e.JopDescription)
                    .HasColumnName("jop_description")
                    .HasColumnType("text");

                entity.Property(e => e.LawyerId)
                    .HasColumnName("lawyer_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OfficeLocation)
                    .HasColumnName("office_location")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeNumber)
                    .HasColumnName("office_number")
                    .HasMaxLength(20);

                entity.Property(e => e.Specialization)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.Lawyer)
                    .WithMany()
                    .HasForeignKey(d => d.LawyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lawer_info_users");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__Requests__33A8519AF04EF2AB");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.AssignedDate)
                    .HasColumnName("Assigned_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AssignedTime).HasColumnName("Assigned_Time");

                entity.Property(e => e.LawyerId).HasColumnName("Lawyer_ID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("Request_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestStatue)
                    .IsRequired()
                    .HasColumnName("Request_Statue")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Pending')");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.RequestsLawyer)
                    .HasForeignKey(d => d.LawyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_Lawyers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RequestsUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_users");
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PK__Reviews__74BC79AE3D5665A4");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.ReqId).HasColumnName("Req_ID");

                entity.Property(e => e.Review).HasColumnType("text");

                entity.Property(e => e.ReviewDate)
                    .HasColumnName("Review_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ReqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reviews_Requests");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("roles");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("roleName")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserIssues>(entity =>
            {
                entity.HasKey(e => e.IssueId)
                    .HasName("PK__UserIssu__749E804CF181F235");

                entity.Property(e => e.IssueId).HasColumnName("issueID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.RequestStatue)
                    .HasColumnName("Request_Statue")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'pending')");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_users_roles");
            });

            modelBuilder.Entity<الفصل1>(entity =>
            {
                entity.HasKey(e => e.IdChapter);

                entity.Property(e => e.IdChapter).HasColumnName("ID_Chapter");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.اسمالفصل)
                    .HasColumnName("اسم الفصل")
                    .HasMaxLength(50);

                entity.Property(e => e.رقمالفصل)
                    .HasColumnName("رقم الفصل")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.الفصل1)
                    .HasForeignKey(d => d.IdP)
                    .HasConstraintName("FK_الفصل1_باب(كتاب/قسم)");
            });

            modelBuilder.Entity<القانون>(entity =>
            {
                entity.HasKey(e => e.IdLaw);

                entity.Property(e => e.IdLaw).HasColumnName("ID_law");

                entity.Property(e => e.اسمالقانون)
                    .HasColumnName("اسم القانون")
                    .HasMaxLength(50);

                entity.Property(e => e.اسممصدره)
                    .HasColumnName("اسم مصدره")
                    .HasMaxLength(50);

                entity.Property(e => e.تاريخاصدارالقانون)
                    .HasColumnName("تاريخ اصدار القانون")
                    .HasMaxLength(50);

                entity.Property(e => e.تاريخالنشر)
                    .HasColumnName("تاريخ النشر")
                    .HasMaxLength(50);

                entity.Property(e => e.جهةالاصدار)
                    .HasColumnName("جهة الاصدار")
                    .HasMaxLength(50);

                entity.Property(e => e.جهةالنشر)
                    .HasColumnName("جهة النشر")
                    .HasMaxLength(50);

                entity.Property(e => e.رقمالوثيقه)
                    .HasColumnName("رقم الوثيقه")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<بابكتابقسم>(entity =>
            {
                entity.HasKey(e => e.IdP);

                entity.ToTable("باب(كتاب/قسم)");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.IdB).HasColumnName("ID_B");

                entity.Property(e => e.اسمالباب)
                    .HasColumnName("اسم الباب")
                    .HasMaxLength(50);

                entity.Property(e => e.رقمالباب)
                    .HasColumnName("رقم الباب")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdBNavigation)
                    .WithMany(p => p.بابكتابقسم)
                    .HasForeignKey(d => d.IdB)
                    .HasConstraintName("FK_باب(كتاب/قسم)_كتاب(/قسم/باب)");
            });

            modelBuilder.Entity<فصل2>(entity =>
            {
                entity.HasKey(e => e.IdCh2);

                entity.Property(e => e.IdCh2).HasColumnName("ID_Ch2");

                entity.Property(e => e.IdChapter).HasColumnName("ID_Chapter");

                entity.Property(e => e.اسمالنقطه)
                    .HasColumnName("اسم النقطه")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdChapterNavigation)
                    .WithMany(p => p.فصل2)
                    .HasForeignKey(d => d.IdChapter)
                    .HasConstraintName("FK_فصل2_الفصل1");
            });

            modelBuilder.Entity<فصل3>(entity =>
            {
                entity.HasKey(e => e.IdCh3);

                entity.Property(e => e.IdCh3).HasColumnName("ID_Ch3");

                entity.Property(e => e.IdCh2).HasColumnName("ID_Ch2");

                entity.Property(e => e.محتويالنقطه)
                    .HasColumnName("محتوي النقطه")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCh2Navigation)
                    .WithMany(p => p.فصل3)
                    .HasForeignKey(d => d.IdCh2)
                    .HasConstraintName("FK_فصل3_فصل2");
            });

            modelBuilder.Entity<قسمكتابباب>(entity =>
            {
                entity.HasKey(e => e.IdS);

                entity.ToTable("قسم(/كتاب/باب)");

                entity.Property(e => e.IdS).HasColumnName("ID_S");

                entity.Property(e => e.IdLaw).HasColumnName("ID_law");

                entity.Property(e => e.اسمالقسم)
                    .HasColumnName("اسم القسم")
                    .HasMaxLength(50);

                entity.Property(e => e.رقمالقسم)
                    .HasColumnName("رقم القسم")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdLawNavigation)
                    .WithMany(p => p.قسمكتابباب)
                    .HasForeignKey(d => d.IdLaw)
                    .HasConstraintName("FK_قسم(/كتاب/باب)_القانون");
            });

            modelBuilder.Entity<كتابقسمباب>(entity =>
            {
                entity.HasKey(e => e.IdB);

                entity.ToTable("كتاب(/قسم/باب)");

                entity.Property(e => e.IdB).HasColumnName("ID_B");

                entity.Property(e => e.IdS).HasColumnName("ID_S");

                entity.Property(e => e.اسمالكتاب)
                    .HasColumnName("اسم الكتاب")
                    .HasMaxLength(50);

                entity.Property(e => e.رقمالكتاب)
                    .HasColumnName("رقم الكتاب")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdSNavigation)
                    .WithMany(p => p.كتابقسمباب)
                    .HasForeignKey(d => d.IdS)
                    .HasConstraintName("FK_كتاب(/قسم/باب)_قسم(/كتاب/باب)");
            });

            modelBuilder.Entity<مواد>(entity =>
            {
                entity.HasKey(e => e.IdSubjects);

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
                    .HasColumnName("حاله الماده")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'مازلت موجوده')");

                entity.Property(e => e.رقمالماده)
                    .HasColumnName("رقم الماده")
                    .HasMaxLength(50);

                entity.Property(e => e.سنهالتعديلالسابق)
                    .HasColumnName("سنه التعديل السابق")
                    .HasMaxLength(50);

                entity.Property(e => e.محتوىالماده).HasColumnName("محتوى الماده");

                entity.HasOne(d => d.IdBNavigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdB)
                    .HasConstraintName("FK_مواد_كتاب(/قسم/باب)");

                entity.HasOne(d => d.IdCh2Navigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdCh2)
                    .HasConstraintName("FK_مواد_فصل2");

                entity.HasOne(d => d.IdCh3Navigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdCh3)
                    .HasConstraintName("FK_مواد_فصل3");

                entity.HasOne(d => d.IdChapterNavigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdChapter)
                    .HasConstraintName("FK_مواد_الفصل1");

                entity.HasOne(d => d.IdLawNavigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdLaw)
                    .HasConstraintName("FK_مواد_القانون");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdP)
                    .HasConstraintName("FK_مواد_باب(كتاب/قسم)");

                entity.HasOne(d => d.IdSقسمNavigation)
                    .WithMany(p => p.مواد)
                    .HasForeignKey(d => d.IdSقسم)
                    .HasConstraintName("FK_مواد_قسم(/كتاب/باب)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
