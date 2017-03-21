using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstudoListView.Model.Entities
{
    public class BaseObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string name = "") {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
