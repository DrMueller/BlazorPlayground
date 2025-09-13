using Microsoft.AspNetCore.Components;

namespace BlazorPlayground.Areas.Bootstrap.LazyTabs.Shared;

public partial class LazyTabs
{
    private IList<LazyTab> LazyTabsList { get; } = new List<LazyTab>();

    [Parameter] public required RenderFragment ChildContent { get; set; }

    public void AddTab(LazyTab tab)
    {
        LazyTabsList.Add(tab);

        StateHasChanged();
    }
}