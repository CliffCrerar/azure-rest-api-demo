/*using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RESTFUL.Api.Models;

namespace RESTFUL.Api.Data
{
	public class Personnel
	{
		public static class SeedDataBase
		{
			public static void Initialize(EmployeeContext context)
			{
				if (!context.Employees.Any())
				{
					context.Employees.AddRange(
						new Employee
						{
							firstName = "Cliff",
							lastName = "Crerar",
							department = "Product",
							age = 33
						}
					);
				}
				context.SaveChanges();
			}
		}
	}
}*/