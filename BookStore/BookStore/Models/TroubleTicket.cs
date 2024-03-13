using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class TroubleTicket
    {
        public int TicketId { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDesc { get; set; }
        public string Category { get; set; }
        public string ReportingEmail { get; set; }
        public DateTime OrigDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string ResponderEmail { get; set; }
        public string ResponderNotes { get; set; }
        public bool Active { get; set; }
    }
}
