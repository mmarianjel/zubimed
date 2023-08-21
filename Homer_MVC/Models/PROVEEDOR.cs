namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROVEEDOR")]
    public partial class PROVEEDOR
    {
        [Key]
        public int ID_PROVEEDOR { get; set; }

        [StringLength(50)]
        public string PROV_NOMBRE { get; set; }

        [StringLength(50)]
        public string PROV_RUT { get; set; }

        [StringLength(50)]
        public string PROV_DIRECCION { get; set; }

        public int? PROV_FONO { get; set; }

        public int? PROV_FECHA_CREACION { get; set; }

        public int? PROV_IDUSU_CREACION { get; set; }

        public int? PROV_ESTADO { get; set; }
    }
}
