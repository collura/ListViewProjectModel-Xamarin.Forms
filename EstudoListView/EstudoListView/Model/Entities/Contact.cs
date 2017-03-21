using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoListView.Model.Entities
{
    public class Contact : BaseObservableObject
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }


        private string email;
        public string Email {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }
    }
}
