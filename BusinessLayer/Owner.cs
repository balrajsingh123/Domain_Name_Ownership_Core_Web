using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain_Name_Ownership_Core_Web.BusinessLayer
{
    //Domain owner infrmation 
    public class Owner
    {
        public int Id { get; set; }

        public string OwnerName { get; set; }

        public string ContactPhone { get; set; }

    }
}
