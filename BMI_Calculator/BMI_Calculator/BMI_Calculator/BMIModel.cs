using System;
using System.Collections.Generic;
using System.Text;

namespace BMI_Calculator
{
    public class BMIModel
    {

        private BodyParameter weight = new BodyParameter(min: 20.0, max: 200.0, "Weight", "Kg");
        private BodyParameter height = new BodyParameter(min: 0.5, max: 3.0, "Height", "metres");

        public double? BMIValue
        {
            get
            {
                if ((weight != null) && (height != null))
                {
                    return weight / (height * height);
                }
                else
                {
                    return null;
                }
            }

        }
        public static implicit operator double?(BMIModel m)
        {
            return m.BMIValue;
        }

        public bool SetWeightAsString(string strWeight, out string errorString)
        {
            return weight.SetValueFromString(strWeight, out errorString);
        }

        public bool SetHeightAsString(string strHeight, out string errorString)
        {
            return height.SetValueFromString(strHeight, out errorString);
        }
    }
}
