namespace Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminEmpresas
    {
        public int IdAdmin { get; set; }
        public string Email { get; set; }
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string clave { get; set; }
    
        public virtual Empresas Empresas { get; set; }
    }
}
