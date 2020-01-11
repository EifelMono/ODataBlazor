using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ODataBlazor.Server.Extensions
{
    public static class ComponentBaseExtensions
    {

        public static async Task<bool> ShowModalAsync(this ComponentBase thisValue)
        {
            await Task.Delay(1);
            return false;
        }
    }
}
