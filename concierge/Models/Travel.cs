//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace concierge.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Travel
    {
        public Travel()
        {
            this.Accomodations = new HashSet<Accomodation>();
        }
    
        public System.Guid TravelId { get; set; }
        public System.Guid AppUserId { get; set; }
        public Nullable<byte> TravelModeId { get; set; }
        public int CountryVisiting { get; set; }
        public Nullable<int> CityVisiting { get; set; }
        public System.DateTime TravelStartDate { get; set; }
        public Nullable<int> TravelStartTimezoneId { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public Nullable<int> ArrivalTimeZoneId { get; set; }
        public System.Guid TravelReferenceId { get; set; }
        public string VehicleName { get; set; }
        public Nullable<System.Guid> TravelOperatorId { get; set; }
    
        public virtual ICollection<Accomodation> Accomodations { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual AppTimeZone TimeZone { get; set; }
        public virtual AppTimeZone TimeZone1 { get; set; }
        public virtual TravelMode TravelMode { get; set; }
        public virtual TravelOperator TravelOperator { get; set; }
    }
}
