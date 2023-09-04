using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public string Location { get; set; }=string.Empty;
        public int Capacity { get; set; }
        public decimal TicketAmount { get; set; }
        public DateTime Date { get; set; }
    }

}
