using System;
using System.ComponentModel.DataAnnotations;

namespace ResourcePortal.Models.SpModels
{
    public class SingleEmployee
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string FullName { get; set; }
        public string OfficialEmail { get; set; }
        public string Mobile { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }
        public string Department { get; set; }
        public string PermanentAddress { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string Grade { get; set; }
        public string DOJ { get; set; }
        public string LName { get; set; }
        public string ConfirmationStatus { get; set; }
        public string Experience { get; set; }
        public decimal PriorExperience { get; set; }
        public string PartialAvailable { get; set; }
        public string MarkToBench { get; set; }
        public string ExpPartialDateAvailability { get; set; }
        public string Skillset { get; set; }
        public string CurrentProject { get; set; }
    }
    public class DepartmentList
    {
        [Key]
        public int ID { get; set; }
        public string DeptName { get; set; }
    }
    public class TotalLeaveByDepartment
    {
        [Key]
        public Int64 RowId { get; set; }
        public string DeptName { get; set; }
        public decimal ActualCount { get; set; }
    }
    public class EmployeeResDetails
    {
        public int Id { get; set; }
        public bool OnBench { get; set; }
        public bool PartialAvailable { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpPartialDate { get; set; }
        public string Skillset { get; set; }
        public string CurrentProjName { get; set; }
    }
}
