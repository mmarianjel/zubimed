namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES()
        {
            CONDICIONES_COMERCIALES = new HashSet<CONDICIONES_COMERCIALES>();
            CONTACTO = new HashSet<CONTACTO>();
            COTIZACION = new HashSet<COTIZACION>();
        }

        [Key]
        public int ID_CLIENTE { get; set; }

        [StringLength(50)]
        public string CLIENTE_NOMBRE { get; set; }

        [StringLength(15)]
        public string CLIENTE_RUT { get; set; }

        [StringLength(50)]
        public string CLIENTE_MAIL { get; set; }

        public int? CLIENTE_FONO { get; set; }

        [StringLength(100)]
        public string CLIENTE_DIRECCION { get; set; }

        [StringLength(50)]
        public string CLIENTE_COMUNA { get; set; }

        public DateTime? CLIENTE_CREACION { get; set; }

        public int? CLIENTE_ESTADO { get; set; }

        public int id_empresa { get; set; }

        [StringLength(50)]
        public string CLIENTE_REGION { get; set; }

        [StringLength(50)]
        public string CLIENTE_SITIOWEB { get; set; }

        [StringLength(50)]
        public string CLIENTE_REPRESENTANTE_LEGAL { get; set; }

        [StringLength(50)]
        public string CLIENTE_RUT_REPRESENTANTE_LEGAL { get; set; }

        [StringLength(50)]
        public string CLIENTE_CARGO_REPRESENTANTE_LEGAL { get; set; }

        [StringLength(50)]
        public string CLIENTE_TIPO_EMPRESA { get; set; }

        [StringLength(50)]
        public string CLIENTE_TIPO_CLIENTE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual ESTADOS ESTADOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONDICIONES_COMERCIALES> CONDICIONES_COMERCIALES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTACTO> CONTACTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COTIZACION> COTIZACION { get; set; }
    }
}
