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
    
    public partial class GetSeasonTeamOrder_Result
    {
        public int SeasonID { get; set; }
        public string SeasonName { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public Nullable<int> StadiumOrder { get; set; }
        public Nullable<bool> ActiveFlg { get; set; }
        public Nullable<int> MaxBid { get; set; }
    }
}
