using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BindToProperty
{
    class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _NumberAsString;

        public string NumberAsString
        {
            get => _NumberAsString;
            set
            {
                if (!value.Equals(_NumberAsString))
                {
                    _NumberAsString = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NumberAsString"));
                    }
                }
            }
        }

    }
}
