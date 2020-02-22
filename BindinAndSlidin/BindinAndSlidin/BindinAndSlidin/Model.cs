using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BindinAndSlidin
{
    class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _sliderValue;

        public int sliderValue
        {
            get => _sliderValue;

            set
            {
                if (!value.Equals(_sliderValue))
                {
                    _sliderValue = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("sliderValue"));
                    }
                }
            }

        }


    }
}
