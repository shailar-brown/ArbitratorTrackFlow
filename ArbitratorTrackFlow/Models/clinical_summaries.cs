//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArbitratorTrackFlow.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class clinical_summaries
    {
        public int id { get; set; }
        public string health_plan { get; set; }
        public string grp { get; set; }
        public string inv_no { get; set; }
        public string mrn { get; set; }
        public System.DateTime dos { get; set; }
        public string procedure { get; set; }
        public string patient_name { get; set; }
        public string physician_name { get; set; }
        public string request_id { get; set; }
        public System.DateTime due_date { get; set; }
        public string clinical_summary_assigned_completed { get; set; }
        public string comment { get; set; }
        public int eligible_green_id { get; set; }
    
        public virtual eligible_green eligible_green { get; set; }
    }
}