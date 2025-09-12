namespace BlazorPlayground.Areas.QuickGrid.Shared.Filtering.Models
{
    public class QuickGridFilters<T>
    {
        private readonly IReadOnlyCollection<QuickGridFilter<T>> _entries;

        public QuickGridFilters(IReadOnlyCollection<QuickGridFilter<T>> entries)
        {
            _entries = entries;
        }
    }
}
