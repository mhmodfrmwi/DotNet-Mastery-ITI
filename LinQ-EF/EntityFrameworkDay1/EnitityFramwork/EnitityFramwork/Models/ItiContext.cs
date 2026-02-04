using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EnitityFramwork.Models;

public partial class ItiContext : DbContext
{
    public ItiContext()
    {
    }

    public ItiContext(DbContextOptions<ItiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<DailyTransaction> DailyTransactions { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<InsCourse> InsCourses { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<JavaSdView> JavaSdViews { get; set; }

    public virtual DbSet<LastTransaction> LastTransactions { get; set; }

    public virtual DbSet<ManagerEncrView> ManagerEncrViews { get; set; }

    public virtual DbSet<StuView> StuViews { get; set; }

    public virtual DbSet<StudCourse> StudCourses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentAudit> StudentAudits { get; set; }

    public virtual DbSet<StudentV1> StudentV1s { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Tst> Tsts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-N5TCAKUS\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CrsId);

            entity.ToTable("Course");

            entity.Property(e => e.CrsId)
                .UseIdentityColumn()
                .HasColumnName("Crs_Id");
            entity.Property(e => e.CrsDuration).HasColumnName("Crs_Duration");
            entity.Property(e => e.CrsName)
                .HasMaxLength(50)
                .HasColumnName("Crs_Name");
            entity.Property(e => e.TopId).HasColumnName("Top_Id");

            entity.HasOne(d => d.Top).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TopId)
                .HasConstraintName("FK_Course_Topic");
        });

        modelBuilder.Entity<DailyTransaction>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__DailyTra__1788CCAC4362AB1C");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("Department", tb => tb.HasTrigger("prevTrigger"));

            entity.Property(e => e.DeptId)
                .ValueGeneratedNever()
                .HasColumnName("Dept_Id");
            entity.Property(e => e.DeptDesc)
                .HasMaxLength(100)
                .HasColumnName("Dept_Desc");
            entity.Property(e => e.DeptLocation)
                .HasMaxLength(50)
                .HasColumnName("Dept_Location");
            entity.Property(e => e.DeptManager).HasColumnName("Dept_Manager");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.ManagerHiredate).HasColumnName("Manager_hiredate");

            entity.HasOne(d => d.DeptManagerNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.DeptManager)
                .HasConstraintName("FK_Department_Instructor");
        });

        modelBuilder.Entity<InsCourse>(entity =>
        {
            entity.HasKey(e => new { e.InsId, e.CrsId });

            entity.ToTable("Ins_Course");

            entity.Property(e => e.InsId).HasColumnName("Ins_Id");
            entity.Property(e => e.CrsId).HasColumnName("Crs_Id");
            entity.Property(e => e.Evaluation).HasMaxLength(50);

            entity.HasOne(d => d.Crs).WithMany(p => p.InsCourses)
                .HasForeignKey(d => d.CrsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ins_Course_Course");

            entity.HasOne(d => d.Ins).WithMany(p => p.InsCourses)
                .HasForeignKey(d => d.InsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ins_Course_Instructor");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsId);

            entity.ToTable("Instructor");

            entity.Property(e => e.InsId)
                .ValueGeneratedNever()
                .HasColumnName("Ins_Id");
            entity.Property(e => e.DeptId).HasColumnName("Dept_Id");
            entity.Property(e => e.InsDegree)
                .HasMaxLength(50)
                .HasColumnName("Ins_Degree");
            entity.Property(e => e.InsName)
                .HasMaxLength(50)
                .HasColumnName("Ins_Name");
            entity.Property(e => e.Salary).HasColumnType("money");

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK_Instructor_Department");
        });

        modelBuilder.Entity<JavaSdView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("javaSdView");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.InsName)
                .HasMaxLength(50)
                .HasColumnName("Ins_Name");
        });

        modelBuilder.Entity<LastTransaction>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__LastTran__1788CCAC5FC2F8E2");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<ManagerEncrView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("managerEncrView");

            entity.Property(e => e.InsName)
                .HasMaxLength(50)
                .HasColumnName("Ins_Name");
            entity.Property(e => e.TopName)
                .HasMaxLength(50)
                .HasColumnName("Top_Name");
        });

        modelBuilder.Entity<StuView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stuView");

            entity.Property(e => e.CrsName)
                .HasMaxLength(50)
                .HasColumnName("Crs_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(61)
                .HasColumnName("full name");
        });

        modelBuilder.Entity<StudCourse>(entity =>
        {
            entity.HasKey(e => new { e.CrsId, e.StId });

            entity.ToTable("Stud_Course");

            entity.Property(e => e.CrsId).HasColumnName("Crs_Id");
            entity.Property(e => e.StId).HasColumnName("St_Id");

            entity.HasOne(d => d.Crs).WithMany(p => p.StudCourses)
                .HasForeignKey(d => d.CrsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stud_Course_Course");

            entity.HasOne(d => d.St).WithMany(p => p.StudCourses)
                .HasForeignKey(d => d.StId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stud_Course_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StId);

            entity.ToTable("Student", tb =>
                {
                    tb.HasTrigger("insertStudent");
                    tb.HasTrigger("instedOfDelete");
                });

            entity.Property(e => e.StId)
                .UseIdentityColumn()
                .HasColumnName("St_Id");
            entity.Property(e => e.DeptId).HasColumnName("Dept_Id");
            entity.Property(e => e.StAddress)
                .HasMaxLength(100)
                .HasColumnName("St_Address");
            entity.Property(e => e.StAge).HasColumnName("St_Age");
            entity.Property(e => e.StFname)
                .HasMaxLength(50)
                .HasColumnName("St_Fname");
            entity.Property(e => e.StLname)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("St_Lname");
            entity.Property(e => e.StSuper).HasColumnName("St_super");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK_Student_Department");

            entity.HasOne(d => d.StSuperNavigation).WithMany(p => p.InverseStSuperNavigation)
                .HasForeignKey(d => d.StSuper)
                .HasConstraintName("FK_Student_Student");
        });

        modelBuilder.Entity<StudentAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student_Audit");

            entity.Property(e => e.AuditDate)
                .HasColumnType("datetime")
                .HasColumnName("Audit_Date");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ServerUserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Server_User_Name");
        });

        modelBuilder.Entity<StudentV1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StudentV1");

            entity.Property(e => e.DeptId).HasColumnName("Dept_Id");
            entity.Property(e => e.StAddress)
                .HasMaxLength(100)
                .HasColumnName("St_Address");
            entity.Property(e => e.StAge).HasColumnName("St_Age");
            entity.Property(e => e.StFname)
                .HasMaxLength(50)
                .HasColumnName("St_Fname");
            entity.Property(e => e.StId).HasColumnName("St_Id");
            entity.Property(e => e.StLname)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("St_Lname");
            entity.Property(e => e.StSuper).HasColumnName("St_super");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.TopId);

            entity.ToTable("Topic");

            entity.Property(e => e.TopId)
                .ValueGeneratedNever()
                .HasColumnName("Top_Id");
            entity.Property(e => e.TopName)
                .HasMaxLength(50)
                .HasColumnName("Top_Name");
        });

        modelBuilder.Entity<Tst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tst");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
