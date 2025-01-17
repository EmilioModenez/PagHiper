﻿using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PagHiper.Infra.MySql.Context;

namespace PagHiper.Infra.MySql
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddMySQLDependency(this IServiceCollection services, DatabaseConfiguration configuration)
		{
			services.AddDbContext<CrudDbContext, MySqlCrudDbContext>(options =>
			{
				options.EnableSensitiveDataLogging();
				//options.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
				//options.UseLoggerFactory();

				options.UseMySQL(configuration.ConnectionString, options =>
				{
					options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
				});

			});

			
			return services;
		}
	}
}
