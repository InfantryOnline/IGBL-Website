using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class UserIgblStaff
    {
        public int StaffPk { get; set; }
        public int? UserFk { get; set; }
        public string Description { get; set; }
    }
}
