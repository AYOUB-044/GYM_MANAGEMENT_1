//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM_MANAGEMENT
{
    using System;
    using System.Collections.Generic;
    
    public partial class staff
    {
        public int stf_id { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> date_birth { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public System.DateTime join_dat { get; set; }
        public string adress { get; set; }
        public string job { get; set; }
        public Nullable<int> emp_id { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
