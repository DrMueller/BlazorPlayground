using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace BlazorPlayground.Areas.Bootstrap.LazyTabs.Shared;

public partial class LazyTab
{
    [Parameter] [EditorRequired] public required RenderFragment ChildContent { get; set; }

    [CascadingParameter] public required LazyTabs Parent { get; set; }

    internal Guid Guid { get; set; } = Guid.NewGuid();

    [Parameter]
    [EditorRequired]
    public required string Title { get; set; }

    protected override void OnInitialized()
    {
        Parent.AddTab(this);
    }
}