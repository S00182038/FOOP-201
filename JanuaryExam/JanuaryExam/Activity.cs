using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public enum ActivityType { Air, Water, Land }

    public class Activity:IComparable
    {
        public string Name { get; set; }

        public DateTime ActivityDate { get; set; }
        public ActivityType TypeOfActivity{ get; set; }
        public decimal Cost { get; set; }

        private string _description;
        public string Description
        {
            get
            {
                return string.Format("{0}  Cost - {1:C}", _description, Cost);
            }
            set
            {
                _description = value;
            }
        }

        public int CompareTo(object obj)
        {
            Activity that = obj as Activity;
            return this.ActivityDate.CompareTo(that.ActivityDate);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, ActivityDate.ToShortDateString() );
        }
    }
}
