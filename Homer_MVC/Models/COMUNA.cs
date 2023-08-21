namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMUNA")]
    public partial class COMUNA
    {
        [Key]
        public int ID_COMUNA { get; set; }

        [StringLength(50)]
        public string COMUNA_NOMBRE { get; set; }

        [StringLength(50)]
        public string COMUNA_REGION { get; set; }

        [StringLength(50)]
        public string COMUNA_CREACION { get; set; }

        public int? COMUNA_ESTADO { get; set; }
    }
}
