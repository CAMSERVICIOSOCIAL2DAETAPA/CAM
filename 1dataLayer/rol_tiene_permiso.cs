//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1dataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class rol_tiene_permiso
    {
        public int id_rol { get; set; }
        public int id_permiso { get; set; }
        public int id_subpermiso { get; set; }
    
        public virtual permisos permisos { get; set; }
        public virtual roles roles { get; set; }
        public virtual subpermisos subpermisos { get; set; }
    }
}
