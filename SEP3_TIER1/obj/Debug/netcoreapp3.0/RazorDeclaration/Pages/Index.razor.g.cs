#pragma checksum "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040994d78a6b79df488b4c8d0dc208fa29a2c862"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP3_TIER1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using SEP3_TIER1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using SEP3_TIER1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\Index.razor"
using SEP3_TIER1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\Index.razor"
      
    private List<PlaneDTO> datas = new List<PlaneDTO>();
    private PlaneDTO ItemToBeDeleted;
    protected override async Task OnInitializedAsync()
    {
        datas = await Http.GetJsonAsync<List<PlaneDTO>>("https://localhost:44397/planes");
    }

    async void DeleteItem(string Flight)
    {
        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirmDelete");
        if (isConfirmed)
        {
            try
            {
                foreach (var data in datas)
                {
                    if (data.CallSign == Flight)
                    {
                         await Http.DeleteAsync("https://localhost:44397/planes/"+data.CallSign);
                        await JsRuntime.InvokeVoidAsync("refresh");
                    }
                }

            }
            catch (Exception e)
            {

            }
            
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
