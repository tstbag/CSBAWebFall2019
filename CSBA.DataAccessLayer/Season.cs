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
    
    public partial class Season
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Season()
        {
            this.SeasonTeams = new HashSet<SeasonTeam>();
            this.SeasonTeamPlayers = new HashSet<SeasonTeamPlayer>();
            this.SeasonTeamStadiums = new HashSet<SeasonTeamStadium>();
            this.Trades = new HashSet<Trade>();
            this.Players = new HashSet<Player>();
            this.Stadia = new HashSet<Stadium>();
        }
    
        public int SeasonID { get; set; }
        public string SeasonName { get; set; }
        public System.DateTime DraftDate { get; set; }
        public int StartPoints { get; set; }
        public Nullable<int> MinBid { get; set; }
        public Nullable<bool> CurrentSeason { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeasonTeam> SeasonTeams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeasonTeamPlayer> SeasonTeamPlayers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeasonTeamStadium> SeasonTeamStadiums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trade> Trades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Players { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stadium> Stadia { get; set; }
    }
}
