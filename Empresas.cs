namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresas()
        {
            this.AdminEmpresas = new HashSet<AdminEmpresas>();
            this.Categorias = new HashSet<Categorias>();
            this.Estados = new HashSet<Estados>();
            this.Ordenes = new HashSet<Ordenes>();
            this.Paquetes = new HashSet<Paquetes>();
            this.Permisos = new HashSet<Permisos>();
            this.PromoPuntos = new HashSet<PromoPuntos>();
            this.PuntosEmpresas = new HashSet<PuntosEmpresas>();
            this.ZonasEmpresas = new HashSet<ZonasEmpresas>();
        }
    
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string URLocator { get; set; }
        public Nullable<short> TiempoPromedioMin { get; set; }
        public string FormaDeEntrega { get; set; }
        public string Tema { get; set; }
        public Nullable<float> PuntajePromedio { get; set; }
        public byte[] logo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminEmpresas> AdminEmpresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Categorias> Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estados> Estados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordenes> Ordenes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paquetes> Paquetes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permisos> Permisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromoPuntos> PromoPuntos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuntosEmpresas> PuntosEmpresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZonasEmpresas> ZonasEmpresas { get; set; }
    }
}
