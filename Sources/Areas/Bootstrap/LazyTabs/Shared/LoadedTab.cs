namespace BlazorPlayground.Areas.Bootstrap.LazyTabs.Shared;

internal class LoadedTabs
{
    private readonly IList<LoadedTab> _entries;

    public LoadedTabs()
    {
        _entries = new List<LoadedTab>();
    }

    public LoadedTab this[Guid guid] => _entries.Single(f => f.TabGuid == guid);

    public void Add(LoadedTab entry)
    {
        _entries.Add(entry);
    }

    internal void SetWasLoaded(Guid tabGuid)
    {
        var item = _entries.Single(f => f.TabGuid == tabGuid);
        item.SetWasLoaded();
        var otherItems = _entries.Except([item]);

        foreach (var otherItem in otherItems) otherItem.SetInactive();
    }
}

internal class LoadedTab
{
    public LoadedTab(Guid tabGuid)
    {
        TabGuid = tabGuid;
        WasLoaded = false;
    }

    public Guid TabGuid { get; }

    public string ActiveCssClass => IsActive ? "block" : "none";

    private bool IsActive { get; set; }

    public bool WasLoaded { get; private set; }

    internal void SetWasLoaded()
    {
        WasLoaded = true;
        IsActive = true;
    }

    internal void SetInactive()
    {
        IsActive = false;
    }
}