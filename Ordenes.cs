namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordenes()
        {
            this.Productos = new HashSet<Productos>();
        }
    
        public int IdOrden { get; set; }
        public int IdEmpresa { get; set; }
        public int IdCliente { get; set; }
        public int Precio { get; set; }
        public string TipoMoneda { get; set; }
        public float Comision { get; set; }
        public int IdEstado { get; set; }
        public string ObjectIdPuntoEntrega { get; set; }
        public short Volumen { get; set; }
        public float Peso { get; set; }
        public string FormaDePago { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Empresas Empresas { get; set; }
        public virtual Estados Estados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
