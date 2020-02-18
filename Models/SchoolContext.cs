using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace School.Models
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalSpaces> AdditionalSpaces { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<BuildingOwnership> BuildingOwnership { get; set; }
        public virtual DbSet<Contractor> Contractor { get; set; }
        public virtual DbSet<ContractorEnginner> ContractorEnginner { get; set; }
        public virtual DbSet<Dependency> Dependency { get; set; }
        public virtual DbSet<EducationDepartment> EducationDepartment { get; set; }
        public virtual DbSet<EducationType> EducationType { get; set; }
        public virtual DbSet<EducationalSpaces> EducationalSpaces { get; set; }
        public virtual DbSet<Extension> Extension { get; set; }
        public virtual DbSet<Fence> Fence { get; set; }
        public virtual DbSet<FoundationMethod> FoundationMethod { get; set; }
        public virtual DbSet<FoundationType> FoundationType { get; set; }
        public virtual DbSet<HostingState> HostingState { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<LandOwnership> LandOwnership { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<MaintenanceType> MaintenanceType { get; set; }
        public virtual DbSet<Periods> Periods { get; set; }
        public virtual DbSet<ProjectState> ProjectState { get; set; }
        public virtual DbSet<RegionalCentre> RegionalCentre { get; set; }
        public virtual DbSet<SchoolDetails> SchoolDetails { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Sewage> Sewage { get; set; }
        public virtual DbSet<SewageSupport> SewageSupport { get; set; }
        public virtual DbSet<Spaces> Spaces { get; set; }
        public virtual DbSet<SupervisorEngineer> SupervisorEngineer { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<Village> Village { get; set; }
        public virtual DbSet<Voltage> Voltage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning  To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=School;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AdditionalSpaces>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.SpacesId).HasColumnName("SpacesID");

                entity.HasOne(d => d.Spaces)
                    .WithMany(p => p.AdditionalSpaces)
                    .HasForeignKey(d => d.SpacesId)
                    .HasConstraintName("FK_AdditionalSpaces_Spaces");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BuilingOwnershipId).HasColumnName("BuilingOwnershipID");

                entity.Property(e => e.FenceId).HasColumnName("FenceID");

                entity.Property(e => e.FoundationMethodId).HasColumnName("FoundationMethodID");

                entity.Property(e => e.FoundationTypeId).HasColumnName("FoundationTypeID");

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.BuilingOwnership)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.BuilingOwnershipId)
                    .HasConstraintName("FK_Building_BuildingOwnership");

                entity.HasOne(d => d.Fence)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.FenceId)
                    .HasConstraintName("FK_Building_SchoolDetails");

                entity.HasOne(d => d.FoundationMethod)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.FoundationMethodId)
                    .HasConstraintName("FK_Building_FoundationMethod");

                entity.HasOne(d => d.FoundationType)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.FoundationTypeId)
                    .HasConstraintName("FK_Building_FoundationType");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Building)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Building_SchoolDetails1");
            });

            modelBuilder.Entity<BuildingOwnership>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Adress).HasMaxLength(10);

                entity.Property(e => e.ContractorEngineerId).HasColumnName("ContractorEngineerID");

                entity.Property(e => e.ContractorName).HasMaxLength(10);

                entity.Property(e => e.SupervisorEngineerId).HasColumnName("SupervisorEngineerID");

                entity.HasOne(d => d.ContractorEngineer)
                    .WithMany(p => p.Contractor)
                    .HasForeignKey(d => d.ContractorEngineerId)
                    .HasConstraintName("FK_Contractor_ContractorEnginner");

                entity.HasOne(d => d.SupervisorEngineer)
                    .WithMany(p => p.Contractor)
                    .HasForeignKey(d => d.SupervisorEngineerId)
                    .HasConstraintName("FK_Contractor_SupervisorEngineer");
            });

            modelBuilder.Entity<ContractorEnginner>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.ContractorEngineerName)
                    .HasColumnName("ContractorEngineer_Name")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Dependency>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<EducationDepartment>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.EducationDepartment)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_EducationDepartment_SchoolDetails");
            });

            modelBuilder.Entity<EducationType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<EducationalSpaces>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.SpacesId).HasColumnName("SpacesID");

                entity.HasOne(d => d.Spaces)
                    .WithMany(p => p.EducationalSpaces)
                    .HasForeignKey(d => d.SpacesId)
                    .HasConstraintName("FK_EducationalSpaces_Spaces");
            });

            modelBuilder.Entity<Extension>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.InitialDeliveryDate).HasColumnType("date");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.Supervision).HasMaxLength(10);

                entity.Property(e => e.SupervisorEngineerId).HasColumnName("SupervisorEngineerID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Extension)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Extension_SchoolDetails");

                entity.HasOne(d => d.SupervisorEngineer)
                    .WithMany(p => p.Extension)
                    .HasForeignKey(d => d.SupervisorEngineerId)
                    .HasConstraintName("FK_Extension_SupervisorEngineer1");
            });

            modelBuilder.Entity<Fence>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Fence1).HasColumnName("Fence");
            });

            modelBuilder.Entity<FoundationMethod>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Method).HasMaxLength(10);
            });

            modelBuilder.Entity<FoundationType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<HostingState>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.State).HasMaxLength(10);

                entity.HasOne(d => d.School)
                    .WithMany(p => p.HostingState)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_HostingState_SchoolDetails");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Pics).HasMaxLength(50);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Image_SchoolDetails");
            });

            modelBuilder.Entity<LandOwnership>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("landOwnership");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.LandOwnership)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_landOwnership_SchoolDetails");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("level");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InitaialDeliveryDate).HasColumnType("date");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.StartWorkDate).HasColumnType("date");

                entity.Property(e => e.StratWorkDate).HasColumnType("date");
            });

            modelBuilder.Entity<MaintenanceType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.Maintenance)
                    .WithMany(p => p.MaintenanceType)
                    .HasForeignKey(d => d.MaintenanceId)
                    .HasConstraintName("FK_MaintenanceType_Maintenance");
            });

            modelBuilder.Entity<Periods>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.PeriodsNavigation)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Periods_SchoolDetails");
            });

            modelBuilder.Entity<ProjectState>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.MintenaceId).HasColumnName("MintenaceID");

                entity.Property(e => e.State).HasMaxLength(10);

                entity.HasOne(d => d.Mintenace)
                    .WithMany(p => p.ProjectState)
                    .HasForeignKey(d => d.MintenaceId)
                    .HasConstraintName("FK_ProjectState_Maintenance");
            });

            modelBuilder.Entity<RegionalCentre>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.RegionalCentre)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_RegionalCentre_SchoolDetails");
            });

            modelBuilder.Entity<SchoolDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DependencyId).HasColumnName("DependencyID");

                entity.Property(e => e.EducationTypeId).HasColumnName("EducationTypeID");

                entity.Property(e => e.FloorArea).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GeneralLocationArea).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Periods).HasMaxLength(10);

                entity.Property(e => e.PreviousName).HasMaxLength(50);

                entity.Property(e => e.Purpose).HasMaxLength(10);

                entity.Property(e => e.SchoolFoundationDate).HasColumnType("date");

                entity.Property(e => e.Schoolownership).HasMaxLength(10);

                entity.Property(e => e.SpacesArea).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SquareArea).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SwageId).HasColumnName("SwageID");

                entity.Property(e => e.SwageSupportId).HasColumnName("SwageSupportID");

                entity.Property(e => e.VillageId).HasColumnName("VillageID");

                entity.Property(e => e.VoltageId).HasColumnName("VoltageID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_SchoolDetails_Branch");

                entity.HasOne(d => d.Dependency)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.DependencyId)
                    .HasConstraintName("FK_SchoolDetails_Dependency");

                entity.HasOne(d => d.EducationType)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.EducationTypeId)
                    .HasConstraintName("FK_SchoolDetails_EducationType");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_SchoolDetails_level");

                entity.HasOne(d => d.Maintenance)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.MaintenanceId)
                    .HasConstraintName("FK_SchoolDetails_Maintenance");

                entity.HasOne(d => d.Swage)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.SwageId)
                    .HasConstraintName("FK_SchoolDetails_Sewage");

                entity.HasOne(d => d.SwageSupport)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.SwageSupportId)
                    .HasConstraintName("FK_SchoolDetails_SewageSupport");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_SchoolDetails_Village");

                entity.HasOne(d => d.Voltage)
                    .WithMany(p => p.SchoolDetails)
                    .HasForeignKey(d => d.VoltageId)
                    .HasConstraintName("FK_SchoolDetails_Voltage");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Section)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Section_SchoolDetails");
            });

            modelBuilder.Entity<Sewage>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_Sanitation");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Sewage)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK_Sewage_Building");
            });

            modelBuilder.Entity<SewageSupport>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<Spaces>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Spaces)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Spaces_SchoolDetails");
            });

            modelBuilder.Entity<SupervisorEngineer>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.SuperviorEngineerName)
                    .HasColumnName("SuperviorEngineer_Name")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Supplies>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Supplies)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK_Supplies_Building");
            });

            modelBuilder.Entity<Village>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Voltage>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Voltage1)
                    .HasColumnName("Voltage")
                    .HasMaxLength(10);
            });
        }
    }
}
