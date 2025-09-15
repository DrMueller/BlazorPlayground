
namespace BlazorPlayground.Areas.Bootstrap.LazyTabs
{
    public partial class SlowComponent
    {
        private bool IsLoading { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            IsLoading = false;
        }
    }
}
