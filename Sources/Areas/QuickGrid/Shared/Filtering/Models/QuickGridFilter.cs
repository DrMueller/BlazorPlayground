namespace BlazorPlayground.Areas.QuickGrid.Shared.Filtering.Models
{
    public abstract class QuickGridFilter<T>
    {
        public string CssClass => IsFilterSet ? "filtered" : string.Empty;

        public T? Value { get; set; }

        protected abstract bool IsFilterSet { get; }

        public void ClearFilter()
        {
            Value = default;
        }

        public abstract bool ApplyFilter(T? value);
    }

    public static class QuickGridFilter
    {
        public static QuickGridStringFilter CreateForString()
        {
            return new QuickGridStringFilter();
        }

        public static QuickGridDateFilter CreateForDate()
        {
            return new QuickGridDateFilter();
        }

        public static QuickGridBooleanFilter CreateForBoolean()
        {
            return new QuickGridBooleanFilter();
        }
    }
}