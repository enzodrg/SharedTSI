namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class PuntosEmpresas
    {
        public int IdEmpresa { get; set; }
        public string ObjectId { get; set; }
    
        public virtual Empresas Empresas { get; set; }
    }
}
