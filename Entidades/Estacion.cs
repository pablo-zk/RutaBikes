//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estacion()
        {
            this.Anclajes = new HashSet<Anclaje>();
        }
    
        public int id { get; set; }
        public string ubicacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anclaje> Anclajes { get; set; }

        public Estacion(int id, string ubicacion, ICollection<Anclaje> anclajes)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            Anclajes = anclajes;
        }
    }
}
