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
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int ID { get; set; }
        public int AccountID { get; set; }
        public string UpFile { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public string PostContent { get; set; }
        public Nullable<int> Like { get; set; }
        public Nullable<int> Dislike { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<byte> LangId { get; set; }
        public Nullable<int> Permission { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
