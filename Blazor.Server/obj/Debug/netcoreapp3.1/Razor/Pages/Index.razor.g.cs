#pragma checksum "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0986c47a60ae48f4b711ab0a3893518c1db9eee9"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Blazor.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\_Imports.razor"
using Blazor.Server.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
                  TriggerAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Trigger Alert");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
 
    public string Name { get; set; } = "World";
    public async Task TriggerAlert()
    {
        await JSRuntime.InvokeVoidAsync("myApp.triggerAlert",Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
