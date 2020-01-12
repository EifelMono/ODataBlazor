using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ODataBlazor.Server.Components;

namespace ODataBlazor.Server.Extensions
{
    public static class ComponentCoreExtensions
    {
        public static async Task<bool> ShowModalAsync(this ComponentCore thisValue, string title, string text)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            thisValue.StateHasChanged();
            return false;
        }
    }
}
