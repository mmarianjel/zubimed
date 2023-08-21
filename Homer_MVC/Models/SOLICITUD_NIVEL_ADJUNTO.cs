namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOLICITUD_NIVEL_ADJUNTO
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string url { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo { get; set; }

        public DateTime fecha_alta { get; set; }

        public int id_solnivel { get; set; }

        public string descripcion { get; set; }

        public virtual SOLICITUD_NIVELES SOLICITUD_NIVELES { get; set; }
    }
}
