using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    //public class LeavesController : Controller
    public class LeavesController : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        public LeavesController(Recovered_hrmsnewContext context)
        {
            _context = context;
            model = new DashboardViewModel(context);
        }

        [HttpGet]
        [Route("Reports")]
        public async Task<IActionResult> Index()
        {
          
            //string Current_Month = DateTime.Now.ToString("MMM");
            DateTime d = DateTime.Now;
            string Previous_Month = string.Empty;
            string Current_Month = string.Empty;
            string currentMonth = string.Empty;
            string prevMonth = string.Empty;

            string PreviousDate = string.Empty;
            string CurrentDate = string.Empty;
            //string Previous_Month = d.AddMonths(-1).ToString("MMM");
            string Current_Year = DateTime.Now.ToString("yyyy");
            string Previous_Year = DateTime.Now.ToString("yyyy");


            if (d.Day > 15)
            {

                //Previous_Month = d.ToString("MMM");
                Previous_Month = d.AddMonths(-1).ToString("MMM");
                prevMonth = d.AddMonths(-1).ToString("MM");
                //Current_Month = d.AddMonths(1).ToString("MMM");
                Current_Month = d.AddMonths(0).ToString("MMM");
                currentMonth = d.AddMonths(0).ToString("MM");
            }
            else
            {

                Previous_Month = d.AddMonths(-2).ToString("MMM");
                prevMonth = d.AddMonths(-2).ToString("MM");
                //Previous_Month = d.AddMonths(-1).ToString("MMM");
                //Current_Month = d.ToString("MMM");
                Current_Month = d.AddMonths(-1).ToString("MMM");
                currentMonth = d.AddMonths(-1).ToString("MM");
            }

            if (Previous_Month == "Dec")
            {
                Previous_Year = d.AddYears(-1).ToString("yyyy");
            }
            PreviousDate = Previous_Year + "-" + prevMonth + "-" + "16";
            CurrentDate = Current_Year + "-" + currentMonth + "-" + "15";

            string heading = " 16 " + Previous_Month + " " + Previous_Year + " - 15 " + Current_Month + " " + Current_Year;
            ViewData["Heading"] = heading;
            DepartmentList dept = new DepartmentList();
            var deptList = model.DepartmentList();
            var empList = model.EmployeeList(0);
            var MonthlyList = model.MonthlyList();
            ViewData["MonthlyReportFilterList"] = new SelectList(await MonthlyList, "key", "value");
            ViewData["DepartmentsFilterList"] = new SelectList(deptList, "ID", "DeptName");
            ViewData["EmployeeFilterList"] = new SelectList(empList, "Id", "Emp_id");
            var EmployeDeatils = await model.employeesLeaveDetailsArea(0, 0, PreviousDate, CurrentDate);
            return View(EmployeDeatils);
        }

        public async Task<IActionResult> Download(int DeptID, int EmpID, string MnthSelected)
        {
            DateTime d = DateTime.Now;
            string Current_Month = string.Empty;
            string Previous_Month = string.Empty;
            string PreviousDate = string.Empty;
            string CurrentDate = string.Empty;
            string[] strArray = MnthSelected.Split('-');
            DateTime startDate = DateTime.Parse(strArray[0]);
            DateTime endDate = DateTime.Parse(strArray[1]);
            PreviousDate = startDate.Year + "-" + startDate.Month + "-" + startDate.Day;
            CurrentDate = endDate.Year + "-" + endDate.Month + "-" + endDate.Day;
            Previous_Month = startDate.ToString("MMM");
            Current_Month = endDate.ToString("MMM");
            string Previous_Year = startDate.Year.ToString();
            string Current_Year = endDate.Year.ToString();

            //if (d.Day >= 15)
            //{
            //    //Previous_Month = d.ToString("MMM");
            //    Previous_Month = d.AddMonths(-1).ToString("MMM");
            //    //Current_Month = d.AddMonths(1).ToString("MMM");
            //    Current_Month = d.AddMonths(0).ToString("MMM");
            //}
            //else
            //{
            //    Previous_Month = d.AddMonths(-2).ToString("MMM");
            //    //Previous_Month = d.AddMonths(-1).ToString("MMM");
            //    //Current_Month = d.ToString("MMM");
            //    Current_Month = d.AddMonths(-1).ToString("MMM");
            //}
            ////string Current_Month = d.ToString("MMM");

            ////string Previous_Month = d.AddMonths(-1).ToString("MMM");
            //string Current_Year = DateTime.Now.ToString("yyyy");
            //string Previous_Year = DateTime.Now.ToString("yyyy");
            //if (Previous_Month == "Dec")
            //{
            //    Previous_Year = d.AddYears(-1).ToString("yyyy");
            //}
            // var EmployeDeatils = await model.employeesLeaveDetailsArea(DeptID, EmpID);
            var EmployeDeatils = await model.employeesLeaveDetailsExportMonthlyLeaves(DeptID, EmpID, PreviousDate, CurrentDate);
            int empCount = EmployeDeatils.Count + 3;

            byte[] fileContents;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("LeaveReport");
                using (ExcelRange Rng = worksheet.Cells["A1:BB1"])
                {
                    //Rng.Value = "Monthly Leave Report For 15 " + Previous_Month + " - 16 " + Current_Month + " " + Current_Year;
                    //Rng.Merge = true;
                    ////Rng.Style.Font.Size = 16;
                    ////Rng.Style.Font.Bold = true;
                    ////Rng.Style.Font.Italic = true;
                    //Rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                using (ExcelRange Rng = worksheet.Cells["O1:BB1"])
                {
                    Rng.Merge = true;
                }

                using (ExcelRange Rng = worksheet.Cells[1, 14])
                {
                    Rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    Rng.Style.Border.Right.Color.SetColor(Color.White);
                }

                // 
                using (ExcelRange Rng = worksheet.Cells["A1:N1"])
                {
                    Rng.Value = "Monthly Leave Report For 16 " + Previous_Month + " " + Previous_Year + " - 15 " + Current_Month + " " + Current_Year;
                    Rng.Merge = true;
                    Rng.Style.Font.Size = 16;
                    Rng.Style.Font.Bold = true;
                    Rng.Style.Font.Italic = true;
                    Rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                //Headers Area
                worksheet.Cells[3, 1].Value = "Employee Id";
                worksheet.Cells[3, 2].Value = "Name";
                worksheet.Cells[3, 3].Value = "Department";
                worksheet.Cells[3, 4].Value = "Designation";
                worksheet.Cells[3, 5].Value = "Grade";
                worksheet.Cells[3, 6].Value = "Date Of Joining";
                worksheet.Cells[3, 7].Value = "Confirmation Date";
                worksheet.Cells[3, 8].Value = "Confirmation Status";
                worksheet.Cells[3, 9].Value = "D16";
                worksheet.Cells[3, 10].Value = "D17";
                worksheet.Cells[3, 11].Value = "D18";
                worksheet.Cells[3, 12].Value = "D19";
                worksheet.Cells[3, 13].Value = "D20";
                worksheet.Cells[3, 14].Value = "D21";
                worksheet.Cells[3, 15].Value = "D22";
                worksheet.Cells[3, 16].Value = "D23";
                worksheet.Cells[3, 17].Value = "D24";
                worksheet.Cells[3, 18].Value = "D25";
                worksheet.Cells[3, 19].Value = "D26";
                worksheet.Cells[3, 20].Value = "D27";
                worksheet.Cells[3, 21].Value = "D28";
                worksheet.Cells[3, 22].Value = "D29";
                worksheet.Cells[3, 23].Value = "D30";
                worksheet.Cells[3, 24].Value = "D31";
                worksheet.Cells[3, 25].Value = "D1";
                worksheet.Cells[3, 26].Value = "D2";
                worksheet.Cells[3, 27].Value = "D3";
                worksheet.Cells[3, 28].Value = "D4";
                worksheet.Cells[3, 29].Value = "D5";
                worksheet.Cells[3, 30].Value = "D6";
                worksheet.Cells[3, 31].Value = "D7";
                worksheet.Cells[3, 32].Value = "D8";
                worksheet.Cells[3, 33].Value = "D9";
                worksheet.Cells[3, 34].Value = "D10";
                worksheet.Cells[3, 35].Value = "D11";
                worksheet.Cells[3, 36].Value = "D12";
                worksheet.Cells[3, 37].Value = "D13";
                worksheet.Cells[3, 38].Value = "D14";
                worksheet.Cells[3, 39].Value = "D15";
                worksheet.Cells[3, 40].Value = "Leave Balance CL";
                worksheet.Cells[3, 41].Value = "Leave Balance SL";
                worksheet.Cells[3, 42].Value = "Leave Balance PL";
                worksheet.Cells[3, 43].Value = "Leave Balance TL";
                worksheet.Cells[3, 44].Value = "Leave Taken CL";
                worksheet.Cells[3, 45].Value = "Leave Taken SL";
                worksheet.Cells[3, 46].Value = "Leave Taken PL";
                worksheet.Cells[3, 47].Value = "Leave Taken TL";
                worksheet.Cells[3, 48].Value = "Leave Balance for Next Tenure CL";
                worksheet.Cells[3, 49].Value = "Leave Balance for Next Tenure SL";
                worksheet.Cells[3, 50].Value = "Leave Balance for Next Tenure PL";
                worksheet.Cells[3, 51].Value = "Leave Balance for Next Tenure TL";
                worksheet.Cells[3, 52].Value = "Leave Without Pay";
                worksheet.Cells[3, 53].Value = "Total Days";
                worksheet.Cells[3, 54].Value = "Payable Days";

                for (int j = 1; j <= 54; j++)
                {
                    worksheet.Cells[3, j].Style.Font.Bold = true;
                    worksheet.Cells[3, j].Style.Font.Size = 12;
                }
                //Headers Area END

                foreach (var emp in EmployeDeatils)
                {
                    int i = EmployeDeatils.IndexOf(emp);
                    //worksheet.Cells[i, 1].Value = i;

                    // DOJ section
                    string dateOfJoining = string.Empty;
                    if (emp.DOJ != null)
                    {
                        dateOfJoining = emp.DOJ.ToString("dd/MM/yyyy");
                    }
                    // ends of DOJ

                    //int i = EmployeDeatils.IndexOf(emp);
                    i = i + 4;
                    //worksheet.Cells[i, 1].Value = i;
                    worksheet.Cells[i, 1].Value = emp.EmpId;
                    worksheet.Cells[i, 2].Value = emp.Name;
                    worksheet.Cells[i, 3].Value = emp.Dept;
                    worksheet.Cells[i, 4].Value = emp.Designation;
                    worksheet.Cells[i, 5].Value = emp.Grade;
                    //worksheet.Cells[i, 6].Value = emp.DOJ;
                    worksheet.Cells[i, 6].Value = dateOfJoining;
                    worksheet.Cells[i, 7].Value = emp.ConfirmationDate;
                    worksheet.Cells[i, 8].Value = emp.ConfirmationStatus;
                    worksheet.Cells[i, 9].Value = emp.D16;
                    worksheet.Cells[i, 10].Value = emp.D17;
                    worksheet.Cells[i, 11].Value = emp.D18;
                    worksheet.Cells[i, 12].Value = emp.D19;
                    worksheet.Cells[i, 13].Value = emp.D20;
                    worksheet.Cells[i, 14].Value = emp.D21;
                    worksheet.Cells[i, 15].Value = emp.D22;
                    worksheet.Cells[i, 16].Value = emp.D23;
                    worksheet.Cells[i, 17].Value = emp.D24;
                    worksheet.Cells[i, 18].Value = emp.D25;
                    worksheet.Cells[i, 19].Value = emp.D26;
                    worksheet.Cells[i, 20].Value = emp.D27;
                    worksheet.Cells[i, 21].Value = emp.D28;
                    worksheet.Cells[i, 22].Value = emp.D29;
                    worksheet.Cells[i, 23].Value = emp.D30;
                    worksheet.Cells[i, 24].Value = emp.D31;
                    worksheet.Cells[i, 25].Value = emp.D1;
                    worksheet.Cells[i, 26].Value = emp.D2;
                    worksheet.Cells[i, 27].Value = emp.D3;
                    worksheet.Cells[i, 28].Value = emp.D4;
                    worksheet.Cells[i, 29].Value = emp.D5;
                    worksheet.Cells[i, 30].Value = emp.D6;
                    worksheet.Cells[i, 31].Value = emp.D7;
                    worksheet.Cells[i, 32].Value = emp.D8;
                    worksheet.Cells[i, 33].Value = emp.D9;
                    worksheet.Cells[i, 34].Value = emp.D10;
                    worksheet.Cells[i, 35].Value = emp.D11;
                    worksheet.Cells[i, 36].Value = emp.D12;
                    worksheet.Cells[i, 37].Value = emp.D13;
                    worksheet.Cells[i, 38].Value = emp.D14;
                    worksheet.Cells[i, 39].Value = emp.D15;
                    worksheet.Cells[i, 40].Value = emp.LeaveBalance_CL;
                    worksheet.Cells[i, 41].Value = emp.LeaveBalance_SL;
                    worksheet.Cells[i, 42].Value = emp.LeaveBalance_PL;
                    worksheet.Cells[i, 43].Value = emp.LeaveBalance_TL;
                    worksheet.Cells[i, 44].Value = emp.LeaveTaken_CL;
                    worksheet.Cells[i, 45].Value = emp.LeaveTaken_SL;
                    worksheet.Cells[i, 46].Value = emp.LeaveTaken_PL;
                    worksheet.Cells[i, 47].Value = emp.LeaveTaken_TL;
                    worksheet.Cells[i, 48].Value = emp.LeaveBalancefornexttenure_CL;
                    worksheet.Cells[i, 49].Value = emp.LeaveBalancefornexttenure_SL;
                    worksheet.Cells[i, 50].Value = emp.LeaveBalancefornexttenure_PL;
                    worksheet.Cells[i, 51].Value = emp.LeaveBalancefornexttenure_TL;
                    worksheet.Cells[i, 52].Value = emp.LWPLeave;
                    worksheet.Cells[i, 53].Value = emp.TotalDays;
                    worksheet.Cells[i, 54].Value = emp.PayableDays;
                }

                // setting the background color yellow where value is "L" from D16 to D15, created on 11-feb-2018
                for (int j = 4; j <= empCount; j++)
                {
                    for (int k = 9; k <= 39; k++)
                    {
                        if (worksheet.Cells[j, k].Value.ToString().Trim() == "L")
                        {
                            worksheet.Cells[j, k].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[j, k].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        }
                    }
                }
                // ends of yellow color

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                fileContents = package.GetAsByteArray();
            }

            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: "LeaveReport.xlsx"
            );
        }

        private static void CellFormatting(ExcelWorksheet worksheet, EmployeesLeaveDetails emp, int i)
        {
            worksheet.Cells[i, 3].Value = emp.Name;
            worksheet.Cells[i, 3].Style.Font.Size = 12;
            worksheet.Cells[i, 3].Style.Font.Bold = true;
            worksheet.Cells[i, 3].Style.Border.Top.Style = ExcelBorderStyle.Hair;
        }

        public async Task<IActionResult> EmployeDataTable(int DeptID, int EmpID, string MnthSelected)
        {
            string Previous_Month = string.Empty;
            string Current_Month = string.Empty;
            string PreviousDate = string.Empty;
            string CurrentDate = string.Empty;

            DateTime d = DateTime.Now; 
            if (MnthSelected == "" || MnthSelected == null)
            {
                if (d.Day > 15)
                {

                    //Previous_Month = d.ToString("MMM");
                    Previous_Month = d.AddMonths(-1).ToString("MM");
                    //Current_Month = d.AddMonths(1).ToString("MMM");
                    Current_Month = d.AddMonths(0).ToString("MM");
                }
                else
                {

                    Previous_Month = d.AddMonths(-2).ToString("MM");
                    //Previous_Month = d.AddMonths(-1).ToString("MMM");
                    //Current_Month = d.ToString("MMM");
                    Current_Month = d.AddMonths(-1).ToString("MM");
                }
                string Current_Year = DateTime.Now.ToString("yyyy");
                string Previous_Year = DateTime.Now.ToString("yyyy");
                if (Previous_Month == "Dec")
                {
                    Previous_Year = d.AddYears(-1).ToString("yyyy");
                }
                PreviousDate = Previous_Year + "-" + Previous_Month + "-" + "16";
                CurrentDate = Current_Year + "-" + Current_Month + "-" + "15";
            }
            else
            {
                string[] strArray = MnthSelected.Split('-');
                DateTime startDate = DateTime.Parse(strArray[0]);
                DateTime endDate = DateTime.Parse(strArray[1]);
                PreviousDate = startDate.Year + "-" + startDate.Month + "-" + startDate.Day;
                CurrentDate = endDate.Year + "-" + endDate.Month + "-" + endDate.Day;

            }

            var EmployeDeatils = await model.employeesLeaveDetailsArea(DeptID, EmpID, PreviousDate, CurrentDate);
            return PartialView("_DetailEmpReport", EmployeDeatils);
        }
        public async Task<IActionResult> DepartmentFilter(int DeptID)
        {
            var empList = await model.EmployeeListDet(DeptID);
            //var EmployeDeatils = await model.employeesLeaveDetailsArea(DeptID,0);
            return Json(new
            {
                EmpList = empList
                //employeDeatils = EmployeDeatils
            });
            //return Json(new { EmpList = empList, employeDeatils = EmployeDeatils },);
            //var 
        }
        public async Task<IActionResult> CustomDataTable(DateTime? StartDate, DateTime? EndDate, int? DeptID, int? EmpID)
        {
            try
            {
                var EmployeDeatils = await model.employeesCustomLeaveDetailsArea(StartDate, EndDate, DeptID, EmpID);
                return PartialView("_CustomReport", EmployeDeatils);
            }
            catch (Exception e) { return NotFound(); }

        }
        public async Task<IActionResult> DownloadCustomReport(DateTime? StartDate, DateTime? EndDate, int? DeptID, int? EmpID)
        {

            var EmployeDeatils = await model.employeesCustomLeaveDetailsArea(StartDate, EndDate, DeptID, EmpID);

            byte[] fileContents;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Custom Report");

                using (ExcelRange Rng = worksheet.Cells["A1:H1"])
                {
                    if (StartDate == null && EndDate == null)
                    {
                        Rng.Value = "Leave Report";
                    }
                    else
                    {
                        Rng.Value = "Leave Report From " + StartDate.Value.ToShortDateString() + " To " + EndDate.Value.ToShortDateString();
                    }

                    Rng.Merge = true;
                    Rng.Style.Font.Size = 16;
                    Rng.Style.Font.Bold = true;
                    Rng.Style.Font.Italic = true;
                    Rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }


                //Headers Area
                worksheet.Cells[3, 1].Value = "Employee Id";
                worksheet.Cells[3, 2].Value = "Name";
                worksheet.Cells[3, 3].Value = "Total Allocated Leaves";
                worksheet.Cells[3, 4].Value = "Total Leaves Taken";
                worksheet.Cells[3, 5].Value = "Casual Leaves Taken";
                worksheet.Cells[3, 6].Value = "Sick Leaves Taken";
                worksheet.Cells[3, 7].Value = "Earned Leaves Taken";
                worksheet.Cells[3, 8].Value = "Leave Without Pay Taken";

                for (int j = 1; j <= 8; j++)
                {
                    worksheet.Cells[3, j].Style.Font.Bold = true;
                    worksheet.Cells[3, j].Style.Font.Size = 12;
                }
                //Headers Area END

                foreach (var emp in EmployeDeatils)
                {
                    int i = EmployeDeatils.IndexOf(emp);
                    i = i + 4;
                    worksheet.Cells[i, 1].Value = emp.EmpId;
                    worksheet.Cells[i, 2].Value = emp.Name;
                    worksheet.Cells[i, 3].Value = emp.TotalAllocatedLeaves;
                    worksheet.Cells[i, 4].Value = emp.TotalLeavesTaken;
                    worksheet.Cells[i, 5].Value = emp.CasualLeavesTaken;
                    worksheet.Cells[i, 6].Value = emp.SickLeavesTaken;
                    worksheet.Cells[i, 7].Value = emp.PaidLeavesTaken;
                    worksheet.Cells[i, 8].Value = emp.LWPTaken;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                fileContents = package.GetAsByteArray();
            }

            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: "LeaveReport.xlsx"
            );
        }
    }
}