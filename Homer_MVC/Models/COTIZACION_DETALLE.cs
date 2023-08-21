namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COTIZACION_DETALLE
    {
        public int id { get; set; }

        public int id_cotizacion { get; set; }

        public int cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string cod_articulo { get; set; }

        public virtual COTIZACION COTIZACION { get; set; }
    }
}
