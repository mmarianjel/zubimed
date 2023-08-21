namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            FLUJOS_NIVELES_USUARIOS = new HashSet<FLUJOS_NIVELES_USUARIOS>();
            SOLICITUD_NIVELES = new HashSet<SOLICITUD_NIVELES>();
            SOLICITUDES = new HashSet<SOLICITUDES>();
        }

        [Key]
        public int ID_USUARIO { get; set; }

        [StringLength(50)]
        public string USU_NOMBRE { get; set; }

        [StringLength(50)]
        public string USU_MAIL { get; set; }

        public int? USU_IDPERFIL { get; set; }

        public DateTime? USU_CREACION { get; set; }

        public int? USU_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLUJOS_NIVELES_USUARIOS> FLUJOS_NIVELES_USUARIOS { get; set; }

        public virtual PERFILES PERFILES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_NIVELES> SOLICITUD_NIVELES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUDES> SOLICITUDES { get; set; }
    }
}
