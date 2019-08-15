using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactMicroService.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactMicroService.DBContext
{
	/// <summary>
	/// Entity framework context class for Contact
	/// </summary>
	public class ContactContext : DbContext
	{
		/// <summary>
		/// dbset for Contact
		/// </summary>
		public DbSet<Contact> Contacts { get; set; }

		/// <summary>
		/// Constructor of ContactContext class
		/// </summary>
		/// <param name="options"></param>
		public ContactContext(DbContextOptions<ContactContext> options) : base(options)
		{

		}
	}
}
