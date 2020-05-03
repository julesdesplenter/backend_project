using System;
using System.Collections.Generic;
using System.Text;

namespace Invitor.Model
{
    public class PersonEvent
    {
        public Guid EventId { get; set; }
        public Guid PersonId { get; set; }
        public Event Event { get; set; }
        public Person Person { get; set; }
    }
}
