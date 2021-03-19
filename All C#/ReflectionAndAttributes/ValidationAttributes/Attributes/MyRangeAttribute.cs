using System;


namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            int intObj = Convert.ToInt32(obj);
            return intObj >= this.minValue && intObj <= this.maxValue;            
        }
    }
}
