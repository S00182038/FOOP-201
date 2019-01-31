using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_Practice
{
    public abstract class VehicleManufacturer : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }


        public int CompareTo(object obj)
        {
            VehicleManufacturer that = obj as VehicleManufacturer;
            return Name.CompareTo(that.Name);
        }

        //override method
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
}
