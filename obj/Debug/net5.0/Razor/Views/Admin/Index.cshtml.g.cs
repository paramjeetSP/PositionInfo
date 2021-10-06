#pragma checksum "D:\ResourceInfo\PositionInfo\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3343d45ff85c2f081f6d597fd619bfa352555554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ResourceInfo\PositionInfo\Views\_ViewImports.cshtml"
using PositionInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ResourceInfo\PositionInfo\Views\_ViewImports.cshtml"
using PositionInfo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3343d45ff85c2f081f6d597fd619bfa352555554", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07171f48f5a04807106fd3f9c0a4f960584bc4c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PositionInfo.Models.SpModels.DepartmentList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("dept-list"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control Deptlists input-group-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("ColumnChart3D3DropDown(this.value)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\ResourceInfo\PositionInfo\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    ");
            WriteLiteral(@"@import 'https://code.highcharts.com/css/highcharts.css';

    #container {
        height: 400px;
        max-width: 800px;
        min-width: 320px;
        margin: 0 auto;
    }

    .highcharts-pie-series .highcharts-point {
        stroke: #EDE;
        stroke-width: 2px;
    }

    .highcharts-pie-series .highcharts-data-label-connector {
        stroke: silver;
        stroke-dasharray: 2, 2;
        stroke-width: 2px;
    }

    .Deptlists {
        padding: 0px 9px !important;
    }


    .timelog--parent main[role=""main-wrapper""] .mid--box [class*=""col""] .form-control {
        margin: 0 auto !important;
        max-width: 484px !important;
        width: 100% !important;
    }

    .dot {
        height: 8px;
        width: 8px;
        background-color: #007bff;
        border-radius: 50%;
        display: inline-block;
    }

    .monthYear {
        font-style: oblique;
        font-weight: 800;
    }
</style>

