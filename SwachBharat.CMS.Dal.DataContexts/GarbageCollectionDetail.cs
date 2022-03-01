//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwachBharat.CMS.Dal.DataContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class GarbageCollectionDetail
    {
        public int gcId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> houseId { get; set; }
        public Nullable<int> gpId { get; set; }
        public Nullable<System.DateTime> gcDate { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string gcImage { get; set; }
        public string gcQRcode { get; set; }
        public string gpBeforImage { get; set; }
        public string gpAfterImage { get; set; }
        public Nullable<int> gcType { get; set; }
        public string vehicleNumber { get; set; }
        public string note { get; set; }
        public string locAddresss { get; set; }
        public Nullable<int> garbageType { get; set; }
        public Nullable<System.DateTime> modified { get; set; }
        public Nullable<int> dyId { get; set; }
        public Nullable<decimal> totalGcWeight { get; set; }
        public Nullable<decimal> totalDryWeight { get; set; }
        public Nullable<decimal> totalWetWeight { get; set; }
        public string batteryStatus { get; set; }
        public Nullable<double> Distance { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string RFIDTagId { get; set; }
        public string RFIDReaderId { get; set; }
        public Nullable<int> SourceId { get; set; }
        public string OutbatteryStatus { get; set; }
        public string WasteType { get; set; }
        public string EmployeeType { get; set; }
        public Nullable<int> LWId { get; set; }
        public Nullable<int> SSId { get; set; }
        public string LOS { get; set; }
        public Nullable<int> commercialId { get; set; }
        public Nullable<int> CTPTId { get; set; }
        public Nullable<int> SWMId { get; set; }
        public Nullable<int> TNS { get; set; }
        public string TOT { get; set; }
        public string CGarbageType { get; set; }
        public Nullable<int> AreaId { get; set; }
    }
}
