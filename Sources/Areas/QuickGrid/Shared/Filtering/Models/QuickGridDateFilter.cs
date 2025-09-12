namespace BlazorPlayground.Areas.QuickGrid.Shared.Filtering.Models
{
    public class QuickGridDateFilter : QuickGridFilter<DateTime?>
    {
        protected override bool IsFilterSet => Value != null;

        public override bool ApplyFilter(DateTime? value)
        {
            if (!IsFilterSet || value == null)
            {
                return true;
            }

            return Value!.Value.Date == value.Value.Date;
        }
    }
}