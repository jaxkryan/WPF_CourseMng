using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects;

public partial class CourseManagementDbContext : DbContext
{
    public CourseManagementDbContext()
    {
    }

    public CourseManagementDbContext(DbContextOptions<CourseManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountMember> AccountMembers { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountMember>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__AccountM__349DA586FB77EBBC");

            entity.ToTable("AccountMember");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountID");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Assessme__3213E83FA78489E2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Percent).HasColumnName("percent");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Course).WithMany(p => p.Assessments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Assessmen__cours__31EC6D26");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3213E83F3D076CE9");

            entity.HasIndex(e => e.Code, "UQ__Courses__357D4CF9B357C3EC").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Credits).HasColumnName("credits");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Departme__A25C5AA69C9A0F6A");

            entity.HasIndex(e => e.Name, "UQ__Departme__737584F638F5AFFF").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__enrollme__ACFF2C86BBCC08E3");

            entity.ToTable("enrollment");

            entity.HasIndex(e => new { e.StudentId, e.CourseId, e.SemesterId }, "UQ__enrollme__C949A1BEDAC5E0EF").IsUnique();

            entity.Property(e => e.EnrollmentId)
                .ValueGeneratedNever()
                .HasColumnName("enrollmentId");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.SemesterId).HasColumnName("semesterId");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__enrollmen__cours__36B12243");

            entity.HasOne(d => d.Semester).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.SemesterId)
                .HasConstraintName("FK__enrollmen__semes__37A5467C");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__enrollmen__stude__35BCFE0A");
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => new { e.EnrollmentId, e.AssessmentId }).HasName("PK__marks__90886EF110B320BB");

            entity.ToTable("marks");

            entity.Property(e => e.EnrollmentId).HasColumnName("enrollmentId");
            entity.Property(e => e.AssessmentId).HasColumnName("assessmentId");
            entity.Property(e => e.Mark1)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("mark");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");

            entity.HasOne(d => d.Assessment).WithMany(p => p.Marks)
                .HasForeignKey(d => d.AssessmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__marks__assessmen__3B75D760");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.Marks)
                .HasForeignKey(d => d.EnrollmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__marks__enrollmen__3A81B327");
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__semester__3213E83FF3DB724B");

            entity.ToTable("semesters");

            entity.HasIndex(e => e.Code, "UQ__semester__357D4CF98458B6E7").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BeginDate).HasColumnName("beginDate");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.EndDate).HasColumnName("endDate");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3213E83F48A7B1CE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Department)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Department)
                .HasConstraintName("FK__Students__depart__2F10007B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
