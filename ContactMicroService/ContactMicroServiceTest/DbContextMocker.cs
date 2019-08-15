using System;
using System.Collections.Generic;
using System.Text;
using ContactMicroService.DBContext;
using Microsoft.EntityFrameworkCore;

namespace ContactMicroServiceTest
{
	public static class DbContextMocker
	{
		public static ContactContext GetContactDbContext(string dbName)
		{
			// Create options for DbContext instance
			var options = new DbContextOptionsBuilder<ContactContext>()
				.UseInMemoryDatabase(databaseName: dbName)
				.Options;

			// Create instance of DbContext
			var dbContext = new ContactContext(options);

			// Add entities in memory
			dbContextExtensions.Seed(dbContext);

			return dbContext;
		}
	}
}
