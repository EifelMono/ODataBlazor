using System;
using System.Diagnostics;
using ODataBlazor.Server.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace ODataBlazor.Server.Components
{
    public class ComponentCore : ComponentBase
    {
        public new void StateHasChanged()
            => base.StateHasChanged();
    }
}
