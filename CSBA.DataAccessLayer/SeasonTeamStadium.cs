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
    
    public partial class SeasonTeamStadium
    {
        public int SeasonID { get; set; }
        public int TeamID { get; set; }
        public int StadiumID { get; set; }
        public Nullable<int> Points { get; set; }
    
        public virtual Season Season { get; set; }
        public virtual Stadium Stadium { get; set; }
        public virtual Team Team { get; set; }
    }
}