using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class SquadOffers
    {
        public int OfferPk { get; set; }
        public int OfferedToUserFk { get; set; }
        public int OfferedByUserFk { get; set; }
        public int SquadFk { get; set; }
        public DateTime? DateOffered { get; set; }
        public bool? Accepted { get; set; }
        public DateTime? DateAccepted { get; set; }
        public bool? Active { get; set; }
    }
}
