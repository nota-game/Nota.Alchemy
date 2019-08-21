using System;
using System.Collections.Generic;
using System.Text;

namespace Nota.Alchemy.Mixins
{
    class NotifyPropertyMixin : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void FirePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null) => this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));

    }
}
