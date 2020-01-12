using System;
using Microsoft.AspNetCore.Components;

namespace ODataBlazor.Server.Components
{
    public class ComponentCore : ComponentBase
    {
        public ComponentCore() : base()
        {
        }

        public new void StateHasChanged()
            => base.StateHasChanged();
    }
}
