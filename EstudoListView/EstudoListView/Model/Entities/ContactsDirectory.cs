using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoListView.Model.Entities
{
    public class ContactsDirectory : BaseObservableObject
    {
        private ObservableCollection<Contact> Contacts = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> contacts
        {
            get { return Contacts; }
            set { Contacts = value; }
        }
    }
}
