//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portfolio_FinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public int ProjectID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string CodeLanguage { get; set; }
        public string Picture { get; set; }
        public string Link { get; set; }
    
        public virtual ApplicationType ApplicationType { get; set; }
    }
}
