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
    
    public partial class horario
    {
        public horario()
        {
            this.det_asist = new HashSet<det_asist>();
        }
    
        public int id_horario { get; set; }
        public System.TimeSpan hora_inicio { get; set; }
        public System.TimeSpan hora_termino { get; set; }
        public string dia_semana { get; set; }
        public int cupo { get; set; }
        public int taller_id_taller { get; set; }
    
        public virtual ICollection<det_asist> det_asist { get; set; }
        public virtual taller taller { get; set; }
    }
}
