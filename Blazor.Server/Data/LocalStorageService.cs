using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class LocalStorageService
    {
        private IJSRuntime JSRuntime { get; set; }
        
        //create a constructor as aparamter to service
        public LocalStorageService(IJSRuntime jsRuntime )
        {
            JSRuntime = jsRuntime;

        }
        
        public async Task SetItemAsync(string key, string value)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", key, value);

        }
        public async Task<String> GetItemAsync(string key)
        {
            var result=await JSRuntime.InvokeAsync<string>("localStorage.setItem", key);
            return result;
        }

    }
}
