using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactMicroService.Model;

namespace ContactMicroService.Repository
{
	/// <summary>
	/// Repository Interface
	/// </summary>
	public interface IContactRepository
	{
		/// <summary>
		/// Function to get allcontacts
		/// </summary>
		/// <returns></returns>
		IEnumerable<Contact> GetContacts();

		/// <summary>
		/// function to add contact
		/// </summary>
		/// <param name="contact"></param>
		void AddContact(Contact contact);

		/// <summary>
		/// function to update contact
		/// </summary>
		/// <param name="contact"></param>
		void UpdateContact(Contact contact);

		/// <summary>
		/// funcion to permanant delete contact
		/// </summary>
		/// <param name="contactid"></param>
		void DeleteContact(int contactid);

		/// <summary>
		/// function to save in db
		/// </summary>
		void Save();

	}
}
