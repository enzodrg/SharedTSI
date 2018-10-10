namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class PromoPuntos
    {
        public int IdEmpresa { get; set; }
        public int IdCliente { get; set; }
        public int Puntos { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Empresas Empresas { get; set; }
    }
}
