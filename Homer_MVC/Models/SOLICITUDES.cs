namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOLICITUDES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOLICITUDES()
        {
            SOLICITUD_NIVELES = new HashSet<SOLICITUD_NIVELES>();
        }

        public int id { get; set; }

        public int id_cotizacion { get; set; }

        public int id_usuarioInicio { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_modficacion { get; set; }

        public int id_estado { get; set; }

        public int nivel_actual { get; set; }

        public int id_flujo { get; set; }

        public virtual COTIZACION COTIZACION { get; set; }

        public virtual ESTADOS ESTADOS { get; set; }

        public virtual FLUJOS FLUJOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_NIVELES> SOLICITUD_NIVELES { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
