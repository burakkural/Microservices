using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Models
{
  public class ContactDTO
    {
        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Fullname => $"{Firstname} {Lastname}";
    }
}
