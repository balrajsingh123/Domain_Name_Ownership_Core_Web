using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain_Name_Ownership_Core_Web.BusinessLayer
{

    //Represents an ownership of a domain
    public class Ownership
    {
        public int Id { get; set; }

        public int OwnerId { get; set; }

        public Owner Owner { get; set; }

        public int DomainId { get; set; }

        public Domain Domain { get; set; }
    }
}
