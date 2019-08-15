using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactMicroService.DBContext;
using ContactMicroService.Model;
using ContactMicroService.Repository;
using System.Transactions;

namespace ContactMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
		private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
			_contactRepository = contactRepository;
        }

        // GET: api/Contacts
        [HttpGet]
        public IActionResult GetContacts()
        {
			var contacts = _contactRepository.GetContacts();
			return new OkObjectResult(contacts);
        }

        // PUT: api/Contacts
        [HttpPut]
        public IActionResult PutContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			if (contact != null)
			{
				using (var scope = new TransactionScope())
				{
					_contactRepository.UpdateContact(contact);
					scope.Complete();
					return new OkResult();
				}
					
			}
			return new NoContentResult();
        }

        // POST: api/Contacts
        [HttpPost]
        public IActionResult PostContact([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			_contactRepository.AddContact(contact);

            return CreatedAtAction(nameof(GetContacts), new { id = contact.ContactId }, contact);
        }

        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public IActionResult DeleteContact([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			_contactRepository.DeleteContact(id);

            return new OkResult();
        }

       
    }
}