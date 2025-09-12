namespace BlazorPlayground.Areas.QuickGrid.Models
{
    public class IndividualsSearch
    {
        public string? FirstName { get; }
        public DateTime? BirthDate { get; }

        public IndividualsSearch(
            string? firstName,
            DateTime? birthDate)
        {
            FirstName = firstName;
            BirthDate = birthDate;
        }
    }
}
