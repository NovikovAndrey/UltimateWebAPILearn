using Entities.Models;
using System.Linq;

namespace Repository.Extensions
{
    public static class RepositoryEmployeeExtensions
    {
        public static IQueryable<Employee> FilterEmployees(this IQueryable<Employee> employees, uint minAge, uint maxAge)
        {
            return employees.Where(x => (x.Age >= minAge && x.Age <= maxAge));
        }

        public static IQueryable<Employee> Search(this IQueryable<Employee> employees, string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return employees;
            }

            return employees.Where(x => x.Name.ToLower().Contains(search.Trim().ToLower()));
        }
    }
}
