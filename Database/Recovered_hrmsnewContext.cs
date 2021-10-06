using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PositionInfo.Database
{
    public partial class Recovered_hrmsnewContext : DbContext
    {
        public Recovered_hrmsnewContext()
        {
        }

        public Recovered_hrmsnewContext(DbContextOptions<Recovered_hrmsnewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsenteesCount> AbsenteesCounts { get; set; }
        public virtual DbSet<AcceptAnnouncement> AcceptAnnouncements { get; set; }
        public virtual DbSet<AmsemailFailureRecord> AmsemailFailureRecords { get; set; }
        public virtual DbSet<AmsemailQueue> AmsemailQueues { get; set; }
        public virtual DbSet<Amsevent> Amsevents { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<AppraisalCycle> AppraisalCycles { get; set; }
        public virtual DbSet<AppraisalInterval> AppraisalIntervals { get; set; }
        public virtual DbSet<AssessmentCriterion> AssessmentCriteria { get; set; }
        public virtual DbSet<AssessmentRevision> AssessmentRevisions { get; set; }
        public virtual DbSet<BalanceLeave> BalanceLeaves { get; set; }
        public virtual DbSet<Balanceleave1> Balanceleaves1 { get; set; }
        public virtual DbSet<ChangedEmployeeDepartment> ChangedEmployeeDepartments { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<DesignationHistory> DesignationHistories { get; set; }
        public virtual DbSet<DetailedLeaveStatus> DetailedLeaveStatuses { get; set; }
        public virtual DbSet<EmpCertification> EmpCertifications { get; set; }
        public virtual DbSet<EmpDependent> EmpDependents { get; set; }
        public virtual DbSet<EmpDocument> EmpDocuments { get; set; }
        public virtual DbSet<EmpEducation> EmpEducations { get; set; }
        public virtual DbSet<EmpExperience> EmpExperiences { get; set; }
        public virtual DbSet<EmpTechnicalSkill> EmpTechnicalSkills { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeEmailList> EmployeeEmailLists { get; set; }
        public virtual DbSet<EmployeeManagerList> EmployeeManagerLists { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<EmployeeemaillistAudit> EmployeeemaillistAudits { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<FaqCategory> FaqCategories { get; set; }
        public virtual DbSet<Hrnotification> Hrnotifications { get; set; }
        public virtual DbSet<LeadNotification> LeadNotifications { get; set; }
        public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }
        public virtual DbSet<LeaveStatus> LeaveStatuses { get; set; }
        public virtual DbSet<LeavesQuotum> LeavesQuota { get; set; }
        public virtual DbSet<ManagerList> ManagerLists { get; set; }
        public virtual DbSet<MasterGoalCategory> MasterGoalCategories { get; set; }
        public virtual DbSet<MasterStatus> MasterStatuses { get; set; }
        public virtual DbSet<MobileAppUpdateTable> MobileAppUpdateTables { get; set; }
        public virtual DbSet<ModulePermission> ModulePermissions { get; set; }
        public virtual DbSet<Newmonth> Newmonths { get; set; }
        public virtual DbSet<PerformanceAppraisal> PerformanceAppraisals { get; set; }
        public virtual DbSet<PerformanceEvaluation> PerformanceEvaluations { get; set; }
        public virtual DbSet<ReminderAlert> ReminderAlerts { get; set; }
        public virtual DbSet<ReminderLeave> ReminderLeaves { get; set; }
        public virtual DbSet<TbActionTaken> TbActionTakens { get; set; }
        public virtual DbSet<TbApplicationEvent> TbApplicationEvents { get; set; }
        public virtual DbSet<TbChangeDesignation> TbChangeDesignations { get; set; }
        public virtual DbSet<TbDocumentType> TbDocumentTypes { get; set; }
        public virtual DbSet<TbEmailFailureRecord> TbEmailFailureRecords { get; set; }
        public virtual DbSet<TbEmailQueue> TbEmailQueues { get; set; }
        public virtual DbSet<TbEmployeeAddress> TbEmployeeAddresses { get; set; }
        public virtual DbSet<TbEmployeeAppraisalRecord> TbEmployeeAppraisalRecords { get; set; }
        public virtual DbSet<TbEmployeeBankAndPfrecord> TbEmployeeBankAndPfrecords { get; set; }
        public virtual DbSet<TbEmployeeExitRecord> TbEmployeeExitRecords { get; set; }
        public virtual DbSet<TbEmployeeRefrence> TbEmployeeRefrences { get; set; }
        public virtual DbSet<TbEmployeeStatusEvent> TbEmployeeStatusEvents { get; set; }
        public virtual DbSet<TbEmployeeStatusRecord> TbEmployeeStatusRecords { get; set; }
        public virtual DbSet<TbNoticePeriod> TbNoticePeriods { get; set; }
        public virtual DbSet<TbPolicy> TbPolicies { get; set; }
        public virtual DbSet<TbTemplate> TbTemplates { get; set; }
        public virtual DbSet<TblAccessCardDatum> TblAccessCardData { get; set; }
        public virtual DbSet<TblAccessCardEmployee> TblAccessCardEmployees { get; set; }
        public virtual DbSet<TblAccessCardEvent> TblAccessCardEvents { get; set; }
        public virtual DbSet<TblAllEmployeesCustomLeaveReport> TblAllEmployeesCustomLeaveReports { get; set; }
        public virtual DbSet<TblAllEmployeesLeaveDetail> TblAllEmployeesLeaveDetails { get; set; }
        public virtual DbSet<TblDiConsultCharge> TblDiConsultCharges { get; set; }
        public virtual DbSet<TblDiGeoState> TblDiGeoStates { get; set; }
        public virtual DbSet<TblEAppraisalRating> TblEAppraisalRatings { get; set; }
        public virtual DbSet<TblEBank> TblEBanks { get; set; }
        public virtual DbSet<TblEBloodGroup> TblEBloodGroups { get; set; }
        public virtual DbSet<TblECalendarHoliday> TblECalendarHolidays { get; set; }
        public virtual DbSet<TblECertification> TblECertifications { get; set; }
        public virtual DbSet<TblEDepartment> TblEDepartments { get; set; }
        public virtual DbSet<TblEDesignation> TblEDesignations { get; set; }
        public virtual DbSet<TblEEmpType> TblEEmpTypes { get; set; }
        public virtual DbSet<TblEEmploymentStatus> TblEEmploymentStatuses { get; set; }
        public virtual DbSet<TblEExitStatus> TblEExitStatuses { get; set; }
        public virtual DbSet<TblEGrade> TblEGrades { get; set; }
        public virtual DbSet<TblELeaveType> TblELeaveTypes { get; set; }
        public virtual DbSet<TblEModule> TblEModules { get; set; }
        public virtual DbSet<TblEPolicyCategory> TblEPolicyCategories { get; set; }
        public virtual DbSet<TblERelationship> TblERelationships { get; set; }
        public virtual DbSet<TblERole> TblERoles { get; set; }
        public virtual DbSet<TblEStatus> TblEStatuses { get; set; }
        public virtual DbSet<TblETechnicalskill> TblETechnicalskills { get; set; }
        public virtual DbSet<TblEmployeeBehaviouralGoal> TblEmployeeBehaviouralGoals { get; set; }
        public virtual DbSet<TblEmployeeGoal> TblEmployeeGoals { get; set; }
        public virtual DbSet<TblEmployeeGoalOther> TblEmployeeGoalOthers { get; set; }
        public virtual DbSet<TblEmployeeGoalSettingCategory> TblEmployeeGoalSettingCategories { get; set; }
        public virtual DbSet<TblEmployeeGoalSettingForm> TblEmployeeGoalSettingForms { get; set; }
        public virtual DbSet<TblEmployeeProbationDetail> TblEmployeeProbationDetails { get; set; }
        public virtual DbSet<TblExceptionLogger> TblExceptionLoggers { get; set; }
        public virtual DbSet<TblHAcceptEthic> TblHAcceptEthics { get; set; }
        public virtual DbSet<TblHEmpCertification> TblHEmpCertifications { get; set; }
        public virtual DbSet<TblHEmpDependent> TblHEmpDependents { get; set; }
        public virtual DbSet<TblHEmpDocument> TblHEmpDocuments { get; set; }
        public virtual DbSet<TblHEmpEducation> TblHEmpEducations { get; set; }
        public virtual DbSet<TblHEmpExperience> TblHEmpExperiences { get; set; }
        public virtual DbSet<TblHEmpTechnicalSkill> TblHEmpTechnicalSkills { get; set; }
        public virtual DbSet<TblHEmployee> TblHEmployees { get; set; }
        public virtual DbSet<TblHEmployeeRole> TblHEmployeeRoles { get; set; }
        public virtual DbSet<TblHLeaveStatus> TblHLeaveStatuses { get; set; }
        public virtual DbSet<TblHTimeLog> TblHTimeLogs { get; set; }
        public virtual DbSet<TblMasterEmployeeBehavioural> TblMasterEmployeeBehaviourals { get; set; }
        public virtual DbSet<TblMasterGoalCategory> TblMasterGoalCategories { get; set; }
        public virtual DbSet<TblTime> TblTimes { get; set; }
        public virtual DbSet<TblUrl> TblUrls { get; set; }
        public virtual DbSet<TlAcceptEthic> TlAcceptEthics { get; set; }
        public virtual DbSet<TlAnnouncement> TlAnnouncements { get; set; }
        public virtual DbSet<TlAnnouncementAccept> TlAnnouncementAccepts { get; set; }
        public virtual DbSet<TlEthic> TlEthics { get; set; }
        public virtual DbSet<TlLateComing> TlLateComings { get; set; }
        public virtual DbSet<TlTimeLog> TlTimeLogs { get; set; }
        public virtual DbSet<UpdatedDoj> UpdatedDojs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.12\\SQLEXPRESS;Database=Recovered_hrmsnew;User Id=Softprod;Password=Softprodigy$*!;Trusted_Connection=false;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AbsenteesCount>(entity =>
            {
                entity.ToTable("AbsenteesCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.EmailBody)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AcceptAnnouncement>(entity =>
            {
                entity.ToTable("AcceptAnnouncement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptDateTime).HasColumnType("datetime");

                entity.Property(e => e.FkAnnouncement).HasColumnName("fkAnnouncement");

                entity.Property(e => e.FkEmp).HasColumnName("fkEmp");

                entity.HasOne(d => d.FkAnnouncementNavigation)
                    .WithMany(p => p.AcceptAnnouncements)
                    .HasForeignKey(d => d.FkAnnouncement)
                    .HasConstraintName("FK_AcceptAnnouncement_Announcement1");

                entity.HasOne(d => d.FkEmpNavigation)
                    .WithMany(p => p.AcceptAnnouncements)
                    .HasForeignKey(d => d.FkEmp)
                    .HasConstraintName("FK_AcceptAnnouncement_Announcement");
            });

            modelBuilder.Entity<AmsemailFailureRecord>(entity =>
            {
                entity.ToTable("AMSEmailFailureRecords");

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<AmsemailQueue>(entity =>
            {
                entity.ToTable("AMSEmailQueue");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkEmployeeId).HasColumnName("fkEmployeeId");

                entity.Property(e => e.PendingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Amsevent>(entity =>
            {
                entity.ToTable("AMSEvents");

                entity.Property(e => e.EventName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SentTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("Announcement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnnouncementContent)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AnnouncementDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppraisalCycle>(entity =>
            {
                entity.ToTable("AppraisalCycle");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JoinMonth1).HasColumnName("Join_Month1");

                entity.Property(e => e.JoinMonth2).HasColumnName("Join_Month2");

                entity.Property(e => e.JoinMonth3).HasColumnName("Join_Month3");

                entity.Property(e => e.NextAppraisalMonth).HasColumnName("Next_Appraisal_Month");
            });

            modelBuilder.Entity<AppraisalInterval>(entity =>
            {
                entity.HasKey(e => e.FkGrade)
                    .HasName("PK30");

                entity.ToTable("AppraisalInterval");

                entity.Property(e => e.FkGrade)
                    .ValueGeneratedNever()
                    .HasColumnName("fkGrade");

                entity.HasOne(d => d.FkGradeNavigation)
                    .WithOne(p => p.AppraisalInterval)
                    .HasForeignKey<AppraisalInterval>(d => d.FkGrade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_E_Grade48");
            });

            modelBuilder.Entity<AssessmentCriterion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkAssessmentRevision).HasColumnName("fkAssessmentRevision");

                entity.Property(e => e.FkGrade).HasColumnName("fkGrade");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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
                entity.ToTable("AssessmentRevision");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RevisionCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BalanceLeave>(entity =>
            {
                entity.ToTable("Balance_Leave");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.BalanceLeaves)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__Balance_L__Emp_I__5FC3B42F");

                entity.HasOne(d => d.LeaveTypeNavigation)
                    .WithMany(p => p.BalanceLeaves)
                    .HasForeignKey(d => d.LeaveType)
                    .HasConstraintName("FK__Balance_L__Leave__60B7D868");
            });

            modelBuilder.Entity<Balanceleave1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Balanceleave");

                entity.Property(e => e.CasualLeavesLeft).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PaidLeavesLeft).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SickLeavesLeft).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<ChangedEmployeeDepartment>(entity =>
            {
                entity.ToTable("ChangedEmployeeDepartment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((169))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.NewDeptId).HasColumnName("NewDeptID");

                entity.Property(e => e.OldDeptId).HasColumnName("OldDeptID");
            });

            modelBuilder.Entity<Date>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dates).HasColumnType("date");
            });

            modelBuilder.Entity<DesignationHistory>(entity =>
            {
                entity.ToTable("DesignationHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.DesignationHistories)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK__Designati__Desig__5B34093C");

                entity.HasOne(d => d.GradeNavigation)
                    .WithMany(p => p.DesignationHistories)
                    .HasForeignKey(d => d.Grade)
                    .HasConstraintName("FK__Designati__Grade__5A3FE503");
            });

            modelBuilder.Entity<DetailedLeaveStatus>(entity =>
            {
                entity.ToTable("DetailedLeaveStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Admin_Comment");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Admin_id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Elc)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("ELC");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Emp_id");

                entity.Property(e => e.FirstLineManagerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FirstLineManager_id");

                entity.Property(e => e.FirstLineMangerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FkLeaveType).HasColumnName("fkLeaveType");

                entity.Property(e => e.Fldecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("FLDecisiondate");

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HrComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Hr_Comment");

                entity.Property(e => e.HrId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Hr_id");

                entity.Property(e => e.HrStatus).HasColumnName("Hr_Status");

                entity.Property(e => e.Hrrdecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("HRRDecisiondate");

                entity.Property(e => e.IsElcflag)
                    .HasColumnName("IsELCFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLwp).HasColumnName("IsLWP");

                entity.Property(e => e.LeaveAppliedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveReason)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.LeavestatusId).HasColumnName("LeavestatusID");

                entity.Property(e => e.SecondLineManagerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLineManagerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SecondLineManager_id");

                entity.Property(e => e.Sldecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("SLDecisiondate");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");

                entity.HasOne(d => d.FkLeaveTypeNavigation)
                    .WithMany(p => p.DetailedLeaveStatuses)
                    .HasForeignKey(d => d.FkLeaveType)
                    .HasConstraintName("FK_LeaveStatus_tbl_E_LeaveType71");
            });

            modelBuilder.Entity<EmpCertification>(entity =>
            {
                entity.ToTable("EmpCertification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkCertification).HasColumnName("fkCertification");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.Institution)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PercentSecured).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkCertificationNavigation)
                    .WithMany(p => p.EmpCertifications)
                    .HasForeignKey(d => d.FkCertification)
                    .HasConstraintName("Reftbl_E_Certification51");
            });

            modelBuilder.Entity<EmpDependent>(entity =>
            {
                entity.ToTable("EmpDependent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DependentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DependentContactNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DependentName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkRelationship).HasColumnName("fkRelationship");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkRelationshipNavigation)
                    .WithMany(p => p.EmpDependents)
                    .HasForeignKey(d => d.FkRelationship)
                    .HasConstraintName("Reftbl_E_Relationship40");
            });

            modelBuilder.Entity<EmpDocument>(entity =>
            {
                entity.ToTable("EmpDocument");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkDocumentType).HasColumnName("fkDocumentType");

                entity.Property(e => e.FkEmployeeId).HasColumnName("fkEmployeeID");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkDocumentTypeNavigation)
                    .WithMany(p => p.EmpDocuments)
                    .HasForeignKey(d => d.FkDocumentType)
                    .HasConstraintName("FK_EmpDocument_tb_DocumentType");
            });

            modelBuilder.Entity<EmpEducation>(entity =>
            {
                entity.ToTable("EmpEducation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DegreeCertification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FromDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PercentSecured).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ToDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.University)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpExperience>(entity =>
            {
                entity.ToTable("EmpExperience");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Employer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeavingReason).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NatureofDuties)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpTechnicalSkill>(entity =>
            {
                entity.ToTable("EmpTechnicalSkill");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkTechnicalSkill).HasColumnName("fkTechnicalSkill");

                entity.Property(e => e.LastUsed).HasColumnType("datetime");

                entity.Property(e => e.TotalExp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkTechnicalSkillNavigation)
                    .WithMany(p => p.EmpTechnicalSkills)
                    .HasForeignKey(d => d.FkTechnicalSkill)
                    .HasConstraintName("Reftbl_E_Technicalskills39");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.EmpId, "Emp_Id_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalDueOn)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Confirmationdate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.DrivingLicienceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Code")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExitComment)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExitDate).HasColumnType("datetime");

                entity.Property(e => e.ExtNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkBloodGroup).HasColumnName("fkBloodGroup");

                entity.Property(e => e.FkDepartment).HasColumnName("fkDepartment");

                entity.Property(e => e.FkDesignation).HasColumnName("fkDesignation");

                entity.Property(e => e.FkEmpGrade).HasColumnName("fkEmpGrade");

                entity.Property(e => e.FkEmpType).HasColumnName("fkEmpType");

                entity.Property(e => e.FkEmploymentStatus).HasColumnName("fkEmploymentStatus");

                entity.Property(e => e.FkExitStatus).HasColumnName("fkExitStatus");

                entity.Property(e => e.Fname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([fname]+' ')+[lname])", false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.GtalkId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HiringSource)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LoginPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MachineIpAddress)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Msnid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSNId")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OfficialEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OutlookId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PassportExpiry).HasColumnType("datetime");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PriorExperience).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefCompany1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefCompany2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefCompany3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefContactNo1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefContactNo2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefContactNo3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefDesignation1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefDesignation2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefDesignation3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefEmail1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefEmail2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefEmail3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefName1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefName2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefName3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RelevantExperience).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalAccNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SkypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SparkId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tfmp)
                    .HasMaxLength(20)
                    .HasColumnName("TFMP");

                entity.Property(e => e.TrainingDuration)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Userip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisaExpiry).HasColumnType("datetime");

                entity.Property(e => e.VisaNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WeddingDate).HasColumnType("datetime");

                entity.Property(e => e.YahooId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkBloodGroupNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkBloodGroup)
                    .HasConstraintName("Reftbl_E_BloodGroup");

                entity.HasOne(d => d.FkDepartmentNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkDepartment)
                    .HasConstraintName("FK_Employee_tbl_E_Department");

                entity.HasOne(d => d.FkDesignationNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkDesignation)
                    .HasConstraintName("fk_tb_E_Resignation");

                entity.HasOne(d => d.FkEmpGradeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkEmpGrade)
                    .HasConstraintName("Reftbl_E_Grade29");

                entity.HasOne(d => d.FkEmpTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkEmpType)
                    .HasConstraintName("Reftbl_E_EmpType16");

                entity.HasOne(d => d.FkEmploymentStatusNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkEmploymentStatus)
                    .HasConstraintName("FK_Employee_tbl_E_EmploymentStatus");

                entity.HasOne(d => d.FkExitStatusNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkExitStatus)
                    .HasConstraintName("Reftbl_E_ExitStatus");
            });

            modelBuilder.Entity<EmployeeEmailList>(entity =>
            {
                entity.ToTable("EmployeeEmailList");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail2)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeManagerList>(entity =>
            {
                entity.ToTable("EmployeeManagerList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Isactive).HasColumnName("ISActive");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            });

            modelBuilder.Entity<EmployeeRole>(entity =>
            {
                entity.ToTable("EmployeeRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkRole).HasColumnName("fkRole");

                entity.HasOne(d => d.FkRoleNavigation)
                    .WithMany(p => p.EmployeeRoles)
                    .HasForeignKey(d => d.FkRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_E_Role24");
            });

            modelBuilder.Entity<EmployeeemaillistAudit>(entity =>
            {
                entity.HasKey(e => e.ChangeId)
                    .HasName("PK__employee__F4EFE5967D99F856");

                entity.ToTable("employeeemaillist_audit");

                entity.Property(e => e.ChangeId).HasColumnName("change_id");

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("operation")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("Faq");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkFaqCategory).HasColumnName("fkFaqCategory");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPublished).HasDefaultValueSql("((0))");

                entity.Property(e => e.Question)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.ViewedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FkFaqCategoryNavigation)
                    .WithMany(p => p.Faqs)
                    .HasForeignKey(d => d.FkFaqCategory)
                    .HasConstraintName("FK_FaqCategory_Faq");
            });

            modelBuilder.Entity<FaqCategory>(entity =>
            {
                entity.ToTable("FaqCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Hrnotification>(entity =>
            {
                entity.ToTable("HRNotification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Hrid).HasColumnName("HRID");
            });

            modelBuilder.Entity<LeadNotification>(entity =>
            {
                entity.ToTable("LeadNotification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");
            });

            modelBuilder.Entity<LeaveBalance>(entity =>
            {
                entity.ToTable("LeaveBalance");

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

            modelBuilder.Entity<LeaveStatus>(entity =>
            {
                entity.ToTable("LeaveStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Admin_Comment")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Admin_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Elc)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("ELC");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Emp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstLineManagerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FirstLineManager_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstLineMangerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkLeaveType).HasColumnName("fkLeaveType");

                entity.Property(e => e.Fldecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("FLDecisiondate");

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HrComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Hr_Comment")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HrId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Hr_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HrStatus).HasColumnName("Hr_Status");

                entity.Property(e => e.Hrrdecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("HRRDecisiondate");

                entity.Property(e => e.IsElcflag)
                    .HasColumnName("IsELCFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLwp).HasColumnName("IsLWP");

                entity.Property(e => e.LeaveAppliedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveReason)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SecondLineManagerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SecondLineManagerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SecondLineManager_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Sldecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("SLDecisiondate");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("smalldatetime");

                entity.HasOne(d => d.FkLeaveTypeNavigation)
                    .WithMany(p => p.LeaveStatuses)
                    .HasForeignKey(d => d.FkLeaveType)
                    .HasConstraintName("FK_LeaveStatus_tbl_E_LeaveType");
            });

            modelBuilder.Entity<LeavesQuotum>(entity =>
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

            modelBuilder.Entity<ManagerList>(entity =>
            {
                entity.ToTable("ManagerList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.SubManager).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MasterGoalCategory>(entity =>
            {
                entity.ToTable("MasterGoalCategory");

                entity.Property(e => e.GoalName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterStatus>(entity =>
            {
                entity.ToTable("MasterStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Sname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SName");
            });

            modelBuilder.Entity<MobileAppUpdateTable>(entity =>
            {
                entity.ToTable("mobile_app_update_table");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PreviousVersionFileLinkAndroid).HasMaxLength(250);

                entity.Property(e => e.PreviousVersionFileLinkIos)
                    .HasMaxLength(250)
                    .HasColumnName("PreviousVersionFileLinkIOS");

                entity.Property(e => e.VersionFileLinkAndroid).HasMaxLength(250);

                entity.Property(e => e.VersionFileLinkIos)
                    .HasMaxLength(250)
                    .HasColumnName("VersionFileLinkIOS");

                entity.Property(e => e.VersionMessageText).HasColumnType("text");

                entity.Property(e => e.VersionNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<ModulePermission>(entity =>
            {
                entity.ToTable("ModulePermission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkModule).HasColumnName("fkModule");

                entity.Property(e => e.FkRole).HasColumnName("fkRole");

                entity.HasOne(d => d.FkModuleNavigation)
                    .WithMany(p => p.ModulePermissions)
                    .HasForeignKey(d => d.FkModule)
                    .HasConstraintName("Reftbl_E_Module25");

                entity.HasOne(d => d.FkRoleNavigation)
                    .WithMany(p => p.ModulePermissions)
                    .HasForeignKey(d => d.FkRole)
                    .HasConstraintName("Reftbl_E_Role26");
            });

            modelBuilder.Entity<Newmonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("newmonths");

                entity.Property(e => e.Month1)
                    .HasMaxLength(30)
                    .HasColumnName("month1");

                entity.Property(e => e.Yearindex)
                    .HasMaxLength(30)
                    .HasColumnName("yearindex");
            });

            modelBuilder.Entity<PerformanceAppraisal>(entity =>
            {
                entity.ToTable("PerformanceAppraisal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalComment)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AppraisedCtc).HasColumnName("AppraisedCTC");

                entity.Property(e => e.CurrentCtc).HasColumnName("CurrentCTC");

                entity.Property(e => e.EmployeeComment)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkAppraisalRating).HasColumnName("fkAppraisalRating");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.NextAppraisalDueOn).HasColumnType("datetime");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewPeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.ReviewPeriodTo).HasColumnType("datetime");

                entity.Property(e => e.ReviewedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkAppraisalRatingNavigation)
                    .WithMany(p => p.PerformanceAppraisals)
                    .HasForeignKey(d => d.FkAppraisalRating)
                    .HasConstraintName("Reftbl_E_AppraisalRating33");
            });

            modelBuilder.Entity<PerformanceEvaluation>(entity =>
            {
                entity.ToTable("PerformanceEvaluation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkAssessmentCriteria).HasColumnName("fkAssessmentCriteria");

                entity.Property(e => e.FkPerformanceAppraisal).HasColumnName("fkPerformanceAppraisal");

                entity.Property(e => e.ReviewerComment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SelfComment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkAssessmentCriteriaNavigation)
                    .WithMany(p => p.PerformanceEvaluations)
                    .HasForeignKey(d => d.FkAssessmentCriteria)
                    .HasConstraintName("RefAssessmentCriteria44");

                entity.HasOne(d => d.FkPerformanceAppraisalNavigation)
                    .WithMany(p => p.PerformanceEvaluations)
                    .HasForeignKey(d => d.FkPerformanceAppraisal)
                    .HasConstraintName("RefPerformanceAppraisal43");

                entity.HasOne(d => d.ReviewerRatingNavigation)
                    .WithMany(p => p.PerformanceEvaluationReviewerRatingNavigations)
                    .HasForeignKey(d => d.ReviewerRating)
                    .HasConstraintName("Reftbl_E_AppraisalRating47");

                entity.HasOne(d => d.SelfRatingNavigation)
                    .WithMany(p => p.PerformanceEvaluationSelfRatingNavigations)
                    .HasForeignKey(d => d.SelfRating)
                    .HasConstraintName("Reftbl_E_AppraisalRating46");
            });

            modelBuilder.Entity<ReminderAlert>(entity =>
            {
                entity.ToTable("ReminderAlert");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");
            });

            modelBuilder.Entity<ReminderLeave>(entity =>
            {
                entity.ToTable("ReminderLeave");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.FkLeavestatus).HasColumnName("fkLeavestatus");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LineManager)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkLeavestatusNavigation)
                    .WithMany(p => p.ReminderLeaves)
                    .HasForeignKey(d => d.FkLeavestatus)
                    .HasConstraintName("FK_ReminderLeave_LeaveStatus");
            });

            modelBuilder.Entity<TbActionTaken>(entity =>
            {
                entity.ToTable("tbActionTakens");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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

            modelBuilder.Entity<TbApplicationEvent>(entity =>
            {
                entity.ToTable("tbApplicationEvents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbChangeDesignation>(entity =>
            {
                entity.ToTable("tb_ChangeDesignation");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Experience)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeId");

                entity.Property(e => e.FknewDesignation).HasColumnName("FKNewDesignation");

                entity.Property(e => e.FknewGrade).HasColumnName("FKNewGrade");

                entity.Property(e => e.FkoldDesignation).HasColumnName("FKOldDesignation");

                entity.Property(e => e.FkoldGrade).HasColumnName("FKOldGrade");

                entity.HasOne(d => d.FkoldDesignationNavigation)
                    .WithMany(p => p.TbChangeDesignations)
                    .HasForeignKey(d => d.FkoldDesignation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_ChangeDesignation_tbl_E_Designation");
            });

            modelBuilder.Entity<TbDocumentType>(entity =>
            {
                entity.ToTable("tb_DocumentType");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbEmailFailureRecord>(entity =>
            {
                entity.ToTable("tbEmailFailureRecords");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FailureRecords)
                    .IsRequired()
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TbEmailQueues)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmailQueue_Employee");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TbEmailQueues)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmailQueue_tbApplicationEvents");
            });

            modelBuilder.Entity<TbEmployeeAddress>(entity =>
            {
                entity.ToTable("tbEmployeeAddresses");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Ext)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeAddresses)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPresentAddresses_Employee");
            });

            modelBuilder.Entity<TbEmployeeAppraisalRecord>(entity =>
            {
                entity.ToTable("tbEmployeeAppraisalRecords");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalCycle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AppraisalDueOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Fkdepartment).HasColumnName("FKDepartment");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Branch)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Esinumber)
                    .HasMaxLength(50)
                    .HasColumnName("ESINumber")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FamilyPfnumber)
                    .HasMaxLength(50)
                    .HasColumnName("FamilyPFNumber")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fkbank).HasColumnName("FKBank");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.IsEpfexcessContribution).HasColumnName("IsEPFExcessContribution");

                entity.Property(e => e.IsEpsexcessContribution).HasColumnName("IsEPSExcessContribution");

                entity.Property(e => e.IsEsischeme).HasColumnName("IsESIScheme");

                entity.Property(e => e.IsPfscheme).HasColumnName("IsPFScheme");

                entity.Property(e => e.Isfccode)
                    .HasMaxLength(20)
                    .HasColumnName("ISFCCode")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PayableAt)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PfjoinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PFJoinDate");

                entity.Property(e => e.Pfnumber)
                    .HasMaxLength(50)
                    .HasColumnName("PFNumber")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Pfscheme)
                    .HasMaxLength(50)
                    .HasColumnName("PFScheme")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkbankNavigation)
                    .WithMany(p => p.TbEmployeeBankAndPfrecords)
                    .HasForeignKey(d => d.Fkbank)
                    .HasConstraintName("FK_tbEmployeeBankAndPFRecord_tbl_E_Banks");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeBankAndPfrecords)
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
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FinalSettlementDate).HasColumnType("datetime");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.LeavingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RelieveDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ResignationDate).HasColumnType("datetime");

                entity.Property(e => e.RetireDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeExitRecords)
                    .HasForeignKey(d => d.Fkemployee)
                    .HasConstraintName("FK_tbEmployeeExitRecord_Employee");

                entity.HasOne(d => d.LeavingReasonNavigation)
                    .WithMany(p => p.TbEmployeeExitRecords)
                    .HasForeignKey(d => d.LeavingReason)
                    .HasConstraintName("FK_tbEmployeeExitRecord_tbl_E_ExitStatus");
            });

            modelBuilder.Entity<TbEmployeeRefrence>(entity =>
            {
                entity.ToTable("tbEmployeeRefrences");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeRefrences)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmployeeRefrences_tbEmployeeRefrences");
            });

            modelBuilder.Entity<TbEmployeeStatusEvent>(entity =>
            {
                entity.ToTable("tbEmployeeStatusEvents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Events).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbEmployeeStatusRecord>(entity =>
            {
                entity.ToTable("tbEmployeeStatusRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExitStatus)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fkdepartment).HasColumnName("FKDepartment");

                entity.Property(e => e.Fkdesignation).HasColumnName("FKDesignation");

                entity.Property(e => e.FkempType).HasColumnName("FKEmpType");

                entity.Property(e => e.Fkemployee).HasColumnName("FKEmployee");

                entity.Property(e => e.FkemploymentStatus).HasColumnName("FKEmploymentStatus");

                entity.Property(e => e.Fkgrade).HasColumnName("FKGrade");

                entity.HasOne(d => d.EventRecordNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecords)
                    .HasForeignKey(d => d.EventRecord)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbEmployeeStatusEvents");

                entity.HasOne(d => d.FkdesignationNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecords)
                    .HasForeignKey(d => d.Fkdesignation)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_Designation");

                entity.HasOne(d => d.FkempTypeNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecords)
                    .HasForeignKey(d => d.FkempType)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_EmpType");

                entity.HasOne(d => d.FkemployeeNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecords)
                    .HasForeignKey(d => d.Fkemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_Employee");

                entity.HasOne(d => d.FkemploymentStatusNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecords)
                    .HasForeignKey(d => d.FkemploymentStatus)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_Status");

                entity.HasOne(d => d.FkgradeNavigation)
                    .WithMany(p => p.TbEmployeeStatusRecords)
                    .HasForeignKey(d => d.Fkgrade)
                    .HasConstraintName("FK_tbEmployeeStatusRecord_tbl_E_Grade");
            });

            modelBuilder.Entity<TbNoticePeriod>(entity =>
            {
                entity.ToTable("tbNoticePeriod");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.FkDesignationNavigation)
                    .WithMany(p => p.TbNoticePeriods)
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
                    .WithMany(p => p.TbPolicies)
                    .HasForeignKey(d => d.FkpcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPolicy_tbl_E_PolicyCategory");
            });

            modelBuilder.Entity<TbTemplate>(entity =>
            {
                entity.ToTable("tbTemplates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.TemplatePath)
                    .IsRequired()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TbTemplates)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbTemplates_tbApplicationEvents");
            });

            modelBuilder.Entity<TblAccessCardDatum>(entity =>
            {
                entity.ToTable("tbl_AccessCardData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.No)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Position)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAccessCardEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_AccessCardEmployees");

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.CardNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PersonCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblAccessCardEvent>(entity =>
            {
                entity.ToTable("tbl_AccessCardEvents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoorId).HasColumnName("DoorID");

                entity.Property(e => e.DoorName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EventCh)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EventCH")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LWPTaken");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PaidLeavesTaken).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.SickLeavesTaken).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.TotalAllocatedLeaves).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.TotalLeavesTaken).HasColumnType("decimal(5, 1)");
            });

            modelBuilder.Entity<TblAllEmployeesLeaveDetail>(entity =>
            {
                entity.ToTable("tbl_AllEmployeesLeaveDetails");

                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.ConfirmationStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasMaxLength(100);

                entity.Property(e => e.Designation).HasMaxLength(100);

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("DOJ");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.LeaveBalanceCl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveBalance_CL");

                entity.Property(e => e.LeaveBalancePl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveBalance_PL");

                entity.Property(e => e.LeaveBalanceSl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveBalance_SL");

                entity.Property(e => e.LeaveBalanceTl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveBalance_TL");

                entity.Property(e => e.LeaveBalancefornexttenureCl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("Leave Balancefornexttenure_CL");

                entity.Property(e => e.LeaveBalancefornexttenurePl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("Leave Balancefornexttenure_PL");

                entity.Property(e => e.LeaveBalancefornexttenureSl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("Leave Balancefornexttenure_SL");

                entity.Property(e => e.LeaveBalancefornexttenureTl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("Leave Balancefornexttenure_TL");

                entity.Property(e => e.LeaveTakenCl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveTaken_CL");

                entity.Property(e => e.LeaveTakenPl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveTaken_PL");

                entity.Property(e => e.LeaveTakenSl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveTaken_SL");

                entity.Property(e => e.LeaveTakenTl)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LeaveTaken_TL");

                entity.Property(e => e.Lwpleave)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("LWPLeave");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PayableDays).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TotalDays).HasColumnType("decimal(5, 2)");

                entity.Property(e => e._1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("1")
                    .IsFixedLength(true);

                entity.Property(e => e._10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("10")
                    .IsFixedLength(true);

                entity.Property(e => e._11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("11")
                    .IsFixedLength(true);

                entity.Property(e => e._12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("12")
                    .IsFixedLength(true);

                entity.Property(e => e._13)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("13")
                    .IsFixedLength(true);

                entity.Property(e => e._14)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("14")
                    .IsFixedLength(true);

                entity.Property(e => e._15)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("15")
                    .IsFixedLength(true);

                entity.Property(e => e._16)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("16")
                    .IsFixedLength(true);

                entity.Property(e => e._17)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("17")
                    .IsFixedLength(true);

                entity.Property(e => e._18)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("18")
                    .IsFixedLength(true);

                entity.Property(e => e._19)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("19")
                    .IsFixedLength(true);

                entity.Property(e => e._2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("2")
                    .IsFixedLength(true);

                entity.Property(e => e._20)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("20")
                    .IsFixedLength(true);

                entity.Property(e => e._21)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("21")
                    .IsFixedLength(true);

                entity.Property(e => e._22)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("22")
                    .IsFixedLength(true);

                entity.Property(e => e._23)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("23")
                    .IsFixedLength(true);

                entity.Property(e => e._24)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("24")
                    .IsFixedLength(true);

                entity.Property(e => e._25)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("25")
                    .IsFixedLength(true);

                entity.Property(e => e._26)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("26")
                    .IsFixedLength(true);

                entity.Property(e => e._27)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("27")
                    .IsFixedLength(true);

                entity.Property(e => e._28)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("28")
                    .IsFixedLength(true);

                entity.Property(e => e._29)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("29")
                    .IsFixedLength(true);

                entity.Property(e => e._3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("3")
                    .IsFixedLength(true);

                entity.Property(e => e._30)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("30")
                    .IsFixedLength(true);

                entity.Property(e => e._31)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("31")
                    .IsFixedLength(true);

                entity.Property(e => e._4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("4")
                    .IsFixedLength(true);

                entity.Property(e => e._5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("5")
                    .IsFixedLength(true);

                entity.Property(e => e._6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("6")
                    .IsFixedLength(true);

                entity.Property(e => e._7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("7")
                    .IsFixedLength(true);

                entity.Property(e => e._8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("8")
                    .IsFixedLength(true);

                entity.Property(e => e._9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("9")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblDiConsultCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DI_ConsultCharges");

                entity.Property(e => e.FkCountryId).HasColumnName("fkCountryId");
            });

            modelBuilder.Entity<TblDiGeoState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("tbl_DI_Geo_States");

                entity.Property(e => e.StateId).HasColumnName("State_Id");

                entity.Property(e => e.FkCountryId).HasColumnName("fk_Country_Id");

                entity.Property(e => e.StateName)
                    .HasColumnName("State_Name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEAppraisalRating>(entity =>
            {
                entity.ToTable("tbl_E_AppraisalRating");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppraisalMetric)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEBank>(entity =>
            {
                entity.ToTable("tbl_E_Banks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(300)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEBloodGroup>(entity =>
            {
                entity.ToTable("tbl_E_BloodGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblECalendarHoliday>(entity =>
            {
                entity.ToTable("tbl_E_CalendarHoliday");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OccasionDate).HasColumnType("datetime");

                entity.Property(e => e.OccasionName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblECertification>(entity =>
            {
                entity.ToTable("tbl_E_Certification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEDepartment>(entity =>
            {
                entity.ToTable("tbl_E_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentHead)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeptName)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEDesignation>(entity =>
            {
                entity.ToTable("tbl_E_Designation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEEmpType>(entity =>
            {
                entity.ToTable("tbl_E_EmpType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEEmploymentStatus>(entity =>
            {
                entity.ToTable("tbl_E_EmploymentStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEExitStatus>(entity =>
            {
                entity.ToTable("tbl_E_ExitStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEGrade>(entity =>
            {
                entity.ToTable("tbl_E_Grade");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblELeaveType>(entity =>
            {
                entity.ToTable("tbl_E_LeaveType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEModule>(entity =>
            {
                entity.ToTable("tbl_E_Module");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEPolicyCategory>(entity =>
            {
                entity.ToTable("tbl_E_PolicyCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblERelationship>(entity =>
            {
                entity.ToTable("tbl_E_Relationship");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblERole>(entity =>
            {
                entity.ToTable("tbl_E_Role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEStatus>(entity =>
            {
                entity.ToTable("tbl_E_Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblETechnicalskill>(entity =>
            {
                entity.ToTable("tbl_E_Technicalskills");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblEmployeeBehaviouralGoal>(entity =>
            {
                entity.ToTable("tbl_employeeBehaviouralGoal");

                entity.Property(e => e.CommentManagerEvaluation).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cycle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FkbehaviouralGoalsMasterId).HasColumnName("FKBehaviouralGoalsMasterId");

                entity.Property(e => e.FkemployeeGoalsSettingFormId).HasColumnName("FKEmployeeGoalsSettingFormID");

                entity.Property(e => e.GoalDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RatingManagerEvaluation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEmployeeGoal>(entity =>
            {
                entity.ToTable("tbl_employeeGoal");

                entity.Property(e => e.CommentManager).IsUnicode(false);

                entity.Property(e => e.CommentSelf).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cycle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FkemployeeGoalSettingFormId).HasColumnName("FKEmployeeGoalSettingFormID");

                entity.Property(e => e.FkgoalCateoriesId).HasColumnName("FKGoalCateoriesId");

                entity.Property(e => e.RatingManager).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RatingSelf).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Target)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEmployeeGoalOther>(entity =>
            {
                entity.ToTable("tbl_employeeGoalOther");

                entity.Property(e => e.ActionPlanImprovementManager).IsUnicode(false);

                entity.Property(e => e.ActionPlanImprovementSelf).IsUnicode(false);

                entity.Property(e => e.AmbitionsJobExpectations).IsUnicode(false);

                entity.Property(e => e.AreasImprovementManager).IsUnicode(false);

                entity.Property(e => e.AreasImprovementSelf).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cycle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkemployeeGoalsSettingFormId).HasColumnName("FKEmployeeGoalsSettingFormID");

                entity.Property(e => e.Hrfeedback)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("HRFeedback");

                entity.Property(e => e.Hrfeedbackcomment)
                    .IsUnicode(false)
                    .HasColumnName("HRFeedbackcomment");

                entity.Property(e => e.ManagementFeedback).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ManagementFeedbackcomment).IsUnicode(false);

                entity.Property(e => e.OverallRatingManager).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OverallRatingManagercomment).IsUnicode(false);

                entity.Property(e => e.ProjectManagerFeedbackcomment).IsUnicode(false);

                entity.Property(e => e.SummarizeOverallPerformanceManager).IsUnicode(false);

                entity.Property(e => e.SummarizeOverallPerformanceSelf).IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEmployeeGoalSettingCategory>(entity =>
            {
                entity.ToTable("tbl_employeeGoalSettingCategory");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkemployeeGoalsSettingFormId).HasColumnName("FKEmployeeGoalsSettingFormId");

                entity.Property(e => e.FkgoalCateoriesId).HasColumnName("FKGoalCateoriesId");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEmployeeGoalSettingForm>(entity =>
            {
                entity.ToTable("tbl_employeeGoalSettingForm");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cycle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSent04Pm).HasColumnName("EmailSent04PM");

                entity.Property(e => e.EmailSent11Am).HasColumnName("EmailSent11AM");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EvaluationEndDate).HasColumnType("date");

                entity.Property(e => e.EvaluationStartDate).HasColumnType("date");

                entity.Property(e => e.GoalSettingEndDate).HasColumnType("datetime");

                entity.Property(e => e.GoalSettingStartDate).HasColumnType("datetime");

                entity.Property(e => e.HrassesmentStatus).HasColumnName("HRAssesmentStatus");

                entity.Property(e => e.HrinitiateFormStatus).HasColumnName("HRInitiateFormStatus");

                entity.Property(e => e.LeadAssesmentEndDate).HasColumnType("datetime");

                entity.Property(e => e.LeadAssesmentStartDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ProjectManagerAssesmentEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectManagerAssesmentStartDate).HasColumnType("datetime");

                entity.Property(e => e.SelfAssesmentEndDate).HasColumnType("datetime");

                entity.Property(e => e.SelfAssesmentStartDate).HasColumnType("datetime");

                entity.Property(e => e.TodayDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEmployeeProbationDetail>(entity =>
            {
                entity.ToTable("tbl_EmployeeProbationDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDoj)
                    .HasColumnType("date")
                    .HasColumnName("ActualDOJ");

                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TblEmployeeProbationDetailCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_createdby");

                entity.HasOne(d => d.FkEmp)
                    .WithMany(p => p.TblEmployeeProbationDetailFkEmps)
                    .HasForeignKey(d => d.FkEmpId)
                    .HasConstraintName("FK_Emp");
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
                    .HasMaxLength(100)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblHAcceptEthic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_AcceptEthics");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Emp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEthics).HasColumnName("fkEthics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblHEmpCertification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmpCertification");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FkCertification).HasColumnName("fkCertification");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Institution)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PercentSecured).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHEmpDependent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmpDependent");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DependentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DependentContactNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DependentName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkRelationship).HasColumnName("fkRelationship");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHEmpDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmpDocument");

                entity.Property(e => e.FkDocumentType).HasColumnName("fkDocumentType");

                entity.Property(e => e.FkEmployeeId).HasColumnName("fkEmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblHEmpEducation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmpEducation");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DegreeCertification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FromDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PercentSecured).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ToDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHEmpExperience>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmpExperience");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Employer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeavingReason).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NatureofDuties)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHEmpTechnicalSkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmpTechnicalSkill");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkTechnicalSkill).HasColumnName("fkTechnicalSkill");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUsed).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TotalExp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_Employee");

                entity.Property(e => e.AppraisalDueOn)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Confirmationdate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.DrivingLicienceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Code")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExitComment)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExitDate).HasColumnType("datetime");

                entity.Property(e => e.ExtNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkBloodGroup).HasColumnName("fkBloodGroup");

                entity.Property(e => e.FkDepartment).HasColumnName("fkDepartment");

                entity.Property(e => e.FkDesignation).HasColumnName("fkDesignation");

                entity.Property(e => e.FkEmpGrade).HasColumnName("fkEmpGrade");

                entity.Property(e => e.FkEmpType).HasColumnName("fkEmpType");

                entity.Property(e => e.FkEmploymentStatus).HasColumnName("fkEmploymentStatus");

                entity.Property(e => e.FkExitStatus).HasColumnName("fkExitStatus");

                entity.Property(e => e.Fname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.GtalkId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HiringSource)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LoginPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MachineIpAddress)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Msnid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MSNId")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OfficialEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OutlookId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PassportExpiry).HasColumnType("datetime");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PriorExperience).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.RefCompany1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefCompany2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefCompany3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefContactNo1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefContactNo2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefContactNo3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefDesignation1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefDesignation2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefDesignation3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefEmail1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefEmail2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefEmail3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefName1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefName2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefName3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RelevantExperience).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.SalAccNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SkypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SparkId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TrainingDuration)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VisaExpiry).HasColumnType("datetime");

                entity.Property(e => e.VisaNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WeddingDate).HasColumnType("datetime");

                entity.Property(e => e.YahooId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblHEmployeeRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_EmployeeRole");

                entity.Property(e => e.FkEmployee).HasColumnName("fkEmployee");

                entity.Property(e => e.FkRole).HasColumnName("fkRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblHLeaveStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_LeaveStatus");

                entity.Property(e => e.AdminComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Admin_Comment")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Admin_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Emp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstLineManagerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FirstLineManager_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstLineMangerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkLeaveType).HasColumnName("fkLeaveType");

                entity.Property(e => e.Fldecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("FLDecisiondate");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.HrComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Hr_Comment")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HrId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Hr_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HrStatus).HasColumnName("Hr_Status");

                entity.Property(e => e.Hrrdecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("HRRDecisiondate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeaveAppliedDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveReason)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SecondLineManagerComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SecondLineManagerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SecondLineManager_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Sldecisiondate)
                    .HasColumnType("date")
                    .HasColumnName("SLDecisiondate");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHTimeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_H_TimeLog");

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");

                entity.Property(e => e.Earlycheckoutreson)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fkEmp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Login).HasColumnType("datetime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Logout).HasColumnType("datetime");

                entity.Property(e => e.LogoutIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LogoutIP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ProductiveHours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeBreak)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkingHours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblMasterEmployeeBehavioural>(entity =>
            {
                entity.ToTable("tbl_masterEmployeeBehavioural");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMasterGoalCategory>(entity =>
            {
                entity.ToTable("tbl_masterGoalCategory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_ID")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginTime)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LogoutDate).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ProductiveHrs)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TotalBreaks)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WorkingHrs)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TblUrl>(entity =>
            {
                entity.ToTable("tbl_url");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<TlAcceptEthic>(entity =>
            {
                entity.ToTable("TL_AcceptEthics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Emp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlAnnouncementAccept>(entity =>
            {
                entity.ToTable("TL_AnnouncementAccept");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Emp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkAnnouncement).HasColumnName("fkAnnouncement");

                entity.HasOne(d => d.FkAnnouncementNavigation)
                    .WithMany(p => p.TlAnnouncementAccepts)
                    .HasForeignKey(d => d.FkAnnouncement)
                    .HasConstraintName("RefTL_Announcement2");
            });

            modelBuilder.Entity<TlEthic>(entity =>
            {
                entity.ToTable("TL_Ethics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasMaxLength(6000)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlLateComing>(entity =>
            {
                entity.ToTable("TL_LateComing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Reason).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TlTimeLog>(entity =>
            {
                entity.ToTable("TL_TimeLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Earlycheckoutreson)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FkEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fkEmp_id")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Login).HasColumnType("smalldatetime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Logout).HasColumnType("smalldatetime");

                entity.Property(e => e.LogoutIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LogoutIP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ProductiveHours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TimeBreak)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Userip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WorkingHours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<UpdatedDoj>(entity =>
            {
                entity.ToTable("updatedDOJ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDoj)
                    .HasColumnType("datetime")
                    .HasColumnName("ActualDOJ");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fkempid).HasColumnName("fkempid");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDoj1)
                    .HasColumnType("datetime")
                    .HasColumnName("UpdatedDOJ");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
