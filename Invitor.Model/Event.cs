using System;
using System.Collections.Generic;
using System.Text;

namespace Invitor.Model
{
    public class Event
    {
        public Guid EventId { get; set; } = new Guid();
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime dateTime { get; set; }
    }
}
