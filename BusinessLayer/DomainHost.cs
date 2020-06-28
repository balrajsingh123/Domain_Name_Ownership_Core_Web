using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain_Name_Ownership_Core_Web.BusinessLayer
{
    //Domain seller information
    public class DomainHost
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DomainTypes { get; set; }
    }
}
