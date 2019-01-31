using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_Practice
{
    class Model
    {
        public string ModelName { get; set; }
        public DateTime DateOfInitialSale { get; set; }
        public decimal VehicleValue { get; set; }

        public string InspectionDate
        {
            get
            {
                DateTime setDate = DateOfInitialSale.AddYears(1);
                return setDate.ToShortDateString();
            }
        }

    }
}
