using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using LeaveManagement.SP;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeaveManagement.BAL
{
    public class DashboardViewModel
    {
        private readonly Recovered_hrmsnewContext _context;
        private readonly Logging _logging;
        private readonly StoredProcedure _spcontext;

        public DashboardViewModel(Recovered_hrmsnewContext context, StoredProcedure spcontext)
        {
            _context = context;
            _spcontext = spcontext;
            _logging = new Logging(context);
        }
        public async Task<EmployeeResDetails> EditEmpRes(int ID)
        {
            try
            {
                EmployeeResDetails employeeResDetails = new();
                var data = await _context.EmployeeAvailability.Where(x => x.EmpId == ID).FirstOrDefaultAsync();
                if(data != null)
                {
                    employeeResDetails.Id = data.EmpId ?? ID;
                    employeeResDetails.OnBench = data.MarkToBench ?? false;
                    employeeResDetails.PartialAvailable = data.PartialAvailable ?? false;
                    employeeResDetails.ExpPartialDate = data.ExpPartialDateAvailability ?? DateTime.Now;
                    employeeResDetails.Skillset = data.Skillset;
                    employeeResDetails.CurrentProjName = data.CurrentProjName;
                }
                else
                {
                    employeeResDetails.Id = ID;
                    employeeResDetails.ExpPartialDate = DateTime.Now;
                }
                return employeeResDetails;
            }
            catch
            {
                return null;
            }
        }
        public async Task<HrpositionInfo> EditHREmpRes(int ID)
        {
            try
            {
                HrpositionInfo employeeResDetails = new();
                var data = await _context.HrpositionInfo.Where(x => x.Id == ID).FirstOrDefaultAsync();
                if(data != null)
                {
                    employeeResDetails = data;
                }
                else
                {
                    employeeResDetails.Id = 0;
                }
                return employeeResDetails;
            }
            catch
            {
                return null;
            }
        }
        public async Task<bool> UpdateEmpResData(EmployeeResDetails updateLeaveData)
        {
            try
            {
                var data = await _context.EmployeeAvailability.Where(x => x.EmpId == updateLeaveData.Id).FirstOrDefaultAsync();
                if(data != null)
                {
                    _context.EmployeeAvailability.Remove(data);
                }
                EmployeeAvailability employeeAvailability = new();
                employeeAvailability.EmpId = updateLeaveData.Id;
                employeeAvailability.MarkToBench = updateLeaveData.OnBench;
                employeeAvailability.PartialAvailable = updateLeaveData.PartialAvailable;
                employeeAvailability.ExpPartialDateAvailability = updateLeaveData.ExpPartialDate;
                employeeAvailability.Skillset = updateLeaveData.Skillset;
                employeeAvailability.CurrentProjName = updateLeaveData.CurrentProjName;
                _context.EmployeeAvailability.Add(employeeAvailability);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> UpdateEmpHRResData(HrpositionInfo updateLeaveData)
        {
            try
            {
                var data = await _context.HrpositionInfo.Where(x => x.Id == updateLeaveData.Id).FirstOrDefaultAsync();
                if (data != null)
                {
                    data.Title = updateLeaveData.Title;
                    data.Skills = updateLeaveData.Skills;
                    data.Department = updateLeaveData.Department;
                    data.NoOfPosition = updateLeaveData.NoOfPosition;
                    data.Priority = updateLeaveData.Priority;
                    data.Budget = updateLeaveData.Budget;
                    data.ExpectedDate = updateLeaveData.ExpectedDate;
                    data.Experience = updateLeaveData.Experience;
                    data.Status = updateLeaveData.Status;
                    _context.HrpositionInfo.Update(data);
                    _context.SaveChanges();
                }
                else
                {
                    HrpositionInfo employeeAvailability = new();
                    employeeAvailability.Title = updateLeaveData.Title;
                    employeeAvailability.CreatedOn = DateTime.Now.Date;
                    employeeAvailability.Skills = updateLeaveData.Skills;
                    employeeAvailability.Department = updateLeaveData.Department;
                    employeeAvailability.NoOfPosition = updateLeaveData.NoOfPosition;
                    employeeAvailability.Priority = updateLeaveData.Priority;
                    employeeAvailability.Budget = updateLeaveData.Budget;
                    employeeAvailability.ExpectedDate = updateLeaveData.ExpectedDate;
                    employeeAvailability.Experience = updateLeaveData.Experience;
                    employeeAvailability.Status = updateLeaveData.Status;
                    employeeAvailability.RequestedBy = updateLeaveData.RequestedBy;
                    _context.HrpositionInfo.Add(employeeAvailability);
                    _context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<SingleEmployee> EmployeesList()
        {
            try
            {
                List<SingleEmployee> empList = _spcontext.Emp_GetAllEmployeeProfile.FromSqlRaw("[dbo].[Emp_GetAllEmployeeProfile]").ToList();
                DateTime dt = new();
                foreach(var item in empList)
                {
                    dt = Convert.ToDateTime(item.DOJ);
                    DateTime today = DateTime.Now;
                    decimal difference = (today - dt).Days;
                    if (difference > 365)
                    {
                        decimal years = difference / 365;
                        decimal oldexperience = Convert.ToDecimal(item.PriorExperience);
                        years += oldexperience;
                        decimal experience = Math.Round(years, 1);
                        item.Experience = experience.ToString();
                    }
                    else
                    {
                        decimal oldexperience = Convert.ToDecimal(item.PriorExperience);
                        decimal oldexperienceindays = oldexperience + difference / 365;
                        item.Experience = Math.Round(oldexperienceindays, 1).ToString();
                    }
                }
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: DepartmentList", "WEB/API");
                return null;
            }
        }
        public List<HrpositionInfo> HREmployeesList()
        {
            try
            {
                List<HrpositionInfo> empList = _context.HrpositionInfo.ToList();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: DepartmentList", "WEB/API");
                return null;
            }
        }
        public async Task<List<TotalLeaveByDepartment>> PartialAvailable()
        {
            try
            {
                List<TotalLeaveByDepartment> leaves = await _spcontext.HRMS_GetTotalDepartment.FromSqlRaw("[dbo].[HRMS_GetTotalPartialAvailDepartment]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TotalDeptLeaves, Parameter: NULL", "WEB/API");
                return null;
            }

        }
        public async Task<List<TotalLeaveByDepartment>> FullAvailable()
        {
            try
            {
                List<TotalLeaveByDepartment> leaves = await _spcontext.HRMS_GetTotalDepartment.FromSqlRaw("[dbo].[HRMS_GetTotalBechAvailDepartment]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TotalDeptLeaves, Parameter: NULL", "WEB/API");
                return null;
            }

        }
        public async Task<List<TotalLeaveByDepartment>> OpenPosition()
        {
            try
            {
                List<TotalLeaveByDepartment> leaves = await _spcontext.HRMS_GetTotalDepartment.FromSqlRaw("[dbo].[HRMS_GetTotalOpenPositionlDepartment]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TotalDeptLeaves, Parameter: NULL", "WEB/API");
                return null;
            }

        }
        public async Task<List<TotalLeaveByDepartment>> ClosedPosition()
        {
            try
            {
                List<TotalLeaveByDepartment> leaves = await _spcontext.HRMS_GetTotalDepartment.FromSqlRaw("[dbo].[HRMS_GetTotalClosedPositionlDepartment]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TotalDeptLeaves, Parameter: NULL", "WEB/API");
                return null;
            }

        }
    }
}
