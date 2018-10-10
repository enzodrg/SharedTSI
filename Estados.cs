namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estados()
        {
            this.Ordenes = new HashSet<Ordenes>();
        }
    
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public int IdEmpresa { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordenes> Ordenes { get; set; }
    }
}
