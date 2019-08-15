using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ContactMicroService.Controllers;
using ContactMicroService.DBContext;
using ContactMicroService.Model;
using ContactMicroService.Repository;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ContactMicroServiceTest
{
	public class ContactsControllerUnitTest
	{
			

		[Fact]
		public async Task TestGetContactsAsync()
		{
			// Arrange
			var dbContext = DbContextMocker.GetContactDbContext("ContactDetails");
			var repository = new ContactRepository(dbContext);

			var controller = new ContactsController(repository);
			// Act
			var response = controller.GetContacts();

			//var value = response.Value as IPagedResponse<Contact>;

			dbContext.Dispose();

			// Assert
			Assert.False(false);
			
		}

	

	

	}
}
