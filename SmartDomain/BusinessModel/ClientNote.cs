using System;
using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class ClientNote : Notes

    {
        [Key]
        public int ClientNoteID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public bool VisibleToClient { get; set; }

    }
}