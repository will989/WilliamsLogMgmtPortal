using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WilliamsLogMgmtPortal.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Organization { get; set; }
        public bool AdminFlag { get; set; }
        public System.DateTime ActiveDate { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }

        public virtual Organization Organization1 { get; set; }

        //verify that user properties are valid
        public bool validate()
        {
            if (UserId < 0) return false;
            if (UserName == null) return false;
            if (Password == null) return false;
            if (FirstName == null) return false;
            if (LastName == null) return false;
            if (Organization < 0) return false;
            if (ActiveDate == null) return false;
            return true;
        }//end validate

        public bool equals(User user)
        {
            if (UserId != user.UserId) return false;
            if (UserName != user.UserName) return false;
            if (Password != user.Password) return false;
            if (FirstName != user.FirstName) return false;
            if (LastName != user.LastName) return false;
            if (Organization != user.Organization) return false;
            if (AdminFlag != user.AdminFlag) return false;
            if (ActiveDate != user.ActiveDate) return false;
            if (InactiveDate != user.InactiveDate) return false;
            return true;
        }//end equals
    }
}
