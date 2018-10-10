namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class PuntosClientes
    {
        public int IdCliente { get; set; }
        public string ObjectId { get; set; }
    
        public virtual Clientes Clientes { get; set; }
    }
}
