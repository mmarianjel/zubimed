namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLUJOS_NIVELES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FLUJOS_NIVELES()
        {
            FLUJOS_NIVELES_USUARIOS = new HashSet<FLUJOS_NIVELES_USUARIOS>();
            SOLICITUD_NIVELES = new HashSet<SOLICITUD_NIVELES>();
        }

        public int id { get; set; }

        public int id_flujo { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public int num_nivel { get; set; }

        public virtual FLUJOS FLUJOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLUJOS_NIVELES_USUARIOS> FLUJOS_NIVELES_USUARIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_NIVELES> SOLICITUD_NIVELES { get; set; }
    }
}
