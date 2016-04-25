using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Classes
{
    public class Bindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string n="")
        {
            if(PropertyChanged!=null)
                PropertyChanged(typeof(Controllers.UserController),new PropertyChangedEventArgs(n));
        }
    }
}
