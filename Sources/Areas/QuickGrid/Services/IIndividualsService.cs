using BlazorPlayground.Areas.QuickGrid.Models;
using BlazorPlayground.Infrastructure.Data.Models;

namespace BlazorPlayground.Areas.QuickGrid.Services;

public interface IIndividualsService
{
    Task<IReadOnlyCollection<Individual>> SearchAsync(IndividualsSearch search);
}