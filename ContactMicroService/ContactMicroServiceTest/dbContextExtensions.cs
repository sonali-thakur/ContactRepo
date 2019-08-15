using System;
using System.Collections.Generic;
using System.Text;
using ContactMicroService.DBContext;
using ContactMicroService.Model;

namespace ContactMicroServiceTest
{
	public static class dbContextExtensions
	{
		public static void Seed(ContactContext dbContext)
		{
			dbContext.Contacts.Add(new Contact
			{
				//ContactId = 1,
				FirstName = "Sonali",
				LastName = "Thakur",
				Email = "sonali@gmail.com",
				PhoneNumber = "9823233456",
				Status = true
			});
			dbContext.Contacts.Add(new Contact
			{
			//	ContactId = 2,
				FirstName = "Gunjan",
				LastName = "Thakur",
				Email = "Gunjan@gmail.com",
				PhoneNumber = "9826633456",
				Status = true
			});
			dbContext.Contacts.Add(new Contact
			{
				//ContactId = 3,
				FirstName = "Chetan",
				LastName = "ThakurAria",
				Email = "ChetanAria@gmail.com",
				PhoneNumber = "9923233456",
				Status = true
			});
			dbContext.Contacts.Add(new Contact
			{
				//ContactId = 4,
				FirstName = "Priyanka",
				LastName = "Shinde",
				Email = "Priyanka@gmail.com",
				PhoneNumber = "9866233456",
				Status = true
			});
			dbContext.Contacts.Add(new Contact
			{
				//ContactId = 4,
				FirstName = "Madhuri",
				LastName = "Chitte",
				Email = "Madhuri@gmail.com",
				PhoneNumber = "9466233456",
				Status = true
			});
			dbContext.Contacts.Add(new Contact
			{
				//ContactId = 5,
				FirstName = "Jay",
				LastName = "Shindeta",
				Email = "Jay123@gmail.com",
				PhoneNumber = "9456233456",
				Status = true
			});

			dbContext.SaveChanges();
		}
	}
}
