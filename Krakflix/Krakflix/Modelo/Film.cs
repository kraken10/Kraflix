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
    
    public partial class Film
    {
        public string IdFilm { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Rate { get; set; }
        public string Path { get; set; }
        public int IdGenre { get; set; }
    
        public virtual Genre Genre { get; set; }
    }
}