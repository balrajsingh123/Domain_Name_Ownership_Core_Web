using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain_Name_Ownership_Core_Web.BusinessLayer;

namespace Domain_Name_Ownership_Core_Web.Models
{
    //Connects to the database 
    public class Domain_Name_Ownership_Context : DbContext
    {
        public Domain_Name_Ownership_Context (DbContextOptions<Domain_Name_Ownership_Context> options)
            : base(options)
        {
        }

        public DbSet<Domain_Name_Ownership_Core_Web.BusinessLayer.DomainHost> DomainHost { get; set; }

        public DbSet<Domain_Name_Ownership_Core_Web.BusinessLayer.Domain> Domain { get; set; }

        public DbSet<Domain_Name_Ownership_Core_Web.BusinessLayer.Owner> Owner { get; set; }

        public DbSet<Domain_Name_Ownership_Core_Web.BusinessLayer.Ownership> Ownership { get; set; }
    }
}
