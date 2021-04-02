using Entities.Models;
using Repository.Extensions.Utility;
using System.Linq.Dynamic.Core;
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

        public static IQueryable<Employee> Sort(this IQueryable<Employee> employees, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return employees.OrderBy(x => x.Name);
            }

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Employee>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
            {
                return employees.OrderBy(x => x.Name);
            }

            return employees.OrderBy(orderQuery);
        }
    }
}
