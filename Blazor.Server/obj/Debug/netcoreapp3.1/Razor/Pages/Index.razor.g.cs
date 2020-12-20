#pragma checksum "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c0c37056b312206a8b96802a9bcf0d4ea43d8f"
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
#nullable restore
#line 4 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
using Blazor.Server.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Hello ,");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "id", "myName");
            __builder.AddContent(4, 
#nullable restore
#line 15 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
                              Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
                  TriggerAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Trigger Alert");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
                  ShowPrompt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Trigger Alert");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\harsh\Documents\GitHub\BlazorJsInterop\Blazor.Server\Pages\Index.razor"
 
    public string Name { get; set; } = "World";
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        //on first render this will be set to True 
        //on subsequent render this will be set to False
        if (firstRender)
        {
            var savedValue = await LocalStorage.GetItemAsync("name");
            if (!string.IsNullOrEmpty(savedValue))
            {
                Name = savedValue;
                await JSRuntime.InvokeVoidAsync("myApp.setName", Name);
            }

        }

    }


    public async Task TriggerAlert()
    {
        var forecast = await WeatherService.GetForecastAsync(DateTime.Now);
        await JSRuntime.InvokeVoidAsync("myApp.triggerAlert",forecast[0]);
    }


    public async Task ShowPrompt()
    {
        var result = await JSRuntime.InvokeAsync<string>("myApp.showprompt", "Your name....");
        if (!string.IsNullOrEmpty(result))
        {
            Name = result;
            await LocalStorage.SetItemAsync("name", result);
        }
        
    }

    // to make this method exposed to javascript 
    [JSInvokable]
    public static string Greet(string name)
    {
        return "Hello " + name;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService WeatherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
