using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace butterfly.service.schedule.Model
{
    [DataContract]
    public class Day
    {
        [DataMember]
        public string DayId { get; set; }
        [DataMember]
        public short DayOfWeek { get; set; }
    }
}
