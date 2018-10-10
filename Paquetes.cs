namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paquetes
    {
        public int IdEmpresa { get; set; }
        public string Tamanio { get; set; }
    
        public virtual Empresas Empresas { get; set; }
    }
}
