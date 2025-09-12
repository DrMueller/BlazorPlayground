using BlazorPlayground.Infrastructure.Data.Models.Base;

namespace BlazorPlayground.Infrastructure.Data.Models;

public class Individual : Entity
{
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public double Length { get; set; }
}