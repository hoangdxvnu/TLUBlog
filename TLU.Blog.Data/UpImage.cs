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
    
    public partial class UpImage
    {
        public int ImageID { get; set; }
        public int ImagePost { get; set; }
    
        public virtual Image Image { get; set; }
    }
}