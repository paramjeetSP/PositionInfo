using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.BAL
{
    public class DashboardViewModel
    {
        private Recovered_hrmsnewContext _context;
        private Logging _logging;

        public DashboardViewModel(Recovered_hrmsnewContext context)
        {
            _context = context;
            _logging = new Logging(context);
        }
        public async Task<PendingLeaves> pendingLeaves(int userId)
        {
            try
            {
                PendingLeaves leaveData = new PendingLeaves();
                //dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada"
                var isProhibitionEmployee = await _context.Employee.Where(x => x.Id == userId).FirstOrDefaultAsync();
                if (isProhibitionEmployee != null && isProhibitionEmployee.FkEmploymentStatus == 2)//means employee is on prohibition
                {
                    leaveData = await _context.Set<PendingLeaves>().FromSql("dbo.Emp_GetEmployeePendingLeaves_Probation @Userid = {0}", userId).FirstOrDefaultAsync();
                    //leaveData.IsProhibitionEmployee = true;
                }
                else
                {
                    leaveData = await _context.Set<PendingLeaves>().FromSql("dbo.Emp_GetEmployeePendingLeaves @Userid = {0}", userId).FirstOrDefaultAsync();
                    //leaveData.IsProhibitionEmployee = false;
                }
                return leaveData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<List<EmpLeavesStatus>> empLeaveStatus(int userId)
        {
            try
            {
                List<EmpLeavesStatus> _list = await _context.Set<EmpLeavesStatus>().FromSql("dbo.Emp_GetEmployeeLeavesStatus @Userid = {0}", userId).ToListAsync();
                return _list;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: empLeaveStatus, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<GetEmployeeLeavesStatus> editLeaves(int LeaveID)
        {
            try
            {
                GetEmployeeLeavesStatus obj = new GetEmployeeLeavesStatus();
                var data = await _context.LeaveStatus.Where(m => m.Id == LeaveID).FirstOrDefaultAsync();
                obj.LeaveStartDate = String.Format("{0:dd/MM/yyyy}", data.FromDate);
                obj.LeaveEndDate = String.Format("{0:dd/MM/yyyy}", data.ToDate);
                //obj.LeaveRowID = data.Id;
                // obj.ELC = data.Elc;
                //obj.IsELCFlag = Convert.ToBoolean(data.IsElcflag);
                return obj;
            }
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<BalanceLeaveById> editBalanceLeaves(int ID)
        {
            try
            {
                BalanceLeaveById obj = new BalanceLeaveById();
                var data = await _context.BalanceLeave1.Where(m => m.Id == ID).Include(x => x.Emp).Include(x => x.LeaveTypeNavigation).FirstOrDefaultAsync();
                obj.Id = data.Id;
                obj.LeaveType = data.LeaveTypeNavigation.Description;
                obj.Balance = data.Balance.HasValue ? data.Balance.Value : 0;
                //obj.LeaveRowID = data.Id;
                // obj.ELC = data.Elc;
                //obj.IsELCFlag = Convert.ToBoolean(data.IsElcflag);
                return obj;
            }
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<EmployeeResDetails> editEmpRes(int ID)
        {
            try
            {
                EmployeeResDetails employeeResDetails = new EmployeeResDetails();
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
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<bool> updateEmpResData(EmployeeResDetails updateLeaveData)
        {
            try
            {
                var data = await _context.EmployeeAvailability.Where(x => x.EmpId == updateLeaveData.Id).FirstOrDefaultAsync();
                if(data != null)
                {
                    _context.EmployeeAvailability.Remove(data);
                }
                EmployeeAvailability employeeAvailability = new EmployeeAvailability();
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
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return false;
            }
        }
        public async Task<GetEmployeeLeavesStatus> updateLeavesData(UpdateLeaveData updateLeaveData)
        {
            try
            {
                GetEmployeeLeavesStatus obj = new GetEmployeeLeavesStatus();
                var data = await _context.LeaveStatus.Where(x => x.Id == updateLeaveData.LeaveID).FirstOrDefaultAsync();
                //SendMail
                data.FromDate = Convert.ToDateTime(updateLeaveData.LeaveStartDate);
                data.ToDate = Convert.ToDateTime(updateLeaveData.LeaveEndDate);
                //isMailSend = await sendmail.sendEmail(emp.OfficialEmail, pass, emp.FullName);

                _context.LeaveStatus.Update(data);
                _context.SaveChanges();
                // var data = await _context.LeaveStatus.Where(m => m.Id == LeaveID).FirstOrDefaultAsync();
                // obj.LeaveStartDate = data.FromDate.ToString();
                //  obj.LeaveEndDate = data.ToDate.ToString();
                return obj;
            }
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<BalanceLeaveById> updateBalanceLeavesData(UpdateBalanceLeaveData updateLeaveData)
        {
            try
            {
                BalanceLeaveById obj = new BalanceLeaveById();
                var data = await _context.BalanceLeave1.Where(x => x.Id == updateLeaveData.ID).FirstOrDefaultAsync();
                data.Balance = updateLeaveData.Balance;
                _context.BalanceLeave1.Update(data);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<SaveNewLeaveData> SaveNewLeaveData(SaveNewLeaveData saveNewLeaveData)
        {
            try
            {
                LeaveStatus leaveobj = new LeaveStatus();

                var TotalLeaves = 14;
                decimal CasualLeavesLeft = saveNewLeaveData.CasualLeavesLeft;
                decimal SickLeavesLeft = saveNewLeaveData.SickLeavesLeft;
                decimal PaidLeavesLeft = saveNewLeaveData.PaidLeavesLeft;
                decimal WorkFromHomeTaken = saveNewLeaveData.WorkFromHomeTaken;
                decimal WorkFromHomeLeft = saveNewLeaveData.WorkFromHomeLeft;
                var halfday = saveNewLeaveData.IsHalfDay;
                DateTime dt1 = saveNewLeaveData.FromDate;
                DateTime dt2 = saveNewLeaveData.ToDate;
                TimeSpan span = dt2.Subtract(dt1);
                int days = span.Days + 1;
                int IsProbationLeave = 0;
                if (saveNewLeaveData.fkEmploymentStatus == 1)
                {
                    IsProbationLeave = 0;
                }
                if (TotalLeaves <= 0)
                {
                    if (IsProbationLeave == 1)
                    {
                        leaveobj.FkLeaveType = 1;
                    }
                    else
                    {
                        leaveobj.FkLeaveType = 5;
                    }
                    leaveobj.IsLwp = true;
                    //leaveobj.IsLWP = false;
                    leaveobj.Elc = 0;
                    leaveobj.IsElcflag = false;
                }
                else
                {
                    leaveobj.FkLeaveType = saveNewLeaveData.fkLeaveType;
                    if (IsProbationLeave == 0)
                    {
                        if (leaveobj.FkLeaveType == 1)
                        {
                            decimal Casual_PaidLeavesLeft = Decimal.Add(CasualLeavesLeft, PaidLeavesLeft);
                            if (Casual_PaidLeavesLeft > 0)
                            {
                                if (Casual_PaidLeavesLeft < days)
                                {
                                    if (halfday == true && Casual_PaidLeavesLeft < 1)
                                    {
                                        leaveobj.Elc = 0;
                                        leaveobj.IsElcflag = false;
                                        leaveobj.IsLwp = false;
                                    }
                                    else
                                    {
                                        leaveobj.IsElcflag = true;
                                        leaveobj.Elc = days - Casual_PaidLeavesLeft;
                                        leaveobj.IsLwp = false;
                                    }

                                }
                                else
                                {
                                    leaveobj.Elc = 0;
                                    leaveobj.IsElcflag = false;
                                    leaveobj.IsLwp = false;
                                }
                            }
                            else
                            {
                                leaveobj.Elc = 0;
                                leaveobj.IsElcflag = false;
                                leaveobj.IsLwp = true;
                            }

                        }
                        else if (leaveobj.FkLeaveType == 3)
                        {

                            decimal Sick_PaidLeavesLeft = Decimal.Add(SickLeavesLeft, PaidLeavesLeft);
                            if (Sick_PaidLeavesLeft > 0)
                            {
                                if (Sick_PaidLeavesLeft < days)
                                {
                                    if (halfday == true && Sick_PaidLeavesLeft < 1)
                                    {
                                        leaveobj.Elc = 0;
                                        leaveobj.IsElcflag = false;
                                        leaveobj.IsLwp = false;
                                    }
                                    else
                                    {
                                        leaveobj.IsElcflag = true;
                                        leaveobj.Elc = days - Sick_PaidLeavesLeft;
                                        leaveobj.IsLwp = false;
                                    }
                                }
                                else
                                {
                                    leaveobj.Elc = 0;
                                    leaveobj.IsElcflag = false;
                                    leaveobj.IsLwp = false;
                                }
                            }
                            else
                            {
                                leaveobj.Elc = 0;
                                leaveobj.IsElcflag = false;
                                leaveobj.IsLwp = true;
                            }

                        }
                        else if (leaveobj.FkLeaveType == 5)
                        {
                            decimal Casual_PaidLeavesLeft = Decimal.Add(CasualLeavesLeft, PaidLeavesLeft);
                            if (Casual_PaidLeavesLeft > 0)
                            {
                                if (Casual_PaidLeavesLeft < days)
                                {
                                    if (halfday == true && Casual_PaidLeavesLeft < 1)
                                    {
                                        leaveobj.Elc = 0;
                                        leaveobj.IsElcflag = false;
                                        leaveobj.IsLwp = false;
                                    }
                                    else
                                    {
                                        leaveobj.IsElcflag = true;
                                        leaveobj.Elc = days - Casual_PaidLeavesLeft;
                                        leaveobj.IsLwp = false;
                                    }
                                }
                                else
                                {
                                    leaveobj.Elc = 0;
                                    leaveobj.IsElcflag = false;
                                    leaveobj.IsLwp = false;
                                }
                            }
                            else
                            {
                                leaveobj.Elc = 0;
                                leaveobj.IsElcflag = false;
                                leaveobj.IsLwp = true;
                            }
                        }
                        else if (leaveobj.FkLeaveType == 7)
                        {
                            decimal Work_FromHome = WorkFromHomeTaken;
                            if (Work_FromHome > 0)
                            {
                                if (Work_FromHome < days)
                                {
                                    if (halfday == true && Work_FromHome < 1)
                                    {
                                        leaveobj.Elc = 0;
                                        leaveobj.IsElcflag = false;
                                        leaveobj.IsLwp = false;
                                    }
                                    else
                                    {
                                        leaveobj.IsElcflag = true;
                                        leaveobj.Elc = days - Work_FromHome;
                                        leaveobj.IsLwp = false;
                                    }
                                }
                                else
                                {
                                    leaveobj.Elc = 0;
                                    leaveobj.IsElcflag = false;
                                    leaveobj.IsLwp = false;
                                }
                            }
                            else
                            {
                                leaveobj.Elc = 0;
                                leaveobj.IsElcflag = false;
                                leaveobj.IsLwp = true;
                            }
                        }
                        else
                        {
                            leaveobj.Elc = 0;
                            leaveobj.IsElcflag = false;
                            leaveobj.IsLwp = false;
                        }

                    }
                    else
                    {
                        decimal TotalLeave = 14;
                        if (TotalLeave < days)
                        {
                            if (halfday == true && TotalLeave < 1)
                            {
                                leaveobj.Elc = 0;
                                leaveobj.IsElcflag = false;
                                leaveobj.IsLwp = false;
                            }
                            else
                            {
                                leaveobj.IsElcflag = true;
                                leaveobj.Elc = days - 14;
                                leaveobj.IsLwp = false;
                            }
                        }
                        else
                        {
                            leaveobj.IsElcflag = false;
                            leaveobj.Elc = 0;
                            leaveobj.IsLwp = false;
                        }
                    }
                }
                if (IsProbationLeave == 1)
                {
                    leaveobj.IsProbationLeave = Convert.ToBoolean(IsProbationLeave);
                }
                else
                {
                    leaveobj.IsProbationLeave = false;
                }
                leaveobj.EmpId = saveNewLeaveData.Emp_Id;
                leaveobj.FkLeaveType = saveNewLeaveData.fkLeaveType;
                leaveobj.Department = saveNewLeaveData.Department.ToString();
                leaveobj.FromDate = Convert.ToDateTime(saveNewLeaveData.FromDate);
                leaveobj.ToDate = Convert.ToDateTime(saveNewLeaveData.ToDate);
                leaveobj.LeaveReason = saveNewLeaveData.LeaveReason;
                leaveobj.FirstLineManagerId = saveNewLeaveData.FirstLineManager_id;
                leaveobj.FirstLineManagerStatus = 1;
                leaveobj.SecondLineManagerId = saveNewLeaveData.SecondLineManager_id;
                leaveobj.SecondLineManagerStatus = 1;
                leaveobj.HrId = saveNewLeaveData.Hr_id;
                leaveobj.HrStatus = 1;
                leaveobj.EmpLeaveStatus = 1;
                leaveobj.LeaveAppliedDate = DateTime.Now;
                leaveobj.CreatedOn = DateTime.Now;
                leaveobj.CreatedBy = saveNewLeaveData.Emp_Id;
                // obj.IsHalfDay = saveNewLeaveData.IsHalfDay;
                if (saveNewLeaveData.fkEmploymentStatus == 2)
                {
                    leaveobj.IsProbationLeave = true;
                }
                else
                {
                    leaveobj.IsProbationLeave = false;
                }


                _context.LeaveStatus.Add(leaveobj);
                _context.SaveChanges();

                return saveNewLeaveData;
            }
            catch (Exception ex)
            {
                // _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeaves, Parameter: userId" + userId, "WEB/API");
                return null;
            }
        }
        public async Task<Employee> Login(string UserName, String Password, string AuthCode)
        {
            try
            {
                Employee employee = await _context.Employee.Where(x => x.EmpId == UserName && x.LoginPassword == Password && x.EmpStatus == "Active" && x.Tfmp == AuthCode).FirstOrDefaultAsync();
                return employee;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: Login, Parameter: UserName=" + UserName + " Password=" + Password + " AuthCod=" + AuthCode, "WEB /API");
                return null;
            }
        }
        public async Task<SingleEmployee> profile(int empId)
        {
            try
            {
                SingleEmployee employee = await _context.Set<SingleEmployee>().FromSql("dbo.Emp_GetAllEmployeeProfileById @id = {0}", empId).FirstOrDefaultAsync();
                return employee;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: profile, Parameter: empId=" + empId, "WEB/API");
                return null;
            }

        }
        public async Task<List<SingleEmployee>> AllEmployees()
        {
            try
            {
                List<SingleEmployee> _list = await _context.Set<SingleEmployee>().FromSql("[dbo].[Emp_GetAllEmployeeProfile]").ToListAsync();
                return _list;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }
        public List<SingleEmployee> EmployeesList()
        {
            try
            {
                List<SingleEmployee> empList = _context.Set<SingleEmployee>().FromSql("[dbo].[Emp_GetAllEmployeeProfile]").ToList();
                DateTime dt = new DateTime();
                foreach(var item in empList)
                {
                    dt = Convert.ToDateTime(item.DOJ);
                    DateTime today = DateTime.Now;
                    decimal difference = (today - dt).Days;
                    if (difference > 365)
                    {
                        decimal years = difference / 365;
                        decimal oldexperience = Convert.ToDecimal(item.PriorExperience);
                        years = years + oldexperience;
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
        public async Task<List<TopLeaves>> TopLeaves()
        {
            try
            {
                List<TopLeaves> leaves = await _context.Set<TopLeaves>().FromSql("[dbo].[HRMS_Get_Top5Leave]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TopLeaves", "WEB/API");
                return null;
            }
        }
        public async Task<List<TopLeavesDept>> TopLeavesByDept()
        {
            try
            {
                List<TopLeavesDept> leaves = await _context.Set<TopLeavesDept>().FromSql("[dbo].[HRMS_Get_TopLeaveByDepartment]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TopLeaves", "WEB/API");
                return null;
            }
        }

        //Department List
        public List<DepartmentList> DepartmentList()
        {
            try
            {
                List<DepartmentList> deptList = _context.Set<DepartmentList>().FromSql("[dbo].[Emp_GetAllDepartment]").ToList();
                var selectedItem = deptList.Where(y => y.DeptName == "MED").FirstOrDefault();
                return deptList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: DepartmentList", "WEB/API");
                return null;
            }
        }
        public async Task<List<Top5EmployeeByDepartment>> TopDepartmentLeaves(int DepId)
        {
            try
            {
                List<Top5EmployeeByDepartment> topleaves = await _context.Set<Top5EmployeeByDepartment>().FromSql("[dbo].[HRMS_Top5EmployeeByDepartmentId] @DepId = {0}", DepId).ToListAsync();
                return topleaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TopDepartmentLeaves, Parameter: DepId=" + DepId + "", "WEB/API");
                return null;
            }

        }
        public async Task<List<TotalLeaveByDepartment>> TotalDeptLeaves()
        {
            try
            {
                List<TotalLeaveByDepartment> leaves = await _context.Set<TotalLeaveByDepartment>().FromSql("[dbo].[HRMS_GetTotalLeaveByDepartment]").ToListAsync();
                return leaves;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: TotalDeptLeaves, Parameter: NULL", "WEB/API");
                return null;
            }

        }

        public PendingLeaves pendingLeavesDetails(int userId)
        {
            try
            {
                //dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada"
                PendingLeaves leaveData = _context.Set<PendingLeaves>().FromSql("dbo.Emp_GetEmployeePendingLeaves @Userid = {0}", userId).FirstOrDefault();
                return leaveData;

            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: pendingLeavesDetails, Parameter: userId:" + userId, "WEB/API");
                return null;
            }

        }

        public async Task<List<EmployeesLeaveDetails>> employeesLeaveDetailsArea(int DeptID, int EmpID, string FromDate, string ToDate)
        {
            //List<EmployeesLeaveDetails> empleaveData = await _context.Set<EmployeesLeaveDetails>().FromSql("[dbo].[HRMS_GetEmployeesLeaveDetails @EmpID = @]").ToListAsync();
            try
            {
                List<EmployeesLeaveDetails> empleaveData = await _context.Set<EmployeesLeaveDetails>().FromSql("[dbo].[HRMS_GetEmployeesLeaveDetails] @EmpID = {0},@DeptId = {1}, @fromdate = {2}, @todate = {3}", EmpID, DeptID, FromDate, ToDate).ToListAsync();
                return empleaveData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: employeesLeaveDetailsArea, Parameter: DeptID:" + DeptID + ", EmpID:" + EmpID + ", FromDate:" + FromDate + ", ToDate:" + ToDate, "WEB/API");
                return null;
            }

        }

        public async Task<List<EmployeesLeaveDetails>> employeesLeaveDetailsExportMonthlyLeaves(int DeptID, int EmpID, string FromDate, string ToDate)
        {
            try
            {
                List<EmployeesLeaveDetails> empleaveData = await _context.Set<EmployeesLeaveDetails>().FromSql("[dbo].[HRMS_GetEmployeesLeaveDetails_MonthReport] @EmpID = {0},@DeptId = {1}, @FromDate = {2}, @ToDate = {3}", EmpID, DeptID, FromDate, ToDate).ToListAsync();
                return empleaveData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: employeesLeaveDetailsExportMonthlyLeaves, Parameter: DeptID:" + DeptID + ", EmpID:" + EmpID + ", FromDate:" + FromDate + ", ToDate:" + ToDate, "WEB/API");
                return null;
            }

        }

        public async Task<GetUserImagePath> ImagePath(int empId)
        {
            try
            {
                GetUserImagePath employee = await _context.Set<GetUserImagePath>().FromSql("dbo.Emp_GetUserImagePath @userid = {0}", empId).FirstOrDefaultAsync();
                return employee;

            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: ImagePath, Parameter: empId:" + empId, "WEB/API");
                return null;
            }

        }
        public List<EmployeeList> EmployeeList(int depID)
        {
            try
            {
                List<EmployeeList> empList = _context.Set<EmployeeList>().FromSql("[dbo].[GetEmployeeList] @Deptid = {0}", depID).ToList();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: EmployeeList, Parameter: depID:" + depID, "WEB/API");
                return null;
            }
        }
        public async Task<FirstLineManager> GetFirstLineManager(string emp_id)
        {
            try
            {
                FirstLineManager firstLineManager = await _context.Set<FirstLineManager>().FromSql("dbo.HRMS_GetReportingManagerbyEmpid @Emp_id = {0}", emp_id).FirstOrDefaultAsync();
                return firstLineManager;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: GetFirstLineManager, Parameter: emp_id:" + emp_id, "WEB/API");
                return null;
            }

        }


        public async Task<SecondLineManager> GetSecondLineManager(string emp_id)
        {
            try
            {
                SecondLineManager secondLineManager = await _context.Set<SecondLineManager>().FromSql("dbo.HRMS_GetReportingManagerbyEmpid @Emp_id = {0}", emp_id).FirstOrDefaultAsync();
                return secondLineManager;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: GetSecondLineManager, Parameter: emp_id:" + emp_id, "WEB/API");
                return null;
            }

        }

        public async Task<ManagerDetails> GetManagerDetails(int id)
        {
            try
            {
                ManagerDetails ManagerDetails = await _context.Set<ManagerDetails>().FromSql("dbo.HRMS_GetDepartmentManager @ID = {0}", id).FirstOrDefaultAsync();
                return ManagerDetails;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: Appraisal, methodName: GetManagerDetails, Parameter: emp_id:" + id, "WEB/API");
                return null;
            }

        }
        public async Task<List<EmployeeList>> EmployeeListDet(int depID)
        {
            try
            {
                List<EmployeeList> empList = await _context.Set<EmployeeList>().FromSql("[dbo].[GetEmployeeList] @Deptid = {0}", depID).ToListAsync();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: EmployeeListDet, Parameter: depID:" + depID, "WEB/API");
                return null;
            }
        }
        public string GetHrName()
        {
            try
            {
                string empid = string.Empty;
                var _role = _context.EmployeeRole.FirstOrDefault(c => c.FkRole == 5);
                if (_role != null)
                {
                    var employee = _context.Employee.FirstOrDefault(c => c.Id == _role.FkEmployee);
                    if (employee != null)
                    {
                        empid = employee.EmpId;
                    }
                }
                return empid;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: GetHrName, Parameter: NULL", "WEB/API");
                return null;
            }

        }

        public async Task<List<GetEmployeeLeavesStatus>> LeaveHistoryByID(int Userid, int fkLeaveType, int lwp)
        {
            try
            {
                List<GetEmployeeLeavesStatus> employeeLeaveDetail = await _context.Set<GetEmployeeLeavesStatus>().FromSql("dbo.[Emp_GetEmployeeLeaves_History]  @Userid = {0},@fkLeaveType = {1},@lwp = {2}", Userid, fkLeaveType, lwp).ToListAsync();
                return employeeLeaveDetail;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LeaveHistoryByID, Parameter: Userid=" + Userid + ", fkLeaveType=" + fkLeaveType + ", lwp=" + lwp, "WEB/API");
                return null;
            }
        }

        public async Task<List<CustomLeaveDetail>> employeesCustomLeaveDetailsArea(DateTime? StartDate, DateTime? EndDate, int? DeptId, int? EmpID)
        {
            //List<EmployeesLeaveDetails> empleaveData = await _context.Set<EmployeesLeaveDetails>().FromSql("[dbo].[HRMS_GetEmployeesLeaveDetails @EmpID = @]").ToListAsync();
            try
            {
                List<CustomLeaveDetail> empleaveData = new List<CustomLeaveDetail>();
                if (StartDate == null && EndDate == null)
                {
                    empleaveData = await _context.Set<CustomLeaveDetail>().FromSql("[dbo].[HRMS_GetEmployeesLeaveDetails_Coustom_Report] @from = {0},@to = {1}, @DeptID = {2}", null, null, DeptId).ToListAsync();
                }
                else
                {
                    empleaveData = await _context.Set<CustomLeaveDetail>().FromSql("[dbo].[HRMS_GetEmployeesLeaveDetails_Coustom_Report] @from = {0},@to = {1}, @DeptID = {2}", StartDate, EndDate, DeptId).ToListAsync();
                }
                return empleaveData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: employeesCustomLeaveDetailsArea, Parameter: StartDate=" + StartDate + ", EndDate=" + EndDate + ", DeptId=" + DeptId + ", EmpID=" + EmpID, "WEB/API");
                return null;
            }

        }
        public async Task<CalculateLeavesCount> SummarisedLeavesCounts(int userId, int fkLeaveType, int lwp)
        {
            try
            {
                //dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada"
                CalculateLeavesCount leaveData = new CalculateLeavesCount();
                leaveData = await _context.Set<CalculateLeavesCount>().FromSql("dbo.[usp_Total_CalculateLeaves] @UserId = {0},@fkLeaveType = {1},@lwp = {2}", userId, fkLeaveType, lwp).FirstOrDefaultAsync();
                // if (leaveData == null) { leaveData.PaidLeavesLeft = 0; leaveData.SickLeavesLeft = 0; leaveData.CasualLeavesLeft = 0; leaveData.fkleavetype = fkLeaveType; leaveData.EmpID = userId; }
                return leaveData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: SummarisedLeavesCounts, Parameter: userId=" + userId + ", fkLeaveType=" + fkLeaveType + ", lwp=" + lwp, "WEB/API");
                //throw;
                return null;
            }
        }

        public CalculateLeavesTakenByYear LeavesCountsPerYearByID(int userId, int fkLeaveType, int lwp)
        {
            try
            {
                //dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada"
                CalculateLeavesTakenByYear leavePerYearData = new CalculateLeavesTakenByYear();
                leavePerYearData = _context.Set<CalculateLeavesTakenByYear>().FromSql("dbo.[usp_CalculateLeavesTaken_By_Year] @Userid = {0},@fkLeaveType = {1},@lwp = {2}", userId, fkLeaveType, lwp).FirstOrDefault();
                //if(leavePerYearData == null) { leavePerYearData.PL = 0; leavePerYearData.SL = 0; leavePerYearData.TL = 0; leavePerYearData.fkleavetype = fkLeaveType; leavePerYearData.Emp_id = userId; }
                return leavePerYearData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LeavesCountsPerYearByID, Parameter: userId=" + userId + ", fkLeaveType=" + fkLeaveType + ", lwp=" + lwp, "WEB/API");
                //throw;
                return null;
            }

        }
        public async Task<List<GetEmployeeLeavesHistory_LWP>> LeaveHistoryLWPByID(int Userid, int lwp)
        {
            try
            {
                List<GetEmployeeLeavesHistory_LWP> employeeLeaveDetail = await _context.Set<GetEmployeeLeavesHistory_LWP>().FromSql("dbo.[Emp_GetEmployeeLeaves_History_LWP]  @Userid = {0},@lwp = {1}", Userid, lwp).ToListAsync();
                return employeeLeaveDetail;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LeaveHistoryLWPByID, Parameter: Userid=" + Userid + ", lwp=" + lwp, "WEB/API");
                return null;
            }
        }
        public async Task<List<BalanceLeaveById>> BalanceLeaveByID(int Userid)
        {
            try
            {
                var employeeLeaveDetail = from bal in _context.BalanceLeave1.Where(x => x.EmpId == Userid && x.IsDeleted==false).OrderByDescending(x=>x.CreatedOn)
                                          select new BalanceLeaveById
                                          {
                                              Id = bal.Id,
                                              Name = bal.Emp.FullName,
                                              LeaveId = bal.LeaveType.Value,
                                              LeaveType = bal.LeaveTypeNavigation.Description,
                                              Balance = bal.Balance.HasValue ? bal.Balance.Value : 0,
                                              Description=bal.Description
                                          };
                return await employeeLeaveDetail.ToListAsync();
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: BalanceLeaveByID, Parameter: Userid=" + Userid, "WEB/API");
                return null;
            }
        }
        public CalculateLeavesTakenLWPByYear LeavesCountsPerYearLWPByID(int userId, int fkLeaveType, int lwp)
        {
            try
            {
                //dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada"
                CalculateLeavesTakenLWPByYear leavePerYearData = new CalculateLeavesTakenLWPByYear();
                leavePerYearData = _context.Set<CalculateLeavesTakenLWPByYear>().FromSql("dbo.[usp_CalculateLeavesTaken_By_Year] @Userid = {0},@fkLeaveType = {1},@lwp = {2}", userId, fkLeaveType, lwp).FirstOrDefault();
                return leavePerYearData;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LeavesCountsPerYearLWPByID, Parameter: userId=" + userId + ", fkLeaveType=" + fkLeaveType + ", lwp=" + lwp, "WEB/API");
                return null;
            }
        }

        public async Task<ClsEmp_GetEmployeePendingLeaves> EmpLeaveTakenAndLeftDetails(int userId)
        {
            try
            {
                ClsEmp_GetEmployeePendingLeaves clsEmpLeaveTakenAndLeftDetails = new ClsEmp_GetEmployeePendingLeaves();

                clsEmpLeaveTakenAndLeftDetails = await _context.Set<ClsEmp_GetEmployeePendingLeaves>().FromSql("dbo.[Emp_GetEmployeePendingLeaves] @Userid = {0}", userId).FirstOrDefaultAsync();
                // clsEmpLeaveTakenAndLeftDetails = await _context.Set<ClsEmpLeaveTakenAndLeftDetails>().FromSql("dbo.[Emp_TakenAndLeftLeaveDetails] @Userid = {0}", userId).FirstOrDefaultAsync();
                return clsEmpLeaveTakenAndLeftDetails;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: EmpLeaveTakenAndLeftDetails, Parameter: userId=" + userId, "WEB/API");
                return null;
            }

        }

        public async Task<List<ClsMonthlyFinalList>> MonthlyList()
        {
            try
            {
                /////for Testing
                //ServiceProvider<DateTime> dateTimeProvider = new ServiceProvider<DateTime>();
                //// 2007-05-07 is a Monday
                //dateTimeProvider.Preset(new DateTime(2007, 5, 7), "Now");
                /////END
                int incrementer = 0;
                List<ClsMonthlyFinalList> monthLists = new List<ClsMonthlyFinalList>();
                List<ClsMonthlyList> financialMnth = new List<ClsMonthlyList>(); ;
                int todayYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                int todayMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
                //int todayMonth = 5;
                string todayMonthinWords = DateTime.Now.ToString("MMM");
                //string todayMonthinWords = "May";
                int todayDate = Convert.ToInt32(DateTime.Now.ToString("dd"));
                //int todayDate = 28;
                //todayDate = todayDate + 1;// need to comment
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 12,
                    value = "Apr",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 1,
                    value = "May",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 2,
                    value = "Jun",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 3,
                    value = "Jul",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 4,
                    value = "Aug",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 5,
                    value = "Sep",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 6,
                    value = "Oct",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 7,
                    value = "Nov",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 8,
                    value = "Dec",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 9,
                    value = "Jan",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 10,
                    value = "Feb",
                });
                financialMnth.Add(new ClsMonthlyList
                {
                    key = 11,
                    value = "Mar",
                });
                int financialmnth = financialMnth.Where(y => y.value == todayMonthinWords).Select(x => x.key).FirstOrDefault();
                if (todayDate > 15)
                {
                    incrementer = financialmnth + 1;
                }
                else
                {
                    incrementer = financialmnth;
                }
                int monthdiffFromPrevFinancialYear = todayMonth;
                if (todayMonth == 5 && todayDate > 15)
                {
                    monthLists.Add(new ClsMonthlyFinalList
                    {
                        key = "16 April " + DateTime.Now.ToString("yyyy") + " - 15 May " + DateTime.Now.ToString("yyyy"),
                        value = "16 April " + DateTime.Now.ToString("yyyy") + " - 15 May " + DateTime.Now.ToString("yyyy")
                    });
                    //monthLists.Add(new ClsMonthlyFinalList
                    //{
                    //    key = "16 March " + DateTime.Now.ToString("yyyy") + " - 15 April " + DateTime.Now.ToString("yyyy"),
                    //    value = "16 March " + DateTime.Now.ToString("yyyy") + " - 15 April " + DateTime.Now.ToString("yyyy")
                    //});
                    //monthLists.Add(new ClsMonthlyFinalList
                    //{
                    //    key = "16  Feb" + DateTime.Now.ToString("yyyy") + " - 15 March " + DateTime.Now.ToString("yyyy"),
                    //    value = "16 Feb " + DateTime.Now.ToString("yyyy") + " - 15 March " + DateTime.Now.ToString("yyyy")
                    //});

                }
                else
                {
                    for (int i = 1; i <= incrementer; i++)
                    {
                        string FromYear = string.Empty;
                        string FromMonth = string.Empty;
                        string ToYear = string.Empty;
                        string ToMonth = string.Empty;
                        if (todayDate <= 15)
                        {
                            FromYear = string.Empty;
                            //FromMonth = DateTime.Now.AddMonths(-(i)).ToString("MMM");
                            FromMonth = DateTime.Now.AddMonths(-(i + 1)).ToString("MMM");
                            if (financialmnth == 11 || financialmnth == 10 || financialmnth == 9)
                            {
                                if (FromMonth == "Dec" || FromMonth == "Nov" || FromMonth == "Oct" || FromMonth == "Sep" || FromMonth == "Aug" || FromMonth == "Jul" || FromMonth == "Jun" || FromMonth == "May" || FromMonth == "Apr")
                                {
                                    FromYear = DateTime.Now.AddYears(-1).ToString("yyyy");
                                }
                                else
                                {
                                    FromYear = DateTime.Now.ToString("yyyy");
                                }
                            }
                            else
                            {
                                FromYear = DateTime.Now.ToString("yyyy");
                            }
                            //ToYear = string.Empty;
                            //ToMonth = DateTime.Now.AddMonths(-(i - 1)).ToString("MMM");
                            ToMonth = DateTime.Now.AddMonths(-(i)).ToString("MMM");
                            if (financialmnth == 11 || financialmnth == 10 || financialmnth == 9 || financialmnth == 8)
                            {
                                if (ToMonth == "Dec" || ToMonth == "Nov" || ToMonth == "Oct" || ToMonth == "Sep" || ToMonth == "Aug" || ToMonth == "Jul" || ToMonth == "Jun" || ToMonth == "May" || ToMonth == "Apr")
                                {
                                    ToYear = DateTime.Now.AddYears(-1).ToString("yyyy");
                                }
                                else
                                {
                                    ToYear = DateTime.Now.ToString("yyyy");
                                }

                            }

                        }
                        else
                        {
                            FromYear = string.Empty;
                            FromMonth = DateTime.Now.AddMonths(-(i)).ToString("MMM");
                            //int frmMnth = Convert.ToInt32(DateTime.Now.AddMonths(-(i - 1)).ToString("MM"));
                            if (financialmnth == 11 || financialmnth == 10 || financialmnth == 9)
                            {
                                if (FromMonth == "Dec" || FromMonth == "Nov" || FromMonth == "Oct" || FromMonth == "Sep" || FromMonth == "Aug" || FromMonth == "Jul" || FromMonth == "Jun" || FromMonth == "May" || FromMonth == "Apr")
                                {
                                    FromYear = DateTime.Now.AddYears(-1).ToString("yyyy");
                                }
                                else
                                {
                                    FromYear = DateTime.Now.ToString("yyyy");
                                }
                            }
                            else
                            {
                                FromYear = DateTime.Now.ToString("yyyy");
                            }
                            //ToYear = string.Empty;
                            //ToMonth = DateTime.Now.AddMonths(-(i - 2)).ToString("MMM");
                            ToMonth = DateTime.Now.AddMonths(-(i - 1)).ToString("MMM");
                            if (financialmnth == 11 || financialmnth == 10 || financialmnth == 9 || financialmnth == 8)
                            {
                                if (ToMonth == "Dec" || ToMonth == "Nov" || ToMonth == "Oct" || ToMonth == "Sep" || ToMonth == "Aug" || ToMonth == "Jul" || ToMonth == "Jun" || ToMonth == "May" || ToMonth == "Apr")
                                {
                                    ToYear = DateTime.Now.AddYears(-1).ToString("yyyy");
                                }
                                else
                                {
                                    ToYear = DateTime.Now.ToString("yyyy");
                                }

                            }

                        }
                        monthLists.Add(new ClsMonthlyFinalList
                        {
                            key = "16 " + FromMonth + " " + FromYear + " - 15 " + ToMonth + " " + ToYear,
                            value = "16 " + FromMonth + " " + FromYear + " - 15 " + ToMonth + " " + ToYear,
                        });
                    }
                }

                string FinancialStartYear = DateTime.Now.ToString("YYYY");
                //monthLists = 
                return monthLists;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: MonthlyList, Parameter: NULL", "WEB/API");
                return null;
            }

        }


        public async Task<Emp_ProbationStatusWithColName> Emp_ProbationStatus(int emp_id)
        {
            try
            {
                Emp_ProbationStatusWithColName Provisionstatus = await _context.Set<Emp_ProbationStatusWithColName>().FromSql("[dbo].[Emp_ProbationStatus_withcolname] @Userid = {0}", emp_id).FirstOrDefaultAsync();
                return Provisionstatus;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: Emp_ProbationStatus, Parameter: emp_id=" + emp_id, "WEB/API");
                return null;
            }

        }

        public async Task<AppVersion> GetAppVersionInfo()
        {
            try
            {
                var appVersion = await _context.MobileAppUpdateTable.FirstOrDefaultAsync();
                return new AppVersion()
                {
                    Id = appVersion.Id,
                    PreviousVersionFileLinkAndroid = appVersion.PreviousVersionFileLinkAndroid,
                    PreviousVersionFileLinkIOS = appVersion.PreviousVersionFileLinkIos,
                    VersionFileLinkAndroid = appVersion.VersionFileLinkAndroid,
                    VersionFileLinkIOS = appVersion.VersionFileLinkIos,
                    VersionMessageText = appVersion.VersionMessageText,
                    VersionNumber = appVersion.VersionNumber//,
                    //VersionNumberIOS = appVersion.VersionNumberIos
                };
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: GetAppVersionInfo, Parameter: NULL", "WEB/API");
                return null;
            }
        }

        //Employee Code List
        public async Task<List<EmployeeList_withCode>> EmployeeListWithCodeGenerator()
        {
            try
            {
                List<EmployeeList_withCode> empList = await _context.Set<EmployeeList_withCode>().FromSql("[dbo].[GetEmployeeRandomCode]").ToListAsync();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: EmployeeListWithCodeGenerator, Parameter: NULL", "WEB/API");
                return null;
            }
        }

        public async Task<bool> CodeGenerator(int userID)
        {
            try
            {
                SendMail sendmail = new SendMail();
                bool isMailSend = false;
                RandomGenerator generator = new RandomGenerator();
                int counter = 0;
                if (userID == 0)
                {
                    var userList = await EmployeeListWithCodeGenerator();
                    foreach (var item in userList)
                    {
                        string pass = generator.RandomPassword();
                        Employee emp = new Employee();
                        emp = await _context.Employee.Where(x => x.Id == item.UserID).FirstOrDefaultAsync();
                        //SendMail
                        isMailSend = true;
                        //isMailSend = await sendmail.sendEmail(emp.OfficialEmail, pass, emp.FullName);
                        emp.Tfmp = pass;
                        _context.Employee.Update(emp);
                        await _context.SaveChangesAsync();
                        if (counter == 5)
                        {
                            break;
                        }
                        counter += 1;
                    }
                }
                else
                {
                    Employee emp = new Employee();
                    string pass = generator.RandomPassword();
                    emp = await _context.Employee.Where(x => x.Id == userID).FirstOrDefaultAsync();
                    emp.Tfmp = pass;
                    //sendMail
                    isMailSend = await sendmail.sendEmail(emp.OfficialEmail, pass, emp.FullName);
                    _context.Employee.Update(emp);
                    await _context.SaveChangesAsync();
                }

                //_context.tb
                return true;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: CodeGenerator, Parameter: userID=" + userID, "WEB/API");
                return false;
            }
        }

        public async Task<bool> GetProhbation(int userID)
        {
            bool Is_Prohbition = false;
            try
            {
                var appVersion = await _context.Employee.Where(x => x.Id == userID && x.FkEmploymentStatus == 2).FirstOrDefaultAsync();
                if (appVersion != null)
                {
                    Is_Prohbition = true;
                }
                return Is_Prohbition;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: GetProhbation, Parameter: userID=" + userID, "WEB/API");
                return Is_Prohbition;
            }
        }

        public async Task<bool> ExceptionLogger(ExceptionTrace exceptionTrace)
        {
            try
            {
                TblExceptionLogger tbl = new TblExceptionLogger();
                tbl.ControllerName = exceptionTrace.controllerName;
                tbl.Platform = exceptionTrace.Platform;
                tbl.LogTime = DateTime.Now;
                tbl.InnerException = exceptionTrace.InnerMessage;
                tbl.ExceptionMessage = exceptionTrace.Message;
                tbl.ExceptionStackTrace = exceptionTrace.stackTrace;
                _context.TblExceptionLogger.Add(tbl);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: ExceptionLogger, Parameter: exceptionTrace.controllerName=" + exceptionTrace.controllerName + ", exceptionTrace.Platform=" + exceptionTrace.Platform + ", exceptionTrace.InnerMessage=" + exceptionTrace.InnerMessage + ", exceptionTrace.Message=" + exceptionTrace.Message + ", exceptionTrace.stackTrace=" + exceptionTrace.stackTrace, "WEB/API");
                return false;
            }
        }

        public async Task<ProhbitionEmployeeList> ProhbitionEmployeeLeaves(int UserID)
        {
            try
            {
                ProhbitionEmployeeList empList = await _context.Set<ProhbitionEmployeeList>().FromSql("[dbo].[Emp_GetEmployeePendingLeaves_Probation] @Userid = {0}", UserID).FirstOrDefaultAsync();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: ProhbitionEmployeeLeaves, Parameter: UserID=" + UserID, "WEB/API");
                return null;
            }
        }
        public async Task<List<LateComing_Details>> LateComingDetails(string StartDate, string EndDate)
        {
            try
            {
                List<LateComing_Details> empList = await _context.Set<LateComing_Details>().FromSql("[dbo].[Emp_LateComing] @fromdate={0}, @todate={1}", StartDate, EndDate).ToListAsync();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LateComingDetails, Parameter: NULL ", "WEB/API");
                return null;
            }
        }

        public async Task<List<LateComing_Details_History>> LateComing_Details_History(string StartDate, string EndDate, int? UserID, int returnList)
        {
            try
            {

                List<LateComing_Details_History> empList = await _context.Set<LateComing_Details_History>().FromSql("[dbo].[Emp_LateComing_Details_History]@Userid = {0}, @fromdate={1}, @todate={2},@return={3}", UserID, StartDate, EndDate, returnList).ToListAsync();
                return empList;
            }

            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LateComing_Details_History, Parameter: UserID: " + UserID, "WEB/API");
                return null;
            }
        }

        public async Task<List<LessWorkingHours_Details>> LessWorkingHour_Details(string StartDate, string EndDate)
        {
            try
            {
                List<LessWorkingHours_Details> empList = await _context.Set<LessWorkingHours_Details>().FromSql("[dbo].[Emp_LateComing_Details] @fromdate={0}, @todate={1}", StartDate, EndDate).ToListAsync();
                return empList;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LateComingDetails, Parameter: NULL ", "WEB/API");
                return null;
            }
        }

        public async Task<List<WorkingHoursDetails>> EmpWorkingHoursDetail(string StartDate, string EndDate, int? UserID, int returnList)
        {
            try
            {

                List<WorkingHoursDetails> empList = await _context.Set<WorkingHoursDetails>().FromSql("[dbo].[Emp_LateComing_Details_History]@Userid = {0}, @fromdate={1}, @todate={2},@return={3}", UserID, StartDate, EndDate, returnList).ToListAsync();
                return empList;
            }

            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: LateComing_Details_History, Parameter: UserID: " + UserID, "WEB/API");
                return null;
            }
        }


        //public async Task<EmployeeGoalDetails> EmployeeGoalDetails(int empId)
        //{
        //    try
        //    {
        //        List<EmployeeGoalDetails> employee = await _context.Set<EmployeeGoalDetails>
        //        return employee;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: profile, Parameter: empId=" + empId, "WEB/API");
        //        return null;
        //    }
        //}

    }
}
