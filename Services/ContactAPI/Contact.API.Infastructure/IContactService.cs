using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Infastructure
{
   public interface IContactService
    {
        public ContactDTO GetContactById(int id);
    }
}
