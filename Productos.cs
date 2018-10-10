namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        public string ObjectId { get; set; }
        public int IdOrden { get; set; }
    
        public virtual Ordenes Ordenes { get; set; }
    }
}
