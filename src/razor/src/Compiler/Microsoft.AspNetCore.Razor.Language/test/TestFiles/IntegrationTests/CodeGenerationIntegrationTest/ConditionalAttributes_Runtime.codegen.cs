﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06e553c9dddd22392e81b4db3d16d097612b3552ffeaa58d015a2e3dedcf6c3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ConditionalAttributes_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"06e553c9dddd22392e81b4db3d16d097612b3552ffeaa58d015a2e3dedcf6c3a", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ConditionalAttributes_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line (1,3)-(4,1) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"

    var ch = true;
    var cls = "bar";

#line default
#line hidden
#nullable disable

            WriteLiteral("    <a href=\"Foo\" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 74, "\"", 86, 1);
            WriteAttributeValue("", 82, 
#nullable restore
#line (5,16)-(5,19) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
cls

#line default
#line hidden
#nullable disable
            , 82, 4, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 98, "\"", 114, 2);
            WriteAttributeValue("", 106, "foo", 106, 3, true);
            WriteAttributeValue(" ", 109, 
#nullable restore
#line (6,20)-(6,23) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
cls

#line default
#line hidden
#nullable disable
            , 110, 4, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 126, "\"", 142, 2);
            WriteAttributeValue("", 134, 
#nullable restore
#line (7,16)-(7,19) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
cls

#line default
#line hidden
#nullable disable
            , 134, 4, false);
            WriteAttributeValue(" ", 138, "foo", 139, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 174, "\"", 187, 1);
            WriteAttributeValue("", 184, 
#nullable restore
#line (8,38)-(8,40) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
ch

#line default
#line hidden
#nullable disable
            , 184, 3, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 219, "\"", 236, 2);
            WriteAttributeValue("", 229, "foo", 229, 3, true);
            WriteAttributeValue(" ", 232, 
#nullable restore
#line (9,42)-(9,44) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
ch

#line default
#line hidden
#nullable disable
            , 233, 3, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 248, "\"", 281, 1);
            WriteAttributeValue("", 256, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line (10,16)-(10,34) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
if(cls != null) { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (10,35)-(10,38) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
cls

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (10,38)-(10,40) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
 }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 256, 25, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <a href=\"~/Foo\" />\r\n    <script");
            BeginWriteAttribute("src", " src=\"", 322, "\"", 373, 1);
            WriteAttributeValue("", 328, 
#nullable restore
#line (12,19)-(12,63) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
Url.Content("~/Scripts/jquery-1.6.2.min.js")

#line default
#line hidden
#nullable disable
            , 328, 45, false);
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
            BeginWriteAttribute("src", " src=\"", 420, "\"", 487, 1);
            WriteAttributeValue("", 426, 
#nullable restore
#line (13,19)-(13,79) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
Url.Content("~/Scripts/modernizr-2.0.6-development-only.js")

#line default
#line hidden
#nullable disable
            , 426, 61, false);
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script src=\"http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.min.js\" type=\"text/javascript\"></script>\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
