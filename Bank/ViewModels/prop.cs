using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ViewModels
{
    public partial class prop : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void pchange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
