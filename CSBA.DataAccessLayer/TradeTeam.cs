//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSBA.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TradeTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TradeTeam()
        {
            this.TradeTeamDetails = new HashSet<TradeTeamDetail>();
        }
    
        public int SeasonID { get; set; }
        public System.Guid TradeGUID { get; set; }
        public int TeamID { get; set; }
        public Nullable<int> TradeStatusID { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Trade Trade { get; set; }
        public virtual TradeStatu TradeStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TradeTeamDetail> TradeTeamDetails { get; set; }
    }
}
