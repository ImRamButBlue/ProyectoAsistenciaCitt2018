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
    
    public partial class taller
    {
        public taller()
        {
            this.horario = new HashSet<horario>();
        }
    
        public int id_taller { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int id_encargado { get; set; }
    
        public virtual ICollection<horario> horario { get; set; }
        public virtual usuario usuario { get; set; }
    }
}