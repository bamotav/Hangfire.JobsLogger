﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.JobsLogger.Dashboard.Pages.Html
{
    
    #line 2 "..\..\Dashboard\Pages\Html\Logging.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Dashboard\Pages\Html\Logging.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\Html\Logging.cshtml"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\Html\Logging.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\Html\Logging.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\Html\Logging.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Logging : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");









            
            #line 9 "..\..\Dashboard\Pages\Html\Logging.cshtml"
  
    Layout = new LayoutPage("Logging");

    int.TryParse(Query("from"), out var from);
    int.TryParse(Query("count"), out var perPage);



            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 20 "..\..\Dashboard\Pages\Html\Logging.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">Logs 0<" +
"/h1>\r\n        <div class=\"tags\">\r\n            There are no Logs found yet.\r\n    " +
"    </div>\r\n    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591