//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRP.Arbis.DataAccessLayer.Contexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class SchoolPosts
    {
        public string Id { get; set; }
        public string School_Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    
        public virtual Category Category1 { get; set; }
        public virtual Schools Schools { get; set; }
    }
}
