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
    
    public partial class det_asist
    {
        public int id_detalle { get; set; }
        public int alumno_id_alumno { get; set; }
        public Nullable<int> asistencia_id_asistencia { get; set; }
        public int horario_id_horario { get; set; }
    
        public virtual alumno alumno { get; set; }
        public virtual asistencia asistencia { get; set; }
        public virtual horario horario { get; set; }
    }
}
