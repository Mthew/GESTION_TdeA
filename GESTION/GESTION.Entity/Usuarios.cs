//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GESTION.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.RolesUsuario = new HashSet<RolesUsuario>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        public virtual Personas Personas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolesUsuario> RolesUsuario { get; set; }
    }
}
