//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstitutionToken
    {
        public int Id { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public string CreatedAt { get; set; }
        public string ExpiredAt { get; set; }
        public string Token { get; set; }
    }
}
