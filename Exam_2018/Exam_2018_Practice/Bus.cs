using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_Practice
{
    class Bus : VehicleManufacturer
    {
        private const int SIZE_ARRAY = 4;
        public Bus()
        {
            Models = new Model[SIZE_ARRAY];

        }
    }
}
