//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.det_asist = new HashSet<det_asist>();
            this.taller = new HashSet<taller>();
        }
    
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public byte habilitado { get; set; }
        public string tipo_usuario { get; set; }
    
        public virtual ICollection<det_asist> det_asist { get; set; }
        public virtual ICollection<taller> taller { get; set; }
    }
}
