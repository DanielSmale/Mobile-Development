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
            set
            {

            }
            get
            {

            }
        }

    }
}
