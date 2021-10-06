using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LeaveManagement.DB
{
    public partial class hrms_stagingContext : DbContext
    {
        public hrms_stagingContext()
        {
        }

        public hrms_stagingContext(DbContextOptions<hrms_stagingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsenteesCount> AbsenteesCount { get; set; }
        public virtual DbSet<AcceptAnnouncement> AcceptAnnouncement { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<AppraisalCycle> AppraisalCycle { get; set; }
        public virtual DbSet<AppraisalInterval> AppraisalInterval { get; set; }
        public virtual DbSet<AssessmentCriteria> AssessmentCriteria { get; set; }
        public virtual DbSet<AssessmentRevision> AssessmentRevision { get; set; }
        public virtual DbSet<ChangedEmployeeDepartment> ChangedEmployeeDepartment { get; set; }
        public virtual DbSet<Dates> Dates { get; set; }
        public virtual DbSet<EmpCertification> EmpCertification { get; set; }
        public virtual DbSet<EmpDependent> EmpDependent { get; set; }
        public virtual DbSet<EmpDocument> EmpDocument { get; set; }
        public virtual DbSet<EmpEducation> EmpEducation { get; set; }
        public virtual DbSet<EmpExperience> EmpExperience { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRole { get; set; }
        public virtual DbSet<EmpTechnicalSkill> EmpTechnicalSkill { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<FaqCategory> FaqCategory { get; set; }
        public virtual DbSet<LeaveBalance> LeaveBalance { get; set; }
        public virtual DbSet<LeavesQuota> LeavesQuota { get; set; }
        public virtual DbSet<LeaveStatus> LeaveStatus { get; set; }
        public virtual DbSet<MobileAppUpdateTable> MobileAppUpdateTable { get; set; }
        public virtual DbSet<ModulePermission> ModulePermission { get; set; }
        public virtual DbSet<PerformanceAppraisal> PerformanceAppraisal { get; set; }
        public virtual DbSet<PerformanceEvaluation> PerformanceEvaluation { get; set; }
        public virtual DbSet<ReminderAlert> ReminderAlert { get; set; }
        public virtual DbSet<ReminderLeave> ReminderLeave { get; set; }
        public virtual DbSet<TbActionTakens> TbActionTakens { get; set; }
        public virtual DbSet<TbApplicationEvents> TbApplicationEvents { get; set; }
        public virtual DbSet<TbChangeDesignation> TbChangeDesignation { get; set; }
        public virtual DbSet<TbDocumentType> TbDocumentType { get; set; }
        public virtual DbSet<TbEmailFailureRecords> TbEmailFailureRecords { get; set; }
        public virtual DbSet<TbEmailQueue> TbEmailQueue { get; set; }
        public virtual DbSet<TbEmployeeAddresses> TbEmployeeAddresses { get; set; }
        public virtual DbSet<TbEmployeeAppraisalRecords> TbEmployeeAppraisalRecords { get; set; }
        public virtual DbSet<TbEmployeeBankAndPfrecord> TbEmployeeBankAndPfrecord { get; set; }
        public virtual DbSet<TbEmployeeExitRecord> TbEmployeeExitRecord { get; set; }
        public virtual DbSet<TbEmployeeRefrences> TbEmployeeRefrences { get; set; }
        public virtual DbSet<TbEmployeeStatusEvents> TbEmployeeStatusEvents { get; set; }
        public virtual DbSet<TbEmployeeStatusRecord> TbEmployeeStatusRecord { get; set; }
        public virtual DbSet<TblAccessCardData> TblAccessCardData { get; set; }
        public virtual DbSet<TblAccessCardEmployees> TblAccessCardEmployees { get; set; }
        public virtual DbSet<TblAccessCardEvents> TblAccessCardEvents { get; set; }
        public virtual DbSet<TblAllEmployeesCustomLeaveReport> TblAllEmployeesCustomLeaveReport { get; set; }
        public virtual DbSet<TblAllEmployeesLeaveDetails> TblAllEmployeesLeaveDetails { get; set; }
        public virtual DbSet<TblDiGeoStates> TblDiGeoStates { get; set; }
        public virtual DbSet<TblEAppraisalRating> TblEAppraisalRating { get; set; }
        public virtual DbSet<TblEBanks> TblEBanks { get; set; }
        public virtual DbSet<TblEBloodGroup> TblEBloodGroup { get; set; }
        public virtual DbSet<TblECalendarHoliday> TblECalendarHoliday { get; set; }
        public virtual DbSet<TblECertification> TblECertification { get; set; }
        public virtual DbSet<TblEDepartment> TblEDepartment { get; set; }
        public virtual DbSet<TblEDesignation> TblEDesignation { get; set; }
        public virtual DbSet<TblEEmploymentStatus> TblEEmploymentStatus { get; set; }
        public virtual DbSet<TblEEmpType> TblEEmpType { get; set; }
        public virtual DbSet<TblEExitStatus> TblEExitStatus { get; set; }
        public virtual DbSet<TblEGrade> TblEGrade { get; set; }
        public virtual DbSet<TblELeaveType> TblELeaveType { get; set; }
        public virtual DbSet<TblEModule> TblEModule { get; set; }
        public virtual DbSet<TblEmployeeProbationDetails> TblEmployeeProbationDetails { get; set; }
        public virtual DbSet<TblEPolicyCategory> TblEPolicyCategory { get; set; }
        public virtual DbSet<TblERelationship> TblERelationship { get; set; }
        public virtual DbSet<TblERole> TblERole { get; set; }
        public virtual DbSet<TblEStatus> TblEStatus { get; set; }
        public virtual DbSet<TblETechnicalskills> TblETechnicalskills { get; set; }
        public virtual DbSet<TblExceptionLogger> TblExceptionLogger { get; set; }
        public virtual DbSet<TblUrl> TblUrl { get; set; }
        public virtual DbSet<TbNoticePeriod> TbNoticePeriod { get; set; }
        public virtual DbSet<TbPolicy> TbPolicy { get; set; }
        public virtual DbSet<TbTemplates> TbTemplates { get; set; }
        public virtual DbSet<TlAcceptEthics> TlAcceptEthics { get; set; }
        public virtual DbSet<TlAnnouncement> TlAnnouncement { get; set; }
        public virtual DbSet<TlAnnouncementAccept> TlAnnouncementAccept { get; set; }
        public virtual DbSet<TlEthics> TlEthics { get; set; }
        public virtual DbSet<TlLateComing> TlLateComing { get; set; }
        public virtual DbSet<TlTimeLog> TlTimeLog { get; set; }
        public virtual DbSet<UpdatedDoj> UpdatedDoj { get; set; }

        // Unable to generate entity type for table 'dbo.tbl_H_AcceptEthics'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmpCertification'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmpDependent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmpDocument'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmpEducation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmpExperience'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_Employee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmployeeRole'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_EmpTechnicalSkill'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_LeaveStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_H_TimeLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTime'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_DI_ConsultCharges'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.0.28;Database=hrms_staging;user id=soft;password=Qwerty!@#456;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbsenteesCount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.EmailBody).IsUnicode(false);
            });

            modelBuilder.Entity<AcceptAnnouncement>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AcceptDateTime).HasColumnType("datetime");

                entity.Property(e => e.FkAnnouncement).HasColumnName("fkAnnouncement");

                entity.Property(e => e.FkEmp).HasColumnName("fkEmp");

                entity.HasOne(d => d.FkAnnouncementNavigation)
                    .WithMany(p => p.AcceptAnnouncement)
                    .HasForeignKey(d => d.FkAnnouncement)
                    .HasConstraintName("FK_AcceptAnnouncement_Announcement1");

                entity.HasOne(d => d.FkEmpNavigation)
                    .WithMany(p => p.AcceptAnnouncement)
                    .HasForeignKey(d => d.FkEmp)
                    .HasConstraintName("FK_AcceptAnnouncement_Announcement");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<AcceptAnnouncement>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcceptAnnouncement_AcceptAnnouncement");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnnouncementContent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AnnouncementDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppraisalCycle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JoinMonth1).HasColumnName("Join_Month1");

                entity.Property(e => e.JoinMonth2).HasColumnName("Join_Month2");

                entity.Property(e => e.JoinMonth3).HasColumnName("Join_Month3");

                entity.Property(e => e.NextAppraisalMonth).HasColumnName("Next_Appraisal_Month");
            });

            modelBuilder.Entity<AppraisalInterval>(entity =>
            {
                entity.HasKey(e => e.FkGrade);

                entity.Property(e => e.FkGrade)
                    .HasColumnName("fkGrade")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.FkGradeNavigation)
                    .WithOne(p => p.AppraisalInterval)
                    .HasForeignKey<AppraisalInterval>(d => d.FkGrade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_E_Grade48");
            });

            modelBuilder.Entity<AssessmentCriteria>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FkAssessmentRevision).HasColumnName("fkAssessmentRevision");

                entity.Property(e => e.FkGrade).HasColumnName("fkGrade");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkAssessmentRevisionNavigation)
                    .WithMany(p => p.AssessmentCriteria)
                    .HasForeignKey(d => d.FkAssessmentRevision)
                    .HasConstraintName("RefAssessmentRevision45");

                entity.HasOne(d => d.FkGradeNavigation)
                    .WithMany(p => p.AssessmentCriteria)
                    .HasForeignKey(d => d.FkGrade)
                    .HasConstraintName("Reftbl_E_Grade41");
            });

            modelBuilder.Entity<AssessmentRevision>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RevisionCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChangedEmployeeDepartment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((169))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.NewDeptId).HasColumnName("NewDeptID");

                entity.Property(e => e.OldDeptId).HasColumnName("OldDeptID");
            });

            modelBuilder.Entity<Dates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dates1)
                    .HasColumnName("Dates")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<EmpCertification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkCertification).HasColumnName("fkCertification");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.Institution)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PercentSecured).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkCertificationNavigation)
                    .WithMany(p => p.EmpCertification)
                    .HasForeignKey(d => d.FkCertification)
                    .HasConstraintName("Reftbl_E_Certification51");
            });

            modelBuilder.Entity<EmpDependent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DependentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DependentContactNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DependentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkRelationship).HasColumnName("fkRelationship");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkRelationshipNavigation)
                    .WithMany(p => p.EmpDependent)
                    .HasForeignKey(d => d.FkRelationship)
                    .HasConstraintName("Reftbl_E_Relationship40");
            });

            modelBuilder.Entity<EmpDocument>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkDocumentType).HasColumnName("fkDocumentType");

                entity.Property(e => e.FkEmployeeId).HasColumnName("fkEmployeeID");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkDocumentTypeNavigation)
                    .WithMany(p => p.EmpDocument)
                    .HasForeignKey(d => d.FkDocumentType)
                    .HasConstraintName("FK_EmpDocument_tb_DocumentType");
            });

            modelBuilder.Entity<EmpEducation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DegreeCertification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FromDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PercentSecured).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpExperience>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyAddress).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Employer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NatureofDuties).HasMaxLength(500);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.EmpId)
                    .HasName("Emp_Id_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalDueOn)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmationdate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.DrivingLicienceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("Emp_Code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExitComment)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExitDate).HasColumnType("datetime");

                entity.Property(e => e.ExtNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FkBloodGroup).HasColumnName("fkBloodGroup");

                entity.Property(e => e.FkDepartment).HasColumnName("fkDepartment");

                entity.Property(e => e.FkDesignation).HasColumnName("fkDesignation");

                entity.Property(e => e.FkEmpGrade).HasColumnName("fkEmpGrade");

                entity.Property(e => e.FkEmpType).HasColumnName("fkEmpType");

                entity.Property(e => e.FkEmploymentStatus).HasColumnName("fkEmploymentStatus");

                entity.Property(e => e.FkExitStatus).HasColumnName("fkExitStatus");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([fname]+' ')+[lname])");

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GtalkId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HiringSource)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LoginPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MachineIpAddress)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Msnid)
                    .HasColumnName("MSNId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutlookId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassportExpiry).HasColumnType("datetime");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(280)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(280)
                    .IsUnicode(false);

                entity.Property(e => e.PriorExperience).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.RefCompany1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefCompany2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefCompany3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefContactNo1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefContactNo2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefContactNo3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefDesignation1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefDesignation2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefDesignation3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefEmail1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefEmail2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefEmail3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefName1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefName2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefName3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RelevantExperience).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.SalAccNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SkypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SparkId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tfmp)
                    .HasColumnName("TFMP")
                    .HasMaxLength(20);

                entity.Property(e => e.TrainingDuration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Userip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisaExpiry).HasColumnType("datetime");

                entity.Property(e => e.VisaNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.WeddingDate).HasColumnType("datetime");

                entity.Property(e => e.YahooId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkBloodGroupNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkBloodGroup)
                    .HasConstraintName("Reftbl_E_BloodGroup");

                entity.HasOne(d => d.FkDepartmentNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkDepartment)
                    .HasConstraintName("FK_Employee_tbl_E_Department");

                entity.HasOne(d => d.FkDesignationNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkDesignation)
                    .HasConstraintName("fk_tb_E_Resignation");

                entity.HasOne(d => d.FkEmpGradeNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkEmpGrade)
                    .HasConstraintName("Reftbl_E_Grade29");

                entity.HasOne(d => d.FkEmpTypeNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkEmpType)
                    .HasConstraintName("Reftbl_E_EmpType16");

                entity.HasOne(d => d.FkEmploymentStatusNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkEmploymentStatus)
                    .HasConstraintName("FK_Employee_tbl_E_EmploymentStatus");

                entity.HasOne(d => d.FkExitStatusNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FkExitStatus)
                    .HasConstraintName("Reftbl_E_ExitStatus");
            });

            modelBuilder.Entity<EmployeeRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkRole).HasColumnName("fkRole");

                entity.HasOne(d => d.FkRoleNavigation)
                    .WithMany(p => p.EmployeeRole)
                    .HasForeignKey(d => d.FkRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_E_Role24");
            });

            modelBuilder.Entity<EmpTechnicalSkill>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkTechnicalSkill).HasColumnName("fkTechnicalSkill");

                entity.Property(e => e.LastUsed).HasColumnType("datetime");

                entity.Property(e => e.TotalExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkTechnicalSkillNavigation)
                    .WithMany(p => p.EmpTechnicalSkill)
                    .HasForeignKey(d => d.FkTechnicalSkill)
                    .HasConstraintName("Reftbl_E_Technicalskills39");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkFaqCategory).HasColumnName("fkFaqCategory");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPublished).HasDefaultValueSql("((0))");

                entity.Property(e => e.Question)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.ViewedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkFaqCategoryNavigation)
                    .WithMany(p => p.Faq)
                    .HasForeignKey(d => d.FkFaqCategory)
                    .HasConstraintName("FK_FaqCategory_Faq");
            });

            modelBuilder.Entity<FaqCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveBalance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDateMonth).HasColumnType("date");

                entity.Property(e => e.StartDateMonth).HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<LeavesQuota>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkLeaveType).HasColumnName("fkLeaveType");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.HasOne(d => d.FkLeaveTypeNavigation)
                    .WithMany(p => p.LeavesQuota)
                    .HasForeignKey(d => d.FkLeaveType)
                    .HasConstraintName("Reftbl_E_LeaveType31");
            });

            modelBuilder.Entity<LeaveStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminComment)
                    .HasColumnName("Admin_Comment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Elc)
                    .HasColumnName("ELC")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLineManagerId)
                    .HasColumnName("FirstLineManager_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLineMangerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FkLeaveType).HasColumnName("fkLeaveType");

                entity.Property(e => e.Fldecisiondate)
                    .HasColumnName("FLDecisiondate")
                    .HasColumnType("date");

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HrComment)
                    .HasColumnName("Hr_Comment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HrId)
                    .HasColumnName("Hr_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HrStatus).HasColumnName("Hr_Status");

                entity.Property(e => e.Hrrdecisiondate)
                    .HasColumnName("HRRDecisiondate")
                    .HasColumnType("date");

                entity.Property(e => e.IsElcflag)
                    .HasColumnName("IsELCFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLwp).HasColumnName("IsLWP");

                entity.Property(e => e.LeaveAppliedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveReason)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLineManagerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLineManagerId)
                    .HasColumnName("SecondLineManager_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sldecisiondate)
                    .HasColumnName("SLDecisiondate")
                    .HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");

                entity.HasOne(d => d.FkLeaveTypeNavigation)
                    .WithMany(p => p.LeaveStatus)
                    .HasForeignKey(d => d.FkLeaveType)
                    .HasConstraintName("FK_LeaveStatus_tbl_E_LeaveType");
            });

            modelBuilder.Entity<MobileAppUpdateTable>(entity =>
            {
                entity.ToTable("mobile_app_update_table");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PreviousVersionFileLinkAndroid).HasMaxLength(250);

                entity.Property(e => e.PreviousVersionFileLinkIos)
                    .HasColumnName("PreviousVersionFileLinkIOS")
                    .HasMaxLength(250);

                entity.Property(e => e.VersionFileLinkAndroid).HasMaxLength(250);

                entity.Property(e => e.VersionFileLinkIos)
                    .HasColumnName("VersionFileLinkIOS")
                    .HasMaxLength(250);

                entity.Property(e => e.VersionMessageText).HasColumnType("text");

                entity.Property(e => e.VersionNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<ModulePermission>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkModule).HasColumnName("fkModule");

                entity.Property(e => e.FkRole).HasColumnName("fkRole");

                entity.HasOne(d => d.FkModuleNavigation)
                    .WithMany(p => p.ModulePermission)
                    .HasForeignKey(d => d.FkModule)
                    .HasConstraintName("Reftbl_E_Module25");

                entity.HasOne(d => d.FkRoleNavigation)
                    .WithMany(p => p.ModulePermission)
                    .HasForeignKey(d => d.FkRole)
                    .HasConstraintName("Reftbl_E_Role26");
            });

            modelBuilder.Entity<PerformanceAppraisal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalComment)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisedCtc).HasColumnName("AppraisedCTC");

                entity.Property(e => e.CurrentCtc).HasColumnName("CurrentCTC");

                entity.Property(e => e.EmployeeComment)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.FkAppraisalRating).HasColumnName("fkAppraisalRating");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.NextAppraisalDueOn).HasColumnType("datetime");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewPeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.ReviewPeriodTo).HasColumnType("datetime");

                entity.Property(e => e.ReviewedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkAppraisalRatingNavigation)
                    .WithMany(p => p.PerformanceAppraisal)
                    .HasForeignKey(d => d.FkAppraisalRating)
                    .HasConstraintName("Reftbl_E_AppraisalRating33");
            });

            modelBuilder.Entity<PerformanceEvaluation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkAssessmentCriteria).HasColumnName("fkAssessmentCriteria");

                entity.Property(e => e.FkPerformanceAppraisal).HasColumnName("fkPerformanceAppraisal");

                entity.Property(e => e.ReviewerComment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SelfComment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkAssessmentCriteriaNavigation)
                    .WithMany(p => p.PerformanceEvaluation)
                    .HasForeignKey(d => d.FkAssessmentCriteria)
                    .HasConstraintName("RefAssessmentCriteria44");

                entity.HasOne(d => d.FkPerformanceAppraisalNavigation)
                    .WithMany(p => p.PerformanceEvaluation)
                    .HasForeignKey(d => d.FkPerformanceAppraisal)
                    .HasConstraintName("RefPerformanceAppraisal43");

                entity.HasOne(d => d.ReviewerRatingNavigation)
                    .WithMany(p => p.PerformanceEvaluationReviewerRatingNavigation)
                    .HasForeignKey(d => d.ReviewerRating)
                    .HasConstraintName("Reftbl_E_AppraisalRating47");

                entity.HasOne(d => d.SelfRatingNavigation)
                    .WithMany(p => p.PerformanceEvaluationSelfRatingNavigation)
                    .HasForeignKey(d => d.SelfRating)
                    .HasConstraintName("Reftbl_E_AppraisalRating46");
            });

            modelBuilder.Entity<ReminderAlert>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");
            });

            modelBuilder.Entity<ReminderLeave>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.FkLeavestatus).HasColumnName("fkLeavestatus");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineManager)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkLeavestatusNavigation)
                    .WithMany(p => p.ReminderLeave)
                    .HasForeignKey(d => d.FkLeavestatus)
                    .HasConstraintName("FK_ReminderLeave_LeaveStatus");
            });

            modelBuilder.Entity<TbActionTakens>(entity =>
            {
                entity.ToTable("tbActionTakens");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.HasOne(d => d.ActionTakenByNavigation)
                    .WithMany(p => p.TbActionTakens)
                    .HasForeignKey(d => d.ActionTakenBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbActionTakens_Employee");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.TbActionTakens)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("FK_tbActionTakens_tbEmailQueue");
            });

            modelBuilder.Entity<TbApplicationEvents>(entity =>
            {
                entity.ToTable("tbApplicationEvents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbChangeDesignation>(entity =>
            {
                entity.ToTable("tb_ChangeDesignation");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Experience)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeId");

                entity.Property(e => e.FknewDesignation).HasColumnName("FKNewDesignation");

                entity.Property(e => e.FknewGrade).HasColumnName("FKNewGrade");

                entity.Property(e => e.FkoldDesignation).HasColumnName("FKOldDesignation");

                entity.Property(e => e.FkoldGrade).HasColumnName("FKOldGrade");

                entity.HasOne(d => d.FkoldDesignationNavigation)
                    .WithMany(p => p.TbChangeDesignation)
                    .HasForeignKey(d => d.FkoldDesignation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_ChangeDesignation_tbl_E_Designation");
            });

            modelBuilder.Entity<TbDocumentType>(entity =>
            {
                entity.ToTable("tb_DocumentType");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TbEmailFailureRecords>(entity =>
            {
                entity.ToTable("tbEmailFailureRecords");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FailureRecords)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.QueueId).HasColumnName("QueueID");

                entity.HasOne(d => d.Queue)
                    .WithMany(p => p.TbEmailFailureRecords)
                    .HasForeignKey(d => d.QueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmailFailureRecords_tbEmailQueue");
            });

            modelBuilder.Entity<TbEmailQueue>(entity =>
            {
                entity.ToTable("tbEmailQueue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailSentAt).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.PendingDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TbEmailQueue)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmailQueue_Employee");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TbEmailQueue)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmailQueue_tbApplicationEvents");
            });

            modelBuilder.Entity<TbEmployeeAddresses>(entity =>
            {
                entity.ToTable("tbEmployeeAddresses");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Ext)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeAddresses)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPresentAddresses_Employee");
            });

            modelBuilder.Entity<TbEmployeeAppraisalRecords>(entity =>
            {
                entity.ToTable("tbEmployeeAppraisalRecords");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalCycle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisalDueOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Fkdepartment).HasColumnName("FKDepartment");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkdepartmentNavigation)
                    .WithMany(p => p.TbEmployeeAppraisalRecords)
                    .HasForeignKey(d => d.Fkdepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmployeeAppraisalRecords_tbl_E_Department");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeAppraisalRecords)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmployeeAppraisalRecords_Employee");
            });

            modelBuilder.Entity<TbEmployeeBankAndPfrecord>(entity =>
            {
                entity.ToTable("tbEmployeeBankAndPFRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasMaxLength(20);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Branch).HasMaxLength(200);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Esinumber)
                    .HasColumnName("ESINumber")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyPfnumber)
                    .HasColumnName("FamilyPFNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Fkbank).HasColumnName("FKBank");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.IsEpfexcessContribution).HasColumnName("IsEPFExcessContribution");

                entity.Property(e => e.IsEpsexcessContribution).HasColumnName("IsEPSExcessContribution");

                entity.Property(e => e.IsEsischeme).HasColumnName("IsESIScheme");

                entity.Property(e => e.IsPfscheme).HasColumnName("IsPFScheme");

                entity.Property(e => e.Isfccode)
                    .HasColumnName("ISFCCode")
                    .HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PayableAt).HasMaxLength(100);

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.PfjoinDate)
                    .HasColumnName("PFJoinDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pfnumber)
                    .HasColumnName("PFNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Pfscheme)
                    .HasColumnName("PFScheme")
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkbankNavigation)
                    .WithMany(p => p.TbEmployeeBankAndPfrecord)
                    .HasForeignKey(d => d.Fkbank)
                    .HasConstraintName("FK_tbEmployeeBankAndPFRecord_tbl_E_Banks");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeBankAndPfrecord)
                    .HasForeignKey(d => d.Fkemployee)
                    .HasConstraintName("FK_tbEmployeeBankAndPFRecord_Employee");
            });

            modelBuilder.Entity<TbEmployeeExitRecord>(entity =>
            {
                entity.ToTable("tbEmployeeExitRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DemiseDate).HasColumnType("datetime");

                entity.Property(e => e.ExitInterviewDate).HasColumnType("datetime");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FinalSettlementDate).HasColumnType("datetime");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.LeavingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelieveDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ResignationDate).HasColumnType("datetime");

                entity.Property(e => e.RetireDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeExitRecord)
                    .HasForeignKey(d => d.Fkemployee)
                    .HasConstraintName("FK_tbEmployeeExitRecord_Employee");

                entity.HasOne(d => d.LeavingReasonNavigation)
                    .WithMany(p => p.TbEmployeeExitRecord)
                    .HasForeignKey(d => d.LeavingReason)
                    .HasConstraintName("FK_tbEmployeeExitRecord_tbl_E_ExitStatus");
            });

            modelBuilder.Entity<TbEmployeeRefrences>(entity =>
            {
                entity.ToTable("tbEmployeeRefrences");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeRefrences)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmployeeRefrences_tbEmployeeRefrences");
            });

            modelBuilder.Entity<TbEmployeeStatusEvents>(entity =>
            {
                entity.ToTable("tbEmployeeStatusEvents");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TbEmployeeStatusRecord>(entity =>
            {
                entity.ToTable("tbEmployeeStatusRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExitStatus).HasMaxLength(50);

                entity.Property(e => e.Fkdepartment).HasColumnName("FKDepartment");

                entity.Property(e => e.Fkdesignation).HasColumnName("FKDesignation");

                entity.Property(e => e.FkempType).HasColumnName("FKEmpType");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.FkemploymentStatus).HasColumnName("FKEmploymentStatus");

                entity.Property(e => e.Fkgrade).HasColumnName("FKGrade");

                entity.HasOne(d => d.EventRecordNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecord)
                    .HasForeignKey(d => d.EventRecord)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbEmployeeStatusEvents");

                entity.HasOne(d => d.FkdesignationNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecord)
                    .HasForeignKey(d => d.Fkdesignation)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_Designation");

                entity.HasOne(d => d.FkempTypeNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecord)
                    .HasForeignKey(d => d.FkempType)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_EmpType");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecord)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_Employee");

                entity.HasOne(d => d.FkemploymentStatusNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecord)
                    .HasForeignKey(d => d.FkemploymentStatus)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_Status");

                entity.HasOne(d => d.FkgradeNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecord)
                    .HasForeignKey(d => d.Fkgrade)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_Grade");
            });

            modelBuilder.Entity<TblAccessCardData>(entity =>
            {
                entity.ToTable("tbl_AccessCardData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAccessCardEmployees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_AccessCardEmployees");

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.CardNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccessCardEvents>(entity =>
            {
                entity.ToTable("tbl_AccessCardEvents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoorId).HasColumnName("DoorID");

                entity.Property(e => e.DoorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EventCh)
                    .HasColumnName("EventCH")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAllEmployeesCustomLeaveReport>(entity =>
            {
                entity.ToTable("tbl_AllEmployeesCustomLeaveReport");

                entity.Property(e => e.CasualLeavesTaken).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lwptaken)
                    .HasColumnName("LWPTaken")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PaidLeavesTaken).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.SickLeavesTaken).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.TotalAllocatedLeaves).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.TotalLeavesTaken).HasColumnType("decimal(5, 1)");
            });

            modelBuilder.Entity<TblAllEmployeesLeaveDetails>(entity =>
            {
                entity.ToTable("tbl_AllEmployeesLeaveDetails");

                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.ConfirmationStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasMaxLength(100);

                entity.Property(e => e.Designation).HasMaxLength(100);

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("date");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.LeaveBalanceCl)
                    .HasColumnName("LeaveBalance_CL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalancePl)
                    .HasColumnName("LeaveBalance_PL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalanceSl)
                    .HasColumnName("LeaveBalance_SL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalanceTl)
                    .HasColumnName("LeaveBalance_TL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalancefornexttenureCl)
                    .HasColumnName("Leave Balancefornexttenure_CL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalancefornexttenurePl)
                    .HasColumnName("Leave Balancefornexttenure_PL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalancefornexttenureSl)
                    .HasColumnName("Leave Balancefornexttenure_SL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveBalancefornexttenureTl)
                    .HasColumnName("Leave Balancefornexttenure_TL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveTakenCl)
                    .HasColumnName("LeaveTaken_CL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveTakenPl)
                    .HasColumnName("LeaveTaken_PL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveTakenSl)
                    .HasColumnName("LeaveTaken_SL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.LeaveTakenTl)
                    .HasColumnName("LeaveTaken_TL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Lwpleave)
                    .HasColumnName("LWPLeave")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PayableDays).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TotalDays).HasColumnType("decimal(5, 2)");

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._11)
                    .HasColumnName("11")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._12)
                    .HasColumnName("12")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._13)
                    .HasColumnName("13")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._14)
                    .HasColumnName("14")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._15)
                    .HasColumnName("15")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._16)
                    .HasColumnName("16")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._17)
                    .HasColumnName("17")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._18)
                    .HasColumnName("18")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._19)
                    .HasColumnName("19")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._20)
                    .HasColumnName("20")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._21)
                    .HasColumnName("21")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._22)
                    .HasColumnName("22")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._23)
                    .HasColumnName("23")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._24)
                    .HasColumnName("24")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._25)
                    .HasColumnName("25")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._26)
                    .HasColumnName("26")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._27)
                    .HasColumnName("27")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._28)
                    .HasColumnName("28")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._29)
                    .HasColumnName("29")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._30)
                    .HasColumnName("30")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._31)
                    .HasColumnName("31")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDiGeoStates>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("tbl_DI_Geo_States");

                entity.Property(e => e.StateId).HasColumnName("State_Id");

                entity.Property(e => e.FkCountryId).HasColumnName("fk_Country_Id");

                entity.Property(e => e.StateName).HasColumnName("State_Name");
            });

            modelBuilder.Entity<TblEAppraisalRating>(entity =>
            {
                entity.ToTable("tbl_E_AppraisalRating");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalMetric)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEBanks>(entity =>
            {
                entity.ToTable("tbl_E_Banks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankName).HasMaxLength(300);
            });

            modelBuilder.Entity<TblEBloodGroup>(entity =>
            {
                entity.ToTable("tbl_E_BloodGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblECalendarHoliday>(entity =>
            {
                entity.ToTable("tbl_E_CalendarHoliday");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OccasionDate).HasColumnType("datetime");

                entity.Property(e => e.OccasionName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblECertification>(entity =>
            {
                entity.ToTable("tbl_E_Certification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEDepartment>(entity =>
            {
                entity.ToTable("tbl_E_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentHead)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<TblEDesignation>(entity =>
            {
                entity.ToTable("tbl_E_Designation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEEmploymentStatus>(entity =>
            {
                entity.ToTable("tbl_E_EmploymentStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEEmpType>(entity =>
            {
                entity.ToTable("tbl_E_EmpType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEExitStatus>(entity =>
            {
                entity.ToTable("tbl_E_ExitStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEGrade>(entity =>
            {
                entity.ToTable("tbl_E_Grade");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblELeaveType>(entity =>
            {
                entity.ToTable("tbl_E_LeaveType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEModule>(entity =>
            {
                entity.ToTable("tbl_E_Module");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeProbationDetails>(entity =>
            {
                entity.ToTable("tbl_EmployeeProbationDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDoj)
                    .HasColumnName("ActualDOJ")
                    .HasColumnType("date");

                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TblEmployeeProbationDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_createdby");

                entity.HasOne(d => d.FkEmp)
                    .WithMany(p => p.TblEmployeeProbationDetailsFkEmp)
                    .HasForeignKey(d => d.FkEmpId)
                    .HasConstraintName("FK_Emp");
            });

            modelBuilder.Entity<TblEPolicyCategory>(entity =>
            {
                entity.ToTable("tbl_E_PolicyCategory");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<TblEPolicyCategory>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_E_PolicyCategory_tbl_E_PolicyCategory");
            });

            modelBuilder.Entity<TblERelationship>(entity =>
            {
                entity.ToTable("tbl_E_Relationship");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblERole>(entity =>
            {
                entity.ToTable("tbl_E_Role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEStatus>(entity =>
            {
                entity.ToTable("tbl_E_Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblETechnicalskills>(entity =>
            {
                entity.ToTable("tbl_E_Technicalskills");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblExceptionLogger>(entity =>
            {
                entity.ToTable("tbl_ExceptionLogger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ControllerName).HasMaxLength(1000);

                entity.Property(e => e.InnerException).HasMaxLength(100);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.Platform).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblUrl>(entity =>
            {
                entity.ToTable("tbl_url");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbNoticePeriod>(entity =>
            {
                entity.ToTable("tbNoticePeriod");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.FkDesignationNavigation)
                    .WithMany(p => p.TbNoticePeriod)
                    .HasForeignKey(d => d.FkDesignation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbNoticePeriod_tbl_E_Designation");
            });

            modelBuilder.Entity<TbPolicy>(entity =>
            {
                entity.ToTable("tbPolicy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkpcId).HasColumnName("FKPcId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fkpc)
                    .WithMany(p => p.TbPolicy)
                    .HasForeignKey(d => d.FkpcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPolicy_tbl_E_PolicyCategory");
            });

            modelBuilder.Entity<TbTemplates>(entity =>
            {
                entity.ToTable("tbTemplates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.TemplatePath).IsRequired();

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TbTemplates)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbTemplates_tbApplicationEvents");
            });

            modelBuilder.Entity<TlAcceptEthics>(entity =>
            {
                entity.ToTable("TL_AcceptEthics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FkEthics).HasColumnName("fkEthics");

                entity.HasOne(d => d.FkEthicsNavigation)
                    .WithMany(p => p.TlAcceptEthics)
                    .HasForeignKey(d => d.FkEthics)
                    .HasConstraintName("FK_TL_AcceptEthics_TL_Ethics");
            });

            modelBuilder.Entity<TlAnnouncement>(entity =>
            {
                entity.ToTable("TL_Announcement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contents)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlAnnouncementAccept>(entity =>
            {
                entity.ToTable("TL_AnnouncementAccept");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FkAnnouncement).HasColumnName("fkAnnouncement");

                entity.HasOne(d => d.FkAnnouncementNavigation)
                    .WithMany(p => p.TlAnnouncementAccept)
                    .HasForeignKey(d => d.FkAnnouncement)
                    .HasConstraintName("RefTL_Announcement2");
            });

            modelBuilder.Entity<TlEthics>(entity =>
            {
                entity.ToTable("TL_Ethics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlLateComing>(entity =>
            {
                entity.ToTable("TL_LateComing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_Id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TlTimeLog>(entity =>
            {
                entity.ToTable("TL_TimeLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Earlycheckoutreson).IsUnicode(false);

                entity.Property(e => e.FkEmpId)
                    .HasColumnName("fkEmp_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Login).HasColumnType("smalldatetime");

                entity.Property(e => e.LoginIp)
                    .HasColumnName("LoginIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logout).HasColumnType("smalldatetime");

                entity.Property(e => e.LogoutIp)
                    .HasColumnName("LogoutIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductiveHours)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeBreak)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Userip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingHours)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpdatedDoj>(entity =>
            {
                entity.ToTable("updatedDOJ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDoj)
                    .HasColumnName("ActualDOJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fkempid).HasColumnName("fkempid");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDoj1)
                    .HasColumnName("UpdatedDOJ")
                    .HasColumnType("datetime");
            });
        }
    }
}
