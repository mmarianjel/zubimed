namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERFILES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERFILES()
        {
            USUARIOS = new HashSet<USUARIOS>();
        }

        [Key]
        public int ID_PERFIL { get; set; }

        [StringLength(50)]
        public string PER_NOMBRE { get; set; }

        public int? PER_IDTIPOPERFIL { get; set; }

        public DateTime? PER_CREACION { get; set; }

        public int? PER_ESTADO { get; set; }

        public int id_empresa { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual TIPO_PERFIL TIPO_PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}
