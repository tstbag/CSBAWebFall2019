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
    
    public partial class v_SeasonView
    {
        public int SeasonID { get; set; }
        public string SeasonName { get; set; }
        public System.DateTime DraftDate { get; set; }
        public int StartPoints { get; set; }
        public Nullable<int> MinBid { get; set; }
        public Nullable<int> PlayersDrafted { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> CurrentSeason { get; set; }
    }
}