using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleApplication.Models;

namespace SampleApplication.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
            new Contact
            {
                Id = 1,
                Name = "Shubham Kale"
            },
            new Contact
            {
                Id = 2,
                Name = "Sunny Kale"
            }
            };
        }
    }
}