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
    
    public partial class Policlinic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policlinic()
        {
            this.Meetings = new HashSet<Meeting>();
        }
    
        public int Policlinic_ID { get; set; }
        public string Policlinic_City { get; set; }
        public string Policlinic_District { get; set; }
        public string Policlinic_Hospital { get; set; }
        public string Policlinic_Name { get; set; }
        public string Policlinic_Place { get; set; }
        public Nullable<int> Doctor_ID { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}