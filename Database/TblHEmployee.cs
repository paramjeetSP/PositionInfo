using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblHEmployee
    {
        public int? Id { get; set; }
        public string EmpId { get; set; }
        public string EmpCode { get; set; }
        public string LoginPassword { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? Dob { get; set; }
        public int? ReportingTo { get; set; }
        public int? ProjectReportingTo { get; set; }
        public string EmergencyContact { get; set; }
        public string ExtNumber { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string PresentAddress { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpiry { get; set; }
        public string PermanentAddress { get; set; }
        public string VisaNo { get; set; }
        public DateTime? VisaExpiry { get; set; }
        public string SalAccNo { get; set; }
        public string PanNo { get; set; }
        public string HomePhone { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public DateTime? WeddingDate { get; set; }
        public string PersonalEmail { get; set; }
        public string OfficialEmail { get; set; }
        public string SkypeId { get; set; }
        public string YahooId { get; set; }
        public string Msnid { get; set; }
        public string GtalkId { get; set; }
        public string SparkId { get; set; }
        public string OutlookId { get; set; }
        public int? FkEmpType { get; set; }
        public int? FkDepartment { get; set; }
        public int? FkDesignation { get; set; }
        public int? FkEmpGrade { get; set; }
        public string EmpStatus { get; set; }
        public string ReferredBy { get; set; }
        public string HiringSource { get; set; }
        public DateTime? ExitDate { get; set; }
        public string ExitComment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public string AppraisalDueOn { get; set; }
        public int? FkBloodGroup { get; set; }
        public int? FkExitStatus { get; set; }
        public string RefName1 { get; set; }
        public string RefCompany1 { get; set; }
        public string RefDesignation1 { get; set; }
        public string RefEmail1 { get; set; }
        public string RefContactNo1 { get; set; }
        public string RefName2 { get; set; }
        public string RefCompany2 { get; set; }
        public string RefDesignation2 { get; set; }
        public string RefEmail2 { get; set; }
        public string RefContactNo2 { get; set; }
        public string RefName3 { get; set; }
        public string RefCompany3 { get; set; }
        public string RefDesignation3 { get; set; }
        public string RefEmail3 { get; set; }
        public string RefContactNo3 { get; set; }
        public bool? IsAccessWorkdiary { get; set; }
        public string FullName { get; set; }
        public string MachineIpAddress { get; set; }
        public DateTime? Confirmationdate { get; set; }
        public string DrivingLicienceNo { get; set; }
        public int? FkEmploymentStatus { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? Organizationalemail { get; set; }
        public bool? RelievingMail { get; set; }
        public string CardNumber { get; set; }
        public decimal? RelevantExperience { get; set; }
        public decimal? PriorExperience { get; set; }
        public bool? IsEmailSent { get; set; }
        public string TrainingDuration { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
