using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace ODataBlazor.Server.Components
{
    public class Placeholder : ComponentBase
    {
        public Action<RenderTreeBuilder> OnBuildRenderTree { get; set; }
        public new void StateHasChanged()
            => base.StateHasChanged();

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            OnBuildRenderTree?.Invoke(builder);
        }

        async public Task ShowAsync()
        {
            OnBuildRenderTree = (builder) =>
            {
                builder.OpenComponent<ModalBootstrapTest>(0);
                builder.CloseComponent();
            };
            StateHasChanged();
            await Task.Delay(TimeSpan.FromSeconds(1));
            OnBuildRenderTree = null;
            StateHasChanged();
        }
    }

    public static class PlaceholderExtensions
    {
        async static public Task ShowAsync(this Placeholder thisValue)
        {
            thisValue.OnBuildRenderTree = (builder) =>
            {
                builder.OpenComponent<ModalBootstrapTest>(0);
                builder.CloseComponent();
            };
            thisValue.StateHasChanged();
            await Task.Delay(TimeSpan.FromSeconds(1));
            thisValue.OnBuildRenderTree = null;
            thisValue.StateHasChanged();
        }
    }
}
