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
    
    public partial class alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alumno()
        {
            this.tabla_medica = new HashSet<tabla_medica>();
            this.programa = new HashSet<programa>();
            this.tutor = new HashSet<tutor>();
            this.foto_alumno = new HashSet<foto_alumno>();
        }
    
        public int id_alumno { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public string ciclo_escolar { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public string edad_alumno { get; set; }
        public string CURP_alumno { get; set; }
        public string estado_nacimiento_alumno { get; set; }
        public string ciudad_nacimiento_alumno { get; set; }
        public string colonia_alumno { get; set; }
        public string calle_alumno { get; set; }
        public string numero_alumno { get; set; }
        public string telefono_personal_alumno { get; set; }
        public string escuela_procedencia_alumno { get; set; }
        public string documentacion_alumno { get; set; }
        public string atendido_por { get; set; }
        public string tipo_ingreso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabla_medica> tabla_medica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<programa> programa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tutor> tutor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<foto_alumno> foto_alumno { get; set; }
    }
}
