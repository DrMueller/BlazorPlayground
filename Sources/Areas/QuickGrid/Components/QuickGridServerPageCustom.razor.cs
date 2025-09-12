using BlazorPlayground.Areas.QuickGrid.Models;
using BlazorPlayground.Areas.QuickGrid.Services;
using BlazorPlayground.Areas.QuickGrid.Shared.Filtering.Models;
using BlazorPlayground.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;

namespace BlazorPlayground.Areas.QuickGrid.Components;

public partial class QuickGridServerPageCustom
{
    private readonly PaginationState pagination = new() { ItemsPerPage = 10 };

    [Inject] public required IIndividualsService IndividualsService { get; set; }

    private IQueryable<Individual> Individuals { get; set; } = new List<Individual>().AsQueryable();

    private QuickGridStringFilter FirstNameFilter { get; } = QuickGridFilter.CreateForString();

    private QuickGridDateFilter BirthdateFilter { get; } = QuickGridFilter.CreateForDate();

    private async Task Click()
    {
        var val = await IndividualsService.SearchAsync(new IndividualsSearch(
            FirstNameFilter.Value,
            BirthdateFilter.Value));

        Individuals = val.AsQueryable();
    }
}