using System;
using System.Collections.Generic;
using System.Text;

namespace BMI_Calculator
{
    class BodyParameter
    {
        private double? _value;
        private double _minValue;
        private double _maxValue;
        private string _nameString;
        private string _unitString;

        public BodyParameter(double min, double max, string parameterName, string units)
        {
            _minValue = min;
            _maxValue = max;
            _nameString = parameterName;
            _unitString = units;
        }

        public double? Value
        {
            get
            {
                return _value;
            }
            set
            {
                if ((value >= _minValue) && (value <= _maxValue))
                {
                    _value = value;
                }
                else
                {
                    _value = null;
                }

            }
        }
        public static implicit operator double?(BodyParameter d)
        {
            return d.Value;
        }

        public bool SetValueFromString(string stringValue, out string errorString)
        {
            if (double.TryParse(stringValue, out double newValue))
            {
                // succeeded in parsing...
                Value = newValue;
                if (Value == null)
                {
                    // out of range
                    errorString = string.Format(_nameString + " must be between {0:f1} and {1:f1}", _minValue, _maxValue) + _unitString;
                    return false;
                }
                else
                {
                    // all good
                    errorString = "";
                    return true;
                }
            }
            else
            {
                //failed to parse
                _value = null;
                errorString = "Please enter a numerical value";
                return false;
            }
        }

    }
}
