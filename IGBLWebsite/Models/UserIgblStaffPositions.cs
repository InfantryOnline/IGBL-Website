using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class UserIgblStaffPositions
    {
        public UserIgblStaffPositions()
        {
            Users = new HashSet<Users>();
        }

        public int StaffPk { get; set; }
        public int? SortOrder { get; set; }
        public string StaffPositionName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
