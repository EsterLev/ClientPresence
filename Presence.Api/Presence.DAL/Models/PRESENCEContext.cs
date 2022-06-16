using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Presence.DAL.Models
{
    public partial class PRESENCEContext : DbContext
    {
        public PRESENCEContext()
        {
        }

        public PRESENCEContext(DbContextOptions<PRESENCEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActingTeacher> ActingTeachers { get; set; }
        public virtual DbSet<Birthday> Birthdays { get; set; }
        public virtual DbSet<Connection> Connections { get; set; }
        public virtual DbSet<DelaySchoolBuse> DelaySchoolBuses { get; set; }
        public virtual DbSet<Kindergarten> Kindergartens { get; set; }
        public virtual DbSet<KindergartenPresence> KindergartenPresences { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<PresenceType> PresenceTypes { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<SchoolBuse> SchoolBuses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentsPresence> StudentsPresences { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersType> UsersTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-47JV62I;Database=PRESENCE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActingTeacher>(entity =>
            {
                entity.ToTable("ActingTeacher");

                entity.HasOne(d => d.Kindergarten)
                    .WithMany(p => p.ActingTeachers)
                    .HasForeignKey(d => d.KindergartenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActingTeacher_Kindergarten");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActingTeachers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActingTeacher_Users");
            });

            modelBuilder.Entity<Birthday>(entity =>
            {
                entity.HasOne(d => d.Kindergarten)
                    .WithMany(p => p.Birthdays)
                    .HasForeignKey(d => d.KindergartenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Birthdays_Kindergarten");
            });

            modelBuilder.Entity<Connection>(entity =>
            {
                entity.ToTable("Connection");

                entity.Property(e => e.Sms).HasColumnName("SMS");
            });

            modelBuilder.Entity<DelaySchoolBuse>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Escort)
                    .WithMany(p => p.DelaySchoolBuses)
                    .HasForeignKey(d => d.EscortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DelaySchoolBuses_Users");

                entity.HasOne(d => d.SchoolBus)
                    .WithMany(p => p.DelaySchoolBuses)
                    .HasForeignKey(d => d.SchoolBusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DelaySchoolBuses_SchoolBuses");
            });

            modelBuilder.Entity<Kindergarten>(entity =>
            {
                entity.ToTable("Kindergarten");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Kindergartens)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kindergarten_Users");
            });

            modelBuilder.Entity<KindergartenPresence>(entity =>
            {
                entity.ToTable("KindergartenPresence");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Kindergarten)
                    .WithMany(p => p.KindergartenPresences)
                    .HasForeignKey(d => d.KindergartenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KindergartenPresence_Kindergarten");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.KindergartenPresences)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KindergartenPresence_Users");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasOne(d => d.Connection)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.ConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Parents__Connect__44FF419A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Parents_Users");
            });

            modelBuilder.Entity<PresenceType>(entity =>
            {
                entity.ToTable("PresenceType");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.HasOne(d => d.Kindergarten)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.KindergartenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reminders_Kindergarten");
            });

            modelBuilder.Entity<SchoolBuse>(entity =>
            {
                entity.HasOne(d => d.Escort)
                    .WithMany(p => p.SchoolBuses)
                    .HasForeignKey(d => d.EscortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolBuses_Users");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Father)
                    .WithMany(p => p.StudentFathers)
                    .HasForeignKey(d => d.FatherId)
                    .HasConstraintName("FK_Students_Parents_Father");

                entity.HasOne(d => d.Kindergarten)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.KindergartenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Kindergarten");

                entity.HasOne(d => d.Mother)
                    .WithMany(p => p.StudentMothers)
                    .HasForeignKey(d => d.MotherId)
                    .HasConstraintName("FK_Students_Parents_Mother");

                entity.HasOne(d => d.SchoolBus)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.SchoolBusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_SchoolBuses");
            });

            modelBuilder.Entity<StudentsPresence>(entity =>
            {
                entity.ToTable("StudentsPresence");

                entity.HasOne(d => d.KindergartenPresence)
                    .WithMany(p => p.StudentsPresences)
                    .HasForeignKey(d => d.KindergartenPresenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentsPresence_KindergartenPresence");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentsPresences)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentsPresence_Students");

                entity.HasOne(d => d.TypePresenceNavigation)
                    .WithMany(p => p.StudentsPresences)
                    .HasForeignKey(d => d.TypePresence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentsPresence_PresenceType");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UsersTypes");
            });

            modelBuilder.Entity<UsersType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
