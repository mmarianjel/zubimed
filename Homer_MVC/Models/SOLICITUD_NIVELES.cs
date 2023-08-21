namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOLICITUD_NIVELES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOLICITUD_NIVELES()
        {
            SOLICITUD_NIVEL_ADJUNTO = new HashSet<SOLICITUD_NIVEL_ADJUNTO>();
        }

        public int id { get; set; }

        public int id_solicitud { get; set; }

        public int id_flujonivel { get; set; }

        public DateTime fecha_alta { get; set; }

        [StringLength(50)]
        public string accion { get; set; }

        public DateTime? fecha_accion { get; set; }

        public int? id_usuario { get; set; }

        public int? id_usuario_accion { get; set; }

        public string observacion { get; set; }

        public virtual FLUJOS_NIVELES FLUJOS_NIVELES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_NIVEL_ADJUNTO> SOLICITUD_NIVEL_ADJUNTO { get; set; }

        public virtual SOLICITUDES SOLICITUDES { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
