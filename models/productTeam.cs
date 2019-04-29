
using Microsoft.EntityFrameworkCore;

namespace RESTFUL.api.models
{
	public class Employee
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string department { get; set; }
		public string dateOfBirth { get; set; }
	}

	public class EmployeeContext : DbContext
	{
		public EmployeeContext(DbContextOptions<EmployeeContext> options)
	: base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
	}

}
