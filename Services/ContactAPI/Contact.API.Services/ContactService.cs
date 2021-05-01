using Contact.API.Infastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO { Id = id, Firstname = "Burak", Lastname = "Kural" };
        }
    }
}
