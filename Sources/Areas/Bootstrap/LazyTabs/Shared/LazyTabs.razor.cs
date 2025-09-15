using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace BlazorPlayground.Areas.Bootstrap.LazyTabs.Shared;

public partial class LazyTabs
{
    private IList<LazyTab> LazyTabsList { get; } = new List<LazyTab>();
    private LoadedTabs LoadedTabs { get; } = new();

    [Parameter] public required RenderFragment ChildContent { get; set; }

    public void AddTab(LazyTab tab)
    {
        LazyTabsList.Add(tab);
        LoadedTabs.Add(new LoadedTab(tab.Guid));

        StateHasChanged();
    }

    private void HandleShowing(TabsEventArgs obj)
    {
        var tab = LazyTabsList.Single(f => f.Title == obj.ActiveTabTitle);
        LoadedTabs.SetWasLoaded(tab.Guid);
    }
}