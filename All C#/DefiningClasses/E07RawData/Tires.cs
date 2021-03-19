using System;
using System.Collections.Generic;
using System.Text;

namespace E07RawData
{
    public class Tires
    {
        public Tires(List<int> age , List<double> pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        public List<int> Age { get; set; }

        public List<double> Pressure { get; set; }

    }
}
