using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RESTFUL.api.models;

namespace RESTFUL.api.data
{
	public class Personnel
	{
		public class SeedData
		{
			public static void initialize(SurtechStaff context)
			{
				if (!context.SurtechStaff.Any())
				{

				}
			}
		}
	}
}