namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RELA_SERVICIOS_CONDICIONESC
    {
        public int ID { get; set; }

        public int ID_SERVICIOS { get; set; }

        public int ID_CONDICIONES_COMERCIALES { get; set; }

        public virtual CONDICIONES_COMERCIALES CONDICIONES_COMERCIALES { get; set; }

        public virtual SERVICIOS SERVICIOS { get; set; }
    }
}
