//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krakflix.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chapter
    {
        public string IdChapter { get; set; }
        public string IdSerie { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Path { get; set; }
    
        public virtual Serie Serie { get; set; }
    }
}