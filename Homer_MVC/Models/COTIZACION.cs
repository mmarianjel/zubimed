namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COTIZACION")]
    public partial class COTIZACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COTIZACION()
        {
            COTIZACION_DETALLE = new HashSet<COTIZACION_DETALLE>();
            SOLICITUDES = new HashSet<SOLICITUDES>();
        }

        public int id { get; set; }

        public int id_cliente { get; set; }

        public int id_estado { get; set; }

        public int act { get; set; }

        public DateTime fecha_creacion { get; set; }

        [StringLength(50)]
        public string numero { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COTIZACION_DETALLE> COTIZACION_DETALLE { get; set; }

        public virtual ESTADOS ESTADOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUDES> SOLICITUDES { get; set; }
    }
}
