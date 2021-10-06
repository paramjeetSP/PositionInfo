#pragma checksum "D:\ResourceInfo\PositionInfo\Views\Admin\_EditEmpLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d11d8844d75f79ea31775c0f7ca9406031c84be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__EditEmpLeave), @"mvc.1.0.view", @"/Views/Admin/_EditEmpLeave.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d11d8844d75f79ea31775c0f7ca9406031c84be", @"/Views/Admin/_EditEmpLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07171f48f5a04807106fd3f9c0a4f960584bc4c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__EditEmpLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PositionInfo.Models.SpModels.GetEmployeeLeavesStatus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal-dialog"">
    <!-- Modal content-->
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            <h4 class=""modal-title"">Edit Leave</h4>
        </div>
        <input type=""hidden"" id=""LeaveRowID"" name=""custId""");
            BeginWriteAttribute("value", " value=\"", 401, "\"", 421, 1);
#nullable restore
#line 10 "D:\ResourceInfo\PositionInfo\Views\Admin\_EditEmpLeave.cshtml"
WriteAttributeValue("", 409, Model.RowID, 409, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"modal-body\">\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"d--box\">\r\n                    <label>Start Date</label>\r\n                   \r\n                    ");
#nullable restore
#line 16 "D:\ResourceInfo\PositionInfo\Views\Admin\_EditEmpLeave.cshtml"
               Write(Html.TextBoxFor(m => m.LeaveStartDate, null, new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>     \r\n                </div>\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"d--box\">\r\n                    <label>End Date</label>\r\n");
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "D:\ResourceInfo\PositionInfo\Views\Admin\_EditEmpLeave.cshtml"
               Write(Html.TextBoxFor(m => m.LeaveEndDate, null, new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-12\">\r\n");
            WriteLiteral(@"            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" onclick=""SaveEditData()"" data-dismiss=""modal"">Save</button>
                <button type=""button"" class=""btn btn-default""  data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<script>
    //$(function () {
    //    $(""#LeaveStartDate"").click(function () {
          
    //        $(this).datepicker().datepicker(""show"")
    //            var selected = $(this).val();
    //            alert(selected);
            
    //    });
    //});
    $(function () {
        $(""#LeaveStartDate"").datepicker({
            dateFormat: ""dd-mm-yy"",
            onSelect: function () {
                var selected = $(this).val();
               
                $('#LeaveStartDate').attr('value', selected)
                //alert($('#LeaveStartDate').val());
            }
        });
    });

    $(function () {
        $(""#LeaveEndDate"").dat");
            WriteLiteral(@"epicker({
            dateFormat: ""dd-mm-yy"",
            onSelect: function () {
                var selected = $(this).val();
            
                $('#LeaveEndDate').attr('value', selected)
               // alert($('#LeaveEndDate').val());
            }
        });
    });

    function SaveEditData() {
       
        var model = {
            LeaveStartDate: $('#LeaveStartDate').attr('value'),
            LeaveEndDate: $('#LeaveEndDate').attr('value'),
            LeaveID: $('#LeaveRowID').val(),
        };
      
        $.ajax({
            type: 'POST',
            url: '");
#nullable restore
#line 83 "D:\ResourceInfo\PositionInfo\Views\Admin\_EditEmpLeave.cshtml"
             Write(Url.Action("SaveLeaveChangesBasedOnLeaveID", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { updateLeaveData: model },
          //  contentType: ""application/json; charset=utf-8"",
            success: function (response) {           
                    location.reload(); 
                         
            },
            error: function (response) {
                //alert('some error has occured !!');
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PositionInfo.Models.SpModels.GetEmployeeLeavesStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591
