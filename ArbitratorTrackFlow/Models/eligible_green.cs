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
    
    public partial class eligible_green
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eligible_green()
        {
            this.eligible_yellow_blue = new HashSet<eligible_yellow_blue>();
            this.arbitrator_assignment = new HashSet<arbitrator_assignment>();
            this.clinical_summaries = new HashSet<clinical_summaries>();
        }
    
        public int id { get; set; }
        public string ds_an { get; set; }
        public string plan_name { get; set; }
        public string provider_npi { get; set; }
        public string provider { get; set; }
        public string payer_claim_number { get; set; }
        public string pt_n { get; set; }
        public string payer_group_no { get; set; }
        public string payer_insured_no { get; set; }
        public System.DateTime dos { get; set; }
        public System.DateTime payer_ck_date { get; set; }
        public string chg { get; set; }
        public decimal ins_pay { get; set; }
        public decimal pt_pay { get; set; }
        public string ds { get; set; }
        public string an { get; set; }
        public string st_name { get; set; }
        public int plan_no { get; set; }
        public string loc_n { get; set; }
        public string payer_name { get; set; }
        public string hosp_id { get; set; }
        public System.DateTime dob { get; set; }
        public string gender { get; set; }
        public string ssn { get; set; }
        public string phone { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string employer { get; set; }
        public System.DateTime dp { get; set; }
        public string mos { get; set; }
        public string cpt { get; set; }
        public Nullable<int> modifier { get; set; }
        public Nullable<int> at { get; set; }
        public decimal pay { get; set; }
        public decimal adj { get; set; }
        public string ins_ar { get; set; }
        public string pt_ar { get; set; }
        public decimal mcr { get; set; }
        public decimal allow { get; set; }
        public string ded { get; set; }
        public decimal mcr_percent { get; set; }
        public bool adju_yn { get; set; }
        public decimal ca { get; set; }
        public string class_k { get; set; }
        public Nullable<System.DateTime> ip_dp { get; set; }
        public Nullable<System.DateTime> pp_dp { get; set; }
        public string facility { get; set; }
        public string entity { get; set; }
        public string tax_id { get; set; }
        public string fac_county { get; set; }
        public string fac_zip { get; set; }
        public string fac_state { get; set; }
        public string acct_number { get; set; }
        public Nullable<System.DateTime> returned_date { get; set; }
        public string custom_field_1 { get; set; }
        public string full_insur_yn_na { get; set; }
        public string filing_un { get; set; }
        public System.DateTime current_date { get; set; }
        public bool filing_deadline_passed_yn { get; set; }
        public bool filing_deadline_begun_yn { get; set; }
        public bool tdi_yn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eligible_yellow_blue> eligible_yellow_blue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arbitrator_assignment> arbitrator_assignment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clinical_summaries> clinical_summaries { get; set; }
    }
}
