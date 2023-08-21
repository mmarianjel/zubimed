namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONDICIONES_COMERCIALES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONDICIONES_COMERCIALES()
        {
            RELA_SERVICIOS_CONDICIONESC = new HashSet<RELA_SERVICIOS_CONDICIONESC>();
        }

        public int ID { get; set; }

        public int ID_CLIENTE { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RELA_SERVICIOS_CONDICIONESC> RELA_SERVICIOS_CONDICIONESC { get; set; }
    }
}
