namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTACTO")]
    public partial class CONTACTO
    {
        [Key]
        public int ID_CONTACTO { get; set; }

        [StringLength(50)]
        public string CON_NOMBRE { get; set; }

        [StringLength(50)]
        public string CON_APATERNO { get; set; }

        [StringLength(50)]
        public string CON_AMATERNO { get; set; }

        public int? CON_IDCLIENTE { get; set; }

        [StringLength(50)]
        public string CON_MAIL { get; set; }

        public int? CON_FONO { get; set; }

        public DateTime? CON_CREACION { get; set; }

        public int? CON_ESTADO { get; set; }

        [StringLength(50)]
        public string CON_CARGO { get; set; }

        [StringLength(50)]
        public string CON_SUCURSAL { get; set; }

        [StringLength(50)]
        public string CON_RUT_SUC { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual ESTADOS ESTADOS { get; set; }
    }
}
