//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_Appointment_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meeting
    {
        public int Meeting_ID { get; set; }
        public Nullable<int> Policlinic_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public Nullable<int> Doctor_ID { get; set; }
        public Nullable<int> Hour_ID { get; set; }
        public Nullable<int> Date_ID { get; set; }
    
        public virtual Date Date { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Hour Hour { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Policlinic Policlinic { get; set; }
    }
}