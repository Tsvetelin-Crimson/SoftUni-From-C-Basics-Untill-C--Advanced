using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type typeObj = obj.GetType();
            PropertyInfo[] propertyInfos = typeObj.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                List<MyValidationAttribute> myAttributes = propertyInfo.GetCustomAttributes<MyValidationAttribute>().ToList();
                object propertyValue = propertyInfo.GetValue(obj);
                foreach (MyValidationAttribute myAttribute in myAttributes)
                {
                    bool isValid = myAttribute.IsValid(propertyValue);
                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
