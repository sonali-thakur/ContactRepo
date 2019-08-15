using System.Collections.Generic;
using System.Linq;
using ContactMicroService.DBContext;
using ContactMicroService.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactMicroService.Repository
{
	/// <summary>
	/// 
	/// </summary>
	public class ContactRepository : IContactRepository
	{
		private readonly ContactContext _dbContext;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dbContext"></param>
		public ContactRepository(ContactContext dbContext)
		{
			_dbContext = dbContext;
			if (!_dbContext.Contacts.Any())
			{
				//Adding in memory cotact object
				_dbContext.Contacts.Add(new Contact
				{
					ContactId = 1,
					FirstName = "Sonali",
					LastName = "Thakur",
					Email = "sonalicthakur15@gmail.com",
					PhoneNumber = "9823242090",
					Status = true
				});
				Save();
			}
		}

		/// <summary>
		/// function to add new contact detail
		/// </summary>
		/// <param name="contact">contact class object</param>
		public void AddContact(Contact contact)
		{
			int i=_dbContext.Contacts.Count();
			contact.ContactId = i + 1;
			_dbContext.Add(contact);
			Save();
		}

		/// <summary>
		/// function to delete contact
		/// </summary>
		/// <param name="contactid">contact id</param>
		public void DeleteContact(int contactid)
		{
			var contact = _dbContext.Contacts.Find(contactid);
			_dbContext.Contacts.Remove(contact);
			Save();
		}

		/// <summary>
		/// function to get all contact information
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Contact> GetContacts()
		{
			return _dbContext.Contacts.ToList();
		}

		/// <summary>
		/// function to save action in dbcontext
		/// </summary>
		public void Save()
		{
			_dbContext.SaveChanges();
		}

		/// <summary>
		/// function to edit contact details. We will change status active/Inactive from here.
		/// </summary>
		/// <param name="contact"></param>
		public void UpdateContact(Contact contact)
		{
			_dbContext.Entry(contact).State = EntityState.Modified;
			Save();
		}
	}
}
