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
    
    public partial class subpermisos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public subpermisos()
        {
            this.rol_tiene_permiso = new HashSet<rol_tiene_permiso>();
        }
    
        public int id_subpermisos { get; set; }
        public string subpermisos1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rol_tiene_permiso> rol_tiene_permiso { get; set; }
    }
}
