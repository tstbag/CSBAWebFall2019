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
    
    public partial class v_SeasonTeamPlayerPosition
    {
        public int SeasonID { get; set; }
        public int TeamID { get; set; }
        public Nullable<int> Points { get; set; }
        public string PlayerName { get; set; }
        public string PositionName { get; set; }
        public string PositionNameLong { get; set; }
        public string TeamName { get; set; }
        public System.Guid PlayerGUID { get; set; }
        public Nullable<int> PositionSortOrder { get; set; }
    }
}