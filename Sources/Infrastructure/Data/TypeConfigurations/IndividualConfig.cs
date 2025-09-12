using BlazorPlayground.Infrastructure.Data.Models;
using BlazorPlayground.Infrastructure.Data.TypeConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorPlayground.Infrastructure.Data.TypeConfigurations;

public class IndividualConfig : EntityConfigBase<Individual>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Individual> builder)
    {
        builder.Property(f => f.BirthDate).IsRequired();
        builder.Property(f => f.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(f => f.LastName).HasMaxLength(100).IsRequired();
        builder.Property(f => f.Length).IsRequired();

        var individuals = Enumerable.Range(1, 1000)
            .Select(i => new Individual
            {
                FirstName = $"FirstName {i}",
                LastName = $"LastName {i}",
                BirthDate = DateTime.Now.AddDays(-i),
                Length = i,
                Id = i
            });

        builder.HasData(individuals);
    }
}