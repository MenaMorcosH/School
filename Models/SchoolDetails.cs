using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class SchoolDetails
    {
        public SchoolDetails()
        {
            Building = new HashSet<Building>();
            EducationDepartment = new HashSet<EducationDepartment>();
            Extension = new HashSet<Extension>();
            HostingState = new HashSet<HostingState>();
            Image = new HashSet<Image>();
            LandOwnership = new HashSet<LandOwnership>();
            PeriodsNavigation = new HashSet<Periods>();
            RegionalCentre = new HashSet<RegionalCentre>();
            Section = new HashSet<Section>();
            Spaces = new HashSet<Spaces>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PreviousName { get; set; }
        public int? ClassNumber { get; set; }
        public int? AverageStudent { get; set; }
        public string Schoolownership { get; set; }
        public decimal? GeneralLocationArea { get; set; }
        public decimal? FloorArea { get; set; }
        public decimal? SquareArea { get; set; }
        public decimal? SpacesArea { get; set; }
        public int? ExtensionsNumber { get; set; }
        public DateTime? SchoolFoundationDate { get; set; }
        public int? GatesNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Periods { get; set; }
        public int? TotalStudents { get; set; }
        public int? Gils { get; set; }
        public int? Boys { get; set; }
        public string Purpose { get; set; }
        public int? VillageId { get; set; }
        public int? DependencyId { get; set; }
        public int? LevelId { get; set; }
        public int? EducationTypeId { get; set; }
        public int? SwageId { get; set; }
        public int? SwageSupportId { get; set; }
        public int? VoltageId { get; set; }
        public int? MaintenanceId { get; set; }
        public int? BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Dependency Dependency { get; set; }
        public virtual EducationType EducationType { get; set; }
        public virtual Level Level { get; set; }
        public virtual Maintenance Maintenance { get; set; }
        public virtual Sewage Swage { get; set; }
        public virtual SewageSupport SwageSupport { get; set; }
        public virtual Village Village { get; set; }
        public virtual Voltage Voltage { get; set; }
        public virtual ICollection<Building> Building { get; set; }
        public virtual ICollection<EducationDepartment> EducationDepartment { get; set; }
        public virtual ICollection<Extension> Extension { get; set; }
        public virtual ICollection<HostingState> HostingState { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<LandOwnership> LandOwnership { get; set; }
        public virtual ICollection<Periods> PeriodsNavigation { get; set; }
        public virtual ICollection<RegionalCentre> RegionalCentre { get; set; }
        public virtual ICollection<Section> Section { get; set; }
        public virtual ICollection<Spaces> Spaces { get; set; }
    }
}
