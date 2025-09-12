namespace BlazorPlayground.Areas.QuickGrid.Shared.Filtering.Models
{
    public class QuickGridStringFilter : QuickGridFilter<string>
    {
        protected override bool IsFilterSet => !string.IsNullOrEmpty(Value);

        public override bool ApplyFilter(string? value)
        {
            if (!IsFilterSet || string.IsNullOrEmpty(value))
            {
                return true;
            }

            return value.Contains(Value!, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}