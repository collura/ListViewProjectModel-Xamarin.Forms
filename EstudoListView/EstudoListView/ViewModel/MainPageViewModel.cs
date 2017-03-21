using EstudoListView.Model.Entities;
using EstudoListView.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EstudoListView.ViewModel
{
    class MainPageViewModel : BaseObservableObject
    {
        public ICommand RefreshListView {get; set; }
        public ObservableCollection<Contact> contacts;
        private bool isBusy;

        public ObservableCollection<Contact> Contacts { get; set; }


        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public MainPageViewModel() {
            Contacts = new ObservableCollection<Contact>();
            IsBusy = false;
            this.RefreshListView = new Command(() => LoadContacts());
            LoadContacts();
        }


        async void LoadContacts() {
            if (!IsBusy) {
                IsBusy = true;
                await Task.Delay(2000);

                var collectionOfContacts = ContactServices.loadContacts();
                foreach (var item in collectionOfContacts.contacts)
                {
                    Contacts.Add(item);
                }
                IsBusy = false;
            }
        }
    }
}
