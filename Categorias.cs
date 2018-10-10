namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categorias
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int IdEmpresa { get; set; }
    
        public virtual Empresas Empresas { get; set; }
    }
}
