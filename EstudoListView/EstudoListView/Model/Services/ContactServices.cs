using EstudoListView.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoListView.Model.Services
{
    public class ContactServices
    {
       
        public static ContactsDirectory loadContacts()
        {
             ContactsDirectory contactsDirectory = new ContactsDirectory();

            contactsDirectory.contacts.Add(new Contact() { Name = "Roberto", Email = "DuckBeto@gmail.com" });

            return contactsDirectory;
        }
    }
}
