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
    
    public partial class sp_SeasonTeamDraft_Select_Result
    {
        public int SeasonID { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string OwnerName { get; set; }
        public Nullable<System.Guid> OwnerUserID { get; set; }
        public string OwnerEmail { get; set; }
        public int SumPoints { get; set; }
        public int CountPlayers { get; set; }
        public int StartPoints { get; set; }
        public Nullable<int> MinBid { get; set; }
        public Nullable<int> MaxBid { get; set; }
        public int CountHitter { get; set; }
        public int PitcherCount { get; set; }
    }
}
