//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Imagine
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public System.DateTime Data { get; set; }
        public byte[] Photo { get; set; }
        public int DetaliuComandaId { get; set; }
    
        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