<main id=""admin-dashboard"" role=""main-wr");
            WriteLiteral(@"apper"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-12 parent"">
                <div class=""mid--box row justify-content-center"">
                    <div class=""col-sm-6"">
                        <div class=""d--box"">
                            <div id=""container"" style=""min-width: 310px; height: 400px; max-width: 600px; margin: 0 auto""></div>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""d--box"">
                            <div id=""ColumnChart3Dcontainer"" style=""min-width: 310px; height: 400px; max-width: 600px; margin: 0 auto""></div>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""d--box"">
                            <div class=""form-group"">
                                <label class=""control-label""></label>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3343d45ff85c2f081f6d597fd619bfa3525555546507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 74 "D:\ResourceInfo\PositionInfo\Views\Admin\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 74 "D:\ResourceInfo\PositionInfo\Views\Admin\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.DepartmentsList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div id=""containerWithDrpDown1"" style=""min-width: 310px; height: 400px; max-width: 600px; margin: 0 auto"">

                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""d--box"">
                            <div id=""container2"" style=""min-width: 310px; height: 400px; max-width: 600px; margin: 0 auto""></div>
                        </div>
                    </div>
                    <div class=""monthYear"">
                        <div id=""Month""></div>
                        <div id=""Year""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>




<script src=""https://code.highcharts.com/highcharts.js""></script>
<script src=""https://code.highcharts.com/highcharts-3d.js""></script>
<script src=""https://code.highcharts.com/modules/exporting.js""></script>
<sc");
            WriteLiteral(@"ript src=""https://code.highcharts.com/modules/export-data.js""></script>
<script src=""https://code.jquery.com/jquery-3.1.1.min.js""></script>
<script src=""https://code.highcharts.com/highcharts-more.js""></script>

<script>
    $(document).ready(function () {
        $('#Admin_Dashboard').addClass('active');
        //        PieChart();
        ColumnChart3D();
        PieChart1();

        ColumnChart3D2();
        ColumnChart3D3();

        var DeptID = $("".Deptlists"").val();
        ColumnChart3D3DropDown(DeptID);
        CalculateCurrentMonthYear();
    });
    function PieChart() {
        $.ajax(
            {
                type: 'GET',
                dataType: 'JSON',
                url: '/Admin/Top5Leave',
                success:
                    function (response) {
                        console.log(response);

                        Highcharts.chart('container', {
                            chart: {
                                plotBackgroundColor: null,
");
            WriteLiteral(@"                                plotBorderWidth: null,
                                plotShadow: false,
                                type: 'pie'
                            },
                            title: {
                                text: 'Top 5 employees with Leaves Taken for Current Month'
                            },
                            tooltip: {
                                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                            },
                            plotOptions: {
                                pie: {
                                    allowPointSelect: true,
                                    cursor: 'pointer',
                                    dataLabels: {
                                        enabled: true,
                                        format: '<b>{point.name}</b>: {point.y:.1f} ',
                                        style: {
                                            color: (Highcharts.t");
            WriteLiteral(@"heme && Highcharts.theme.contrastTextColor) || 'black',
                                            width:'10px'
                                        }
                                    }
                                }
                            },
                            series: [{
                                name: 'Leaves Taken',
                                colorByPoint: true,
                                data: response
                            }]
                        });
                        //Highcharts.chart('container', {
                        //    chart: {
                        //        type: 'pie',
                        //        options3d: {
                        //            enabled: true,
                        //            alpha: 45,
                        //            beta: 0
                        //        }
                        //    },
                        //    title: {
                        //        text: 'Top 5");
            WriteLiteral(@" employees with Leaves'
                        //    },
                        //    tooltip: {
                        //        pointFormat: '{series.name}: <b>{point.y:.1f}%</b>'
                        //    },
                        //    plotOptions: {
                        //        pie: {
                        //            allowPointSelect: true,
                        //            cursor: 'pointer',
                        //            depth: 35,
                        //            dataLabels: {
                        //                enabled: true,
                        //                format: '{point.name}'
                        //            }
                        //        }
                        //    },
                        //    series: [{
                        //        type: 'pie',
                        //        name: 'Leaves',
                        //        data: response
                        //    }]
                         //te");
            WriteLiteral(@"st
                        //});

                    }
            });
    }
    function ColumnChart3D() {
        $.ajax(
            {
                type: 'GET',
                dataType: 'JSON',
                url: '/Admin/Top5Leave',
                success:
                    function (response) {
                        console.log(response);
                        var emp = [];
                        for (var prop in response) {
                            var item = response[prop];
                            emp.push(item.name);
                        }
                        var emp1 = [];
                        for (var prop in response) {
                            var item = response[prop];
                            emp1.push(item.y);
                        }

                        Highcharts.chart('Container1', {
                            chart: {
                                type: 'column',
                                options3d: {
        ");
            WriteLiteral(@"                            enabled: true,
                                    alpha: 10,
                                    beta: 25,
                                    depth: 70
                                }
                            },
                            title: {
                                text: 'Top 5 employees with Leaves'
                            },
                            subtitle: {
                                text: ''
                            },
                            plotOptions: {
                                column: {
                                    depth: 25
                                }
                            },
                            xAxis: {
                                categories: emp,
                                labels: {
                                    skew3d: true,
                                    style: {
                                        fontSize: '16px'
                              ");
            WriteLiteral(@"      }
                                }
                            },
                            yAxis: {
                                title: {
                                    text: null
                                }
                            },
                            series: [{
                                name: 'Leaves',
                                data: emp1
                            }]
                        });

                    }
            });

    }
    function PieChart1() {
        $.ajax(
            {
                type: 'GET',
                dataType: 'JSON',
                url: '/Admin/Top5Leave',
                success:
                    function (response) {
                        console.log(response);

                        Highcharts.chart('container', {

                            chart: {
                                styledMode: true
                            },

                            title: {
   ");
            WriteLiteral(@"                             text: 'Top 5 employees with Leaves Taken for Current Month'
                            },
                            plotOptions: {
                                pie: {
                                    dataLabels: {
                                        style: {
                                            width: '10000px'
                                        }
                                    }
                                }
                            },

                            xAxis: {
                                categories: response.name
                            },

                            series: [{
                                name: 'Leaves Taken',
                                type: 'pie',
                                allowPointSelect: true,
                                keys: ['name', 'y', 'selected', 'sliced'],
                                data: response,
                                size: 200,
      ");
            WriteLiteral(@"                          showInLegend: true
                            }]
                        });



                    }
            });
    }

    function ColumnChart3D2() {
        $.ajax(
            {
                type: 'GET',
                dataType: 'JSON',
                url: '/Admin/TopLeaveByDept',
                success:
                    function (response) {
                        console.log(response);
                        var emp = [];
                        for (var prop in response) {
                            var item = response[prop];
                            emp.push(item.name);
                        }
                        console.log('emp ', emp);
                        var emp1 = [];
                        for (var prop in response) {
                            var item = response[prop];
                            emp1.push(item.y);
                        }



                        var chart = Highcharts.chart('Column");
            WriteLiteral(@"Chart3Dcontainer', {

                            title: {
                                text: 'Top Employees with Leaves Taken for the Current Year'
                            },

                            subtitle: {
                                text: 'Department wise top emplyoees with leaves taken'
                            },

                            xAxis: {
                                categories: emp //['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
                            },

                            series: [{
                                name: 'Leaves',
                                type: 'column',
                                colorByPoint: true,
                                data: emp1,
                                showInLegend: false
                            }]

                        });







                    }
            });

    }


    function ColumnChart3D3() {
        $.");
            WriteLiteral(@"ajax(
            {
                type: 'GET',
                dataType: 'JSON',
                url: '/Admin/TopLeaveDept',
                success:
                    function (response) {

                        console.log(response);
                        var emp = [];
                        for (var prop in response) {
                            var item = response[prop];
                            var data1 = {
                                ""name"": item.name,
                                ""y"": item.y,
                                ""drilldown"": item.name
                            }
                            emp.push(item.name);
                            // emp.push(data1);
                        }
                        console.log('emp ', emp);
                        var emp1 = [];
                        for (var prop in response) {
                            var item = response[prop];
                            emp1.push(item.y);
                     ");
            WriteLiteral(@"   }



                        var chart = Highcharts.chart('container2', {
                            chart: {
                                type: 'pie',
                                options3d: {
                                    enabled: true,
                                    alpha: 45
                                }
                            },
                            title: {
                                text: 'Department Wise Leave Status for Current Month'
                            },
                            subtitle: {
                                // text: '3D donut in Highcharts'
                            },
                            plotOptions: {
                                pie: {
                                    innerSize: 100,
                                    depth: 45
                                }
                            },
                            series: [{
                                name: 'Leaves',
        ");
            WriteLiteral(@"                        data: response,
                            }]
                        });

                    }
            });

    }

    function ColumnChart3D3DropDown(DepId) {

        let url = '/Admin/Top5EmployeeByDepartment' + '?DepId=' + DepId;
        $.ajax(
            {
                type: 'GET',
                dataType: 'JSON',
                url: url,
                data: DepId,
                success:
                    function (response) {
                        console.log(response);
                        if (response.length == 0) {
                            $('#containerWithDrpDown1').empty();
                            $('#containerWithDrpDown1').append('<h6>No Record found</h6>');
                            return;
                        }
                        var emp = [];
                        for (var prop in response) {
                            var item = response[prop];
                            var data1 = {
        ");
            WriteLiteral(@"                        ""name"": item.name,
                                ""y"": item.y,
                                ""drilldown"": item.name
                            }
                            emp.push(item.name);
                            // emp.push(data1);
                        }
                        console.log('emp ', emp);
                        var emp1 = [];
                        for (var prop in response) {
                            var item = response[prop];
                            emp1.push(item.y);
                        }



                        var chart = Highcharts.chart('containerWithDrpDown1', {

                            title: {
                                text: 'Top 5 Employees per Department Leaves Taken For Current Year'
                            },
                            chart: {
                                inverted: true,
                                polar: false
                            },
                   ");
            WriteLiteral(@"         subtitle: {
                                // text: 'Plain'
                            },

                            xAxis: {
                                categories: emp
                            },

                            series: [{
                                name: 'Leaves',
                                type: 'column',
                                colorByPoint: true,
                                data: emp1,

                                showInLegend: false
                            }]

                        });


                        $('#plain').click(function () {
                            chart.update({
                                chart: {
                                    inverted: false,
                                    polar: false
                                },
                                subtitle: {
                                    text: 'Plain'
                                }
                         ");
            WriteLiteral(@"   });
                        });

                        $('#inverted').click(function () {
                            chart.update({
                                chart: {
                                    inverted: true,
                                    polar: false
                                },
                                subtitle: {
                                    text: 'Inverted'
                                }
                            });
                        });

                        $('#polar').click(function () {
                            chart.update({
                                chart: {
                                    inverted: false,
                                    polar: true
                                },
                                subtitle: {
                                    text: 'Polar'
                                }
                            });
                        });




                   ");
            WriteLiteral(@" }
            });

    }

    function CalculateCurrentMonthYear() {

        var month = new Array();
        month[0] = ""Jan"";
        month[1] = ""Feb"";
        month[2] = ""Mar"";
        month[3] = ""Apr"";
        month[4] = ""May"";
        month[5] = ""Jun"";
        month[6] = ""Jul"";
        month[7] = ""Aug"";
        month[8] = ""Sep"";
        month[9] = ""Oct"";
        month[10] = ""Nov"";
        month[11] = ""Dec"";

        var d = new Date();
        var Current_Year = d.getFullYear();
        var Pervious_Year = d.getFullYear();
        var FromMonth = """";
        var ToMonth = """";
        if (d.getDay() >= 15) {
            FromMonth = month[d.getMonth()];
            ToMonth = month[d.getMonth() + 1];
        }
        else {
            FromMonth = month[d.getMonth() - 1];
            ToMonth = month[d.getMonth()];
        }
        if (FromMonth == ""Dec"") {
            Pervious_Year = d.getFullYear() - 1;
        }
        var FromYear = d.getFullYear() - 1;
        ");
            WriteLiteral(@"var ToYear = d.getFullYear();
        if (d.getMonth() == 3 && d.getDate() >= 16) {
            FromYear = d.getFullYear();
            ToYear = d.getFullYear() + 1;
        }
        if (d.getMonth() > 3) {
            FromYear = d.getFullYear();
            ToYear = d.getFullYear() + 1;
        }

        $(""#Month"").append('<span class=""dot""></span> Current Month is from 16 ' + FromMonth + ' ' + Pervious_Year +' to 15 ' + ToMonth + ' ' + Current_Year);
        $(""#Year"").append('<span class=""dot""></span> Current Year is from 16 Apr ' + FromYear + ' to 15 Apr ' + ToYear);
    }


</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PositionInfo.Models.SpModels.DepartmentList> Html { get; private set; }
    }
}
#pragma warning restore 1591
