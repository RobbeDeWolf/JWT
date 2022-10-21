using PeopleManager.Model;
using PeopleManager.Services.Model.Results;

namespace PeopleManager.Services.Extensions
{
    public static class ProjectionExtensions
    {
        public static IQueryable<PersonResult> ProjectToResult(this IQueryable<Person> query)
        {
            return query.Select(p => new PersonResult
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Age = p.Age,
                Email = p.Email
            });
        }
    }
}
