//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TLU.Blog.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Navigation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<int> Icon { get; set; }
        public string Link { get; set; }
        public Nullable<int> OrderDisplay { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> EditBy { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<byte> LangId { get; set; }
    }
}
