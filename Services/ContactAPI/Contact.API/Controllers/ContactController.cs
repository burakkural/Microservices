using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.API.Infastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public readonly IContactService contactService;
        public ContactController(IContactService ContactService)
        {
            contactService = ContactService;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
            return contactService.GetContactById(id);
        }
    }
}
