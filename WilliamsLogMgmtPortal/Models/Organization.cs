using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WilliamsLogMgmtPortal.Models
{
    public partial class Organization
    {
        public Organization()
        {
            this.Messages = new HashSet<Message>();
            this.Messages1 = new HashSet<Message>();
            this.Users = new HashSet<User>();
        }

        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Message> Messages1 { get; set; }
        public virtual ICollection<User> Users { get; set; }

        //verify that organization properties are valid
        public bool validate()
        {
            if (OrganizationID < 0) return false;
            if (Name == null) return false;
            if (Street == null) return false;
            if (City == null) return false;
            if (State == null) return false;
            if (Zip == null) return false;
            if (StartDate == null) return false;
            return true;
        }//end validate

        public bool equals(Organization organization)
        {
            if (OrganizationID != organization.OrganizationID) return false;
            if (Name != organization.Name) return false;
            if (Street != organization.Street) return false;
            if (City != organization.City) return false;
            if (State != organization.State) return false;
            if (Zip != organization.Zip) return false;
            if (StartDate != organization.StartDate) return false;
            return true;
        }//end equals


    }
}
