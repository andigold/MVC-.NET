#pragma checksum "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6375081a5a8408ebfc2c3176b9a94f20d5e5a778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HomePage.cshtml", typeof(AspNetCore.Views_Home_HomePage))]
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
#line 1 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\_ViewImports.cshtml"
using UserRestaurnats3;

#line default
#line hidden
#line 1 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
using UserRestaurnats3.Models;

#line default
#line hidden
#line 2 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
using UserRestaurnats3.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6375081a5a8408ebfc2c3176b9a94f20d5e5a778", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"739fd2d0d228700359a428dee6e7d0819bff750a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllRestaurantsAndFoods>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/EditRestaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
  
    ViewData["Title"] = "HomePage";

#line default
#line hidden
            BeginContext(141, 23, true);
            WriteLiteral("\r\n<h2>HomePage</h2>\r\n\r\n");
            EndContext();
            BeginContext(164, 2167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fce5214228c14b8b92b9820984e711d3", async() => {
                BeginContext(170, 214, true);
                WriteLiteral("\r\n    <div class=\"navbar navbar-inverse navbar-fixed-top\">\r\n        <div class=\"container\">\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li>");
                EndContext();
                BeginContext(385, 48, false);
#line 15 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(Html.ActionLink("Sign In", "CreateUser", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(433, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(465, 42, false);
#line 16 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(Html.ActionLink("Log In", "Login", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(507, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(539, 61, false);
#line 17 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(Html.ActionLink("Add Restaurant", "CreateRestaurant", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(600, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(632, 49, false);
#line 18 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(Html.ActionLink("Add Food", "CreateFood", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(681, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(713, 63, false);
#line 19 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(Html.ActionLink("My Restaurants", "AllUserRestaurants", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(776, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(807, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19286639d48469fb00b6f46ad0e9823", async() => {
                    BeginContext(837, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(845, 124, true);
                WriteLiteral("<br /></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <table class=\"table\" border=\"1\">\r\n");
                EndContext();
#line 27 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
         foreach (RestaurantAndFoodsDto raf in Model.RestaurantAndFoods)
        {

#line default
#line hidden
                BeginContext(1054, 80, true);
                WriteLiteral("        <tr>\r\n            <th>\r\n                <text>Име на ресторанта: </text>");
                EndContext();
                BeginContext(1135, 19, false);
#line 31 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                                           Write(raf.Restaurant.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1154, 38, true);
                WriteLiteral("\r\n                <text>Адрес: </text>");
                EndContext();
                BeginContext(1193, 22, false);
#line 32 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                               Write(raf.Restaurant.Address);

#line default
#line hidden
                EndContext();
                BeginContext(1215, 46, true);
                WriteLiteral("\r\n                <text>Работно време: </text>");
                EndContext();
                BeginContext(1262, 23, false);
#line 33 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                                       Write(raf.Restaurant.Worktime);

#line default
#line hidden
                EndContext();
                BeginContext(1285, 343, true);
                WriteLiteral(@"
                <br />
                <table class=""table"" border=""1"">
                    <tr>
                        <th width=""60%"">Ястие</th>
                        <th width=""15%"">Грамаж</th>
                        <th width=""15%"">Калоричност</th>
                        <th width=""10%"">Цена</th>
                    </tr>
");
                EndContext();
#line 42 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                     foreach (Food food in raf.Foods)
                    {

#line default
#line hidden
                BeginContext(1706, 84, true);
                WriteLiteral("                <tr>\r\n                    <th width=\"60%\">\r\n                        ");
                EndContext();
                BeginContext(1791, 9, false);
#line 46 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(food.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1800, 91, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th width=\"15%\">\r\n                        ");
                EndContext();
                BeginContext(1892, 11, false);
#line 49 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(food.Weight);

#line default
#line hidden
                EndContext();
                BeginContext(1903, 91, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th width=\"15%\">\r\n                        ");
                EndContext();
                BeginContext(1995, 13, false);
#line 52 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(food.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(2008, 91, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th width=\"10%\">\r\n                        ");
                EndContext();
                BeginContext(2100, 52, false);
#line 55 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                   Write(Convert.ToDouble(Convert.ToDouble(food.Price) / 100));

#line default
#line hidden
                EndContext();
                BeginContext(2152, 52, true);
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
                EndContext();
#line 58 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
                      }

#line default
#line hidden
                BeginContext(2229, 64, true);
                WriteLiteral("                    </table>\r\n            </th>\r\n        </tr>\r\n");
                EndContext();
#line 62 "D:\Hausaufgabe\Semester_2\ВТУ\ASPNET\UserRestaurnats3\UserRestaurnats3\Views\Home\HomePage.cshtml"
        }

#line default
#line hidden
                BeginContext(2304, 20, true);
                WriteLiteral("    </table>\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2331, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllRestaurantsAndFoods> Html { get; private set; }
    }
}
#pragma warning restore 1591
